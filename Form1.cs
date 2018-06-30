using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Windows.Forms;
using System.Threading;
using System.IO;
using System.Reflection;

namespace SnippetCreation
{
    public partial class MainForm : Form
    {
        private class Literal
        {
            public string id;
            public string toolTip;
            public string Default;

            public string ID => id;
        }
        private void TreeView_AfterCheck(object sender, TreeViewEventArgs e)
        {
            foreach (TreeNode node in e.Node.Nodes) // для кожного дочірнього вузла
            {
                node.Checked = e.Node.Checked; // встановлюємо відповідний стан Checked
            }
        }
        XmlWriter xmlWR;
        XmlReader xmlRE;

        string AssembliesFileRoot = @"C:\Users\Тарас\documents\visual studio 2015\Projects\SnippetCreation\SnippetCreation\Resources\A.dat";
        string NameSpacesFileRoot = @"C:\Users\Тарас\documents\visual studio 2015\Projects\SnippetCreation\SnippetCreation\Resources\N.dat";
        private void ChangeTextColor()
        {
            while(true)
            {
                if(LitetalListBox.Items.Count > 0)
                {
                    for(int i = 0; i < LitetalListBox.Items.Count; ++i)
                    {
                        string id = (LitetalListBox.Items[i] as Literal).ID;
                        while(CodeRichTextBox.Text.IndexOf(id) != -1)
                        {
                            CodeRichTextBox.Select(CodeRichTextBox.Text.IndexOf(id), id.Length);
                            CodeRichTextBox.SelectionColor = Color.Red;
                        }
                        
                    }
                }
                
            }
        }
        List<Literal> ll = new List<Literal>();
        public MainForm()
        {
            InitializeComponent();
            
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            NamespaceTreeView.BeginUpdate();

            using (BinaryReader ReadAssembly  = new BinaryReader(File.OpenRead(AssembliesFileRoot)),
                                ReadNamespace = new BinaryReader(File.OpenRead(NameSpacesFileRoot)))
            {
                int rootIndex = 0;
                int AssemblyCount = ReadAssembly.ReadInt32();

                while (AssemblyCount-- != 0)
                {
                    NamespaceTreeView.Nodes.Add(ReadAssembly.ReadString());
                    int NamespacesCount = ReadAssembly.ReadInt32();

                    while (NamespacesCount-- != 0)
                    { 
                        NamespaceTreeView.Nodes[rootIndex].Nodes.Add(ReadNamespace.ReadString());
                    }

                    ++rootIndex;
                }
            }
                        
            NamespaceTreeView.EndUpdate();
            //NamespaceTreeView.ExpandAll(); // розгортаємо все дерево
            NamespaceTreeView.AfterCheck += TreeView_AfterCheck;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private async void InvalidBox(dynamic sender)
        {
            if(sender.BackColor.ToArgb() != Color.White.ToArgb())
            {
                return;
            }

            int BlueGreen = 180;
            while (BlueGreen != 256)
            {
                sender.BackColor = Color.FromArgb(255, BlueGreen, BlueGreen);
                ++BlueGreen;
                await Task.Delay(25);
            }
        }
        private void formSnippet(string xmlFileName)
        {
            xmlWR = XmlWriter.Create(xmlFileName);

            xmlWR.WriteStartDocument();

            xmlWR.WriteStartElement("CodeSnippets");
            xmlWR.WriteStartElement("CodeSnippet");
            xmlWR.WriteAttributeString("Format", "1.0.0");

            WriteHeader(xmlWR);
            xmlWR.WriteStartElement("Snippet");
            WriteSnippet(xmlWR);
            xmlWR.WriteEndElement();

            xmlWR.WriteEndElement();
            xmlWR.WriteEndElement();

            xmlWR.WriteEndDocument();
            xmlWR.Flush();
            xmlWR.Close();

        }
        private void WriteHeader(XmlWriter xmlWR)
        {
            xmlWR.WriteStartElement("Header");

            if(!String.IsNullOrWhiteSpace(TitleTextBox.Text))
            {
                xmlWR.WriteStartElement("Title");
                xmlWR.WriteValue(TitleTextBox.Text);
                xmlWR.WriteEndElement();
            }
            if (!String.IsNullOrWhiteSpace(AuthorTextBox.Text))
            {
                xmlWR.WriteStartElement("Author");
                xmlWR.WriteValue(AuthorTextBox.Text);
                xmlWR.WriteEndElement();
            }
            if (!String.IsNullOrWhiteSpace(DescTextBox.Text))
            {
                xmlWR.WriteStartElement("Description");
                xmlWR.WriteValue(DescTextBox.Text);
                xmlWR.WriteEndElement();
            }
            if (!String.IsNullOrWhiteSpace(ShortcutTextBox.Text))
            {
                xmlWR.WriteStartElement("Shortcut");
                xmlWR.WriteValue(ShortcutTextBox.Text);
                xmlWR.WriteEndElement();
            }

            xmlWR.WriteEndElement();
        }
        private void WriteSnippet(XmlWriter xmlWR)
        {
            WriteImport(xmlWR);
            WriteDeclaration(xmlWR);
            WriteCode(xmlWR);
        }
        private void WriteCode(XmlWriter xmlWR)
        {
            xmlWR.WriteStartElement("Code");
            xmlWR.WriteAttributeString("Language", "CSharp");

            xmlWR.WriteCData(formText());

            xmlWR.WriteEndElement();
        }
        private string formText()
        {
            string[] IDS = new string[ll.Count];
            for(int i = 0; i < ll.Count; ++i)
            {
                IDS[i] = ll[i].ID;
            }
            string text = CodeRichTextBox.Text;
            for(int i = 0; i < IDS.Length; ++i)
            {
                text = text.Replace(IDS[i], String.Concat('$', IDS[i], "$"));
            }

            return text;
        }
        private void WriteDeclaration(XmlWriter xmlWR)
        {
            if(ll.Count > 0)
            {
                xmlWR.WriteStartElement("Declarations");

                for (int i = 0; i < ll.Count; ++i)
                {
                    xmlWR.WriteStartElement("Literal");

                    xmlWR.WriteStartElement("ID");
                    xmlWR.WriteValue(ll[i].id);
                    xmlWR.WriteEndElement();

                    xmlWR.WriteStartElement("ToolTip");
                    xmlWR.WriteValue(ll[i].toolTip);
                    xmlWR.WriteEndElement();

                    xmlWR.WriteStartElement("Default");
                    xmlWR.WriteValue(ll[i].Default);
                    xmlWR.WriteEndElement();

                    xmlWR.WriteEndElement();
                }

                xmlWR.WriteEndElement();
            }
        }

        private Tuple<List<string>, List<string>> CheckedRootInfo()
        {
            List<string> Assembly = new List<string>();
            List<string> Namespace = new List<string>();

            foreach (TreeNode root in NamespaceTreeView.Nodes)
            {
                foreach (TreeNode child in root.Nodes)
                {
                    if (child.Checked)
                    {
                        string assemblyName = child.Parent.Text;
                        if (!Assembly.Contains(assemblyName)) Assembly.Add(assemblyName);
                        Namespace.Add(child.Text);
                    }
                }
            }
            return Tuple.Create(Assembly, Namespace);
        }

        private void WriteImport(XmlWriter xmlWR)
        {
            // мультивідображення Dictionary<string, List<string>>;
            // MultiMap Imports = new MultiMap();
            Tuple<List<string>, List<string>> info = CheckedRootInfo();

            if (info.Item1.Count + info.Item2.Count > 0) // кількість вибраних елементів 
            {

                List<string> Assembly = info.Item1;
                List<string> NameSpaces = info.Item2;

                xmlWR.WriteStartElement("References");
                for (int i = 0; i < Assembly.Count; ++i)
                {
                    xmlWR.WriteStartElement("Reference");
                    xmlWR.WriteStartElement("Assembly");
                    xmlWR.WriteValue(Assembly[i] + ".dll");
                    xmlWR.WriteEndElement();
                    xmlWR.WriteEndElement();
                }
                xmlWR.WriteEndElement();


                xmlWR.WriteStartElement("Imports");
                for (int i = 0; i < NameSpaces.Count; ++i)
                {
                    xmlWR.WriteStartElement("Import");
                    xmlWR.WriteStartElement("Namespace");
                    xmlWR.WriteValue(NameSpaces[i]);
                    xmlWR.WriteEndElement();
                    xmlWR.WriteEndElement();
                }
                xmlWR.WriteEndElement();
            }
        }

        private void LitetalListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LitetalListBox.SelectedItem == null)
            {
                IdTextBox.Text = ToolTipTextBox.Text = DefaultTextBox.Text = "";
                return;
            }
            IdTextBox.Text = (LitetalListBox.SelectedItem as Literal).id;
            ToolTipTextBox.Text = (LitetalListBox.SelectedItem as Literal).toolTip;
            DefaultTextBox.Text = (LitetalListBox.SelectedItem as Literal).Default;
        }

        private void Add_btn_Click(object sender, EventArgs e)
        {
            string selectedValue = CodeRichTextBox.SelectedText.Trim();
            if (!string.IsNullOrWhiteSpace(selectedValue))
            {
                
                // якщо таке слово вже є
                if (ListBox.NoMatches != LitetalListBox.FindStringExact(selectedValue))
                {
                    return;
                }

                ll.Add(new Literal()
                {
                    id = selectedValue,
                    toolTip = selectedValue,
                    Default = selectedValue
                });

                LitetalListBox.DataSource = null;
                LitetalListBox.DataSource = ll;
                LitetalListBox.DisplayMember = "ID";


                if (LitetalListBox.Items.Count > 0)
                {
                    for (int i = 0; i < LitetalListBox.Items.Count; ++i)
                    {
                        string id = (LitetalListBox.Items[i] as Literal).ID;


                        string[] str = CodeRichTextBox.Text.Split();
                        List<int> indexis = new List<int>(5);
                        int lengthSTR = 0;
                        for (int j = 0; j < str.Length; ++j)
                        {
                            if (str[j].CompareTo(id) == 0)
                            {
                                indexis.Add(lengthSTR);
                            }
                            lengthSTR += str[j].Length + 1;
                        }
                        for (int j = 0; j < indexis.Count; ++j)
                        {

                            CodeRichTextBox.Select(indexis[j], id.Length);
                            CodeRichTextBox.SelectionColor = Color.Red;
                        }

                    }
                }
            }
        }

        private void IdTextBox_TextChanged(object sender, EventArgs e)
        {
            if(LitetalListBox.SelectedItem != null)
            (LitetalListBox.SelectedItem as Literal).id = IdTextBox.Text;
        }

        private void ToolTipTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LitetalListBox.SelectedItem != null)
                (LitetalListBox.SelectedItem as Literal).toolTip = ToolTipTextBox.Text;
        }

        private void DefaultTextBox_TextChanged(object sender, EventArgs e)
        {
            if (LitetalListBox.SelectedItem != null)
                (LitetalListBox.SelectedItem as Literal).Default = DefaultTextBox.Text;
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            bool isAllOk = true;
            if(String.IsNullOrWhiteSpace(ShortcutTextBox.Text))
            {
                InvalidBox(ShortcutTextBox);
                isAllOk &= false;
            }
            if (String.IsNullOrWhiteSpace(CodeRichTextBox.Text))
            {
                InvalidBox(CodeRichTextBox);
                isAllOk &= false;
            }

            if (isAllOk && saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                formSnippet(saveFileDialog.FileName);
            }
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                ReadSnippet(openFileDialog.FileName);
            }
        }
        private void ReadSnippet(string filePath)
        {
            xmlRE = XmlReader.Create(filePath); 

        }
    }
}
