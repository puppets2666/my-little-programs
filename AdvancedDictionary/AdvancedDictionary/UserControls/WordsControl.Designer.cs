﻿namespace AdvancedDictionary.UserControls
{
    partial class WordsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.VerbMainDgv = new System.Windows.Forms.DataGridView();
            this.Text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Emotions = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Synonyms = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.VerbAmountLbl = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonsTbl = new System.Windows.Forms.TableLayoutPanel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.sortBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.showBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.removeBtn = new System.Windows.Forms.Button();
            this.ScaleTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.gridTbl = new System.Windows.Forms.TableLayoutPanel();
            this.pourerTbl = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.synonymsPourer = new AdvancedDictionary.UserControls.Pourer();
            this.emotionsPourer = new AdvancedDictionary.UserControls.Pourer();
            ((System.ComponentModel.ISupportInitialize)(this.VerbMainDgv)).BeginInit();
            this.statusStrip.SuspendLayout();
            this.buttonsTbl.SuspendLayout();
            this.ScaleTableLayoutPanel.SuspendLayout();
            this.gridTbl.SuspendLayout();
            this.pourerTbl.SuspendLayout();
            this.SuspendLayout();
            // 
            // VerbMainDgv
            // 
            this.VerbMainDgv.AllowUserToAddRows = false;
            this.VerbMainDgv.AllowUserToDeleteRows = false;
            this.VerbMainDgv.AllowUserToResizeColumns = false;
            this.VerbMainDgv.AllowUserToResizeRows = false;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.VerbMainDgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.VerbMainDgv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.VerbMainDgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.VerbMainDgv.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.VerbMainDgv.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VerbMainDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VerbMainDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Text,
            this.Description,
            this.Emotions,
            this.Synonyms});
            this.VerbMainDgv.Location = new System.Drawing.Point(0, 0);
            this.VerbMainDgv.Margin = new System.Windows.Forms.Padding(0);
            this.VerbMainDgv.Name = "VerbMainDgv";
            this.VerbMainDgv.ReadOnly = true;
            this.VerbMainDgv.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.VerbMainDgv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.VerbMainDgv.Size = new System.Drawing.Size(347, 236);
            this.VerbMainDgv.TabIndex = 0;
            this.VerbMainDgv.VirtualMode = true;
            this.VerbMainDgv.CellValueNeeded += new System.Windows.Forms.DataGridViewCellValueEventHandler(this.VerbMainDgv_CellValueNeeded);
            // 
            // Text
            // 
            this.Text.HeaderText = "Text";
            this.Text.Name = "Text";
            this.Text.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Emotions
            // 
            this.Emotions.HeaderText = "Emotions";
            this.Emotions.Name = "Emotions";
            this.Emotions.ReadOnly = true;
            // 
            // Synonyms
            // 
            this.Synonyms.HeaderText = "Synonyms";
            this.Synonyms.Name = "Synonyms";
            this.Synonyms.ReadOnly = true;
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.VerbAmountLbl});
            this.statusStrip.Location = new System.Drawing.Point(0, 311);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(597, 22);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(111, 17);
            this.toolStripStatusLabel1.Text = "Amount of words - ";
            // 
            // VerbAmountLbl
            // 
            this.VerbAmountLbl.Name = "VerbAmountLbl";
            this.VerbAmountLbl.Size = new System.Drawing.Size(13, 17);
            this.VerbAmountLbl.Text = "0";
            // 
            // buttonsTbl
            // 
            this.buttonsTbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonsTbl.ColumnCount = 3;
            this.buttonsTbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.buttonsTbl.Controls.Add(this.clearBtn, 0, 0);
            this.buttonsTbl.Controls.Add(this.sortBtn, 2, 1);
            this.buttonsTbl.Controls.Add(this.EditBtn, 0, 1);
            this.buttonsTbl.Controls.Add(this.showBtn, 2, 0);
            this.buttonsTbl.Controls.Add(this.addBtn, 0, 0);
            this.buttonsTbl.Controls.Add(this.removeBtn, 1, 1);
            this.buttonsTbl.Location = new System.Drawing.Point(0, 0);
            this.buttonsTbl.Margin = new System.Windows.Forms.Padding(0);
            this.buttonsTbl.Name = "buttonsTbl";
            this.buttonsTbl.RowCount = 2;
            this.buttonsTbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.buttonsTbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.buttonsTbl.Size = new System.Drawing.Size(597, 75);
            this.buttonsTbl.TabIndex = 2;
            // 
            // clearBtn
            // 
            this.clearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.clearBtn.Location = new System.Drawing.Point(199, 0);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(0);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(199, 37);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "Clear";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // sortBtn
            // 
            this.sortBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sortBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sortBtn.FlatAppearance.BorderSize = 0;
            this.sortBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.sortBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.sortBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sortBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.sortBtn.Location = new System.Drawing.Point(398, 37);
            this.sortBtn.Margin = new System.Windows.Forms.Padding(0);
            this.sortBtn.Name = "sortBtn";
            this.sortBtn.Size = new System.Drawing.Size(199, 38);
            this.sortBtn.TabIndex = 4;
            this.sortBtn.Text = "Sort";
            this.sortBtn.UseVisualStyleBackColor = true;
            this.sortBtn.Click += new System.EventHandler(this.sortBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EditBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditBtn.FlatAppearance.BorderSize = 0;
            this.EditBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.EditBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.EditBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EditBtn.Location = new System.Drawing.Point(0, 37);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(0);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(199, 38);
            this.EditBtn.TabIndex = 3;
            this.EditBtn.Text = "Edit";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // showBtn
            // 
            this.showBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.showBtn.FlatAppearance.BorderSize = 0;
            this.showBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.showBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.showBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showBtn.Location = new System.Drawing.Point(398, 0);
            this.showBtn.Margin = new System.Windows.Forms.Padding(0);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(199, 37);
            this.showBtn.TabIndex = 2;
            this.showBtn.Text = "Show All";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBtn.FlatAppearance.BorderSize = 0;
            this.addBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.addBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addBtn.Location = new System.Drawing.Point(0, 0);
            this.addBtn.Margin = new System.Windows.Forms.Padding(0);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(199, 37);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // removeBtn
            // 
            this.removeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.removeBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeBtn.FlatAppearance.BorderSize = 0;
            this.removeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.removeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.removeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.removeBtn.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.removeBtn.Location = new System.Drawing.Point(199, 37);
            this.removeBtn.Margin = new System.Windows.Forms.Padding(0);
            this.removeBtn.Name = "removeBtn";
            this.removeBtn.Size = new System.Drawing.Size(199, 38);
            this.removeBtn.TabIndex = 1;
            this.removeBtn.Text = "Remove";
            this.removeBtn.UseVisualStyleBackColor = true;
            this.removeBtn.Click += new System.EventHandler(this.removeBtn_Click);
            // 
            // ScaleTableLayoutPanel
            // 
            this.ScaleTableLayoutPanel.ColumnCount = 1;
            this.ScaleTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ScaleTableLayoutPanel.Controls.Add(this.buttonsTbl, 0, 0);
            this.ScaleTableLayoutPanel.Controls.Add(this.gridTbl, 0, 1);
            this.ScaleTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScaleTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.ScaleTableLayoutPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ScaleTableLayoutPanel.Name = "ScaleTableLayoutPanel";
            this.ScaleTableLayoutPanel.RowCount = 2;
            this.ScaleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75F));
            this.ScaleTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.ScaleTableLayoutPanel.Size = new System.Drawing.Size(597, 311);
            this.ScaleTableLayoutPanel.TabIndex = 3;
            // 
            // gridTbl
            // 
            this.gridTbl.ColumnCount = 2;
            this.gridTbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gridTbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.gridTbl.Controls.Add(this.VerbMainDgv, 0, 0);
            this.gridTbl.Controls.Add(this.pourerTbl, 1, 0);
            this.gridTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridTbl.Location = new System.Drawing.Point(0, 75);
            this.gridTbl.Margin = new System.Windows.Forms.Padding(0);
            this.gridTbl.Name = "gridTbl";
            this.gridTbl.RowCount = 1;
            this.gridTbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.gridTbl.Size = new System.Drawing.Size(597, 236);
            this.gridTbl.TabIndex = 4;
            // 
            // pourerTbl
            // 
            this.pourerTbl.ColumnCount = 1;
            this.pourerTbl.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pourerTbl.Controls.Add(this.label1, 0, 0);
            this.pourerTbl.Controls.Add(this.synonymsPourer, 0, 1);
            this.pourerTbl.Controls.Add(this.emotionsPourer, 0, 2);
            this.pourerTbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pourerTbl.Location = new System.Drawing.Point(347, 0);
            this.pourerTbl.Margin = new System.Windows.Forms.Padding(0);
            this.pourerTbl.Name = "pourerTbl";
            this.pourerTbl.RowCount = 3;
            this.pourerTbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.pourerTbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pourerTbl.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.pourerTbl.Size = new System.Drawing.Size(250, 236);
            this.pourerTbl.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Filter";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // synonymsPourer
            // 
            this.synonymsPourer.BackColor = System.Drawing.Color.Transparent;
            this.synonymsPourer.BtnHoverPixel = 1;
            this.synonymsPourer.BtnPushedPixel = 3;
            this.synonymsPourer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.synonymsPourer.Location = new System.Drawing.Point(0, 35);
            this.synonymsPourer.Margin = new System.Windows.Forms.Padding(0);
            this.synonymsPourer.MiddleAreaWidth = 90;
            this.synonymsPourer.Name = "synonymsPourer";
            this.synonymsPourer.Size = new System.Drawing.Size(250, 100);
            this.synonymsPourer.TabIndex = 1;
            this.synonymsPourer.PouringToLeft += new System.EventHandler<AdvancedDictionary.AdditionalClasses.EventArgsClasses.PouringEventArgs>(this.synonymsPourer_PouringToLeft);
            this.synonymsPourer.PouringToRight += new System.EventHandler<AdvancedDictionary.AdditionalClasses.EventArgsClasses.PouringEventArgs>(this.synonymsPourer_PouringToRight);
            // 
            // emotionsPourer
            // 
            this.emotionsPourer.BackColor = System.Drawing.Color.Transparent;
            this.emotionsPourer.BtnHoverPixel = 1;
            this.emotionsPourer.BtnPushedPixel = 3;
            this.emotionsPourer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emotionsPourer.Location = new System.Drawing.Point(0, 135);
            this.emotionsPourer.Margin = new System.Windows.Forms.Padding(0);
            this.emotionsPourer.MiddleAreaWidth = 90;
            this.emotionsPourer.Name = "emotionsPourer";
            this.emotionsPourer.Size = new System.Drawing.Size(250, 101);
            this.emotionsPourer.TabIndex = 2;
            this.emotionsPourer.PouringToLeft += new System.EventHandler<AdvancedDictionary.AdditionalClasses.EventArgsClasses.PouringEventArgs>(this.emotionsPourer_PouringToLeft);
            this.emotionsPourer.PouringToRight += new System.EventHandler<AdvancedDictionary.AdditionalClasses.EventArgsClasses.PouringEventArgs>(this.emotionsPourer_PouringToRight);
            // 
            // WordsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ScaleTableLayoutPanel);
            this.Controls.Add(this.statusStrip);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "WordsControl";
            this.Size = new System.Drawing.Size(597, 333);
            ((System.ComponentModel.ISupportInitialize)(this.VerbMainDgv)).EndInit();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.buttonsTbl.ResumeLayout(false);
            this.ScaleTableLayoutPanel.ResumeLayout(false);
            this.gridTbl.ResumeLayout(false);
            this.pourerTbl.ResumeLayout(false);
            this.pourerTbl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView VerbMainDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Text;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn Emotions;
        private System.Windows.Forms.DataGridViewTextBoxColumn Synonyms;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel VerbAmountLbl;
        private System.Windows.Forms.TableLayoutPanel buttonsTbl;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button removeBtn;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.TableLayoutPanel ScaleTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel gridTbl;
        private System.Windows.Forms.TableLayoutPanel pourerTbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button sortBtn;
        private Pourer synonymsPourer;
        private Pourer emotionsPourer;
    }
}
