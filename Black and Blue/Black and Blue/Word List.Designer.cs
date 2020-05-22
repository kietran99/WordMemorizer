namespace Black_and_Blue
{
    partial class Word_List
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Word_List));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchSublist = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbWord = new System.Windows.Forms.TextBox();
            this.clbWordlist = new System.Windows.Forms.CheckedListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnReverse = new System.Windows.Forms.Button();
            this.btnQuit = new System.Windows.Forms.Button();
            this.btnDelAll = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAddSublist = new System.Windows.Forms.Button();
            this.flpMeaning = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddWord = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbSearchSublist = new System.Windows.Forms.TextBox();
            this.lbWordInserted = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(620, 29);
            this.panel4.TabIndex = 5;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 592);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(620, 10);
            this.panel5.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(630, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 602);
            this.panel3.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 602);
            this.panel2.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Sublist :";
            // 
            // btnSearchSublist
            // 
            this.btnSearchSublist.Image = ((System.Drawing.Image)(resources.GetObject("btnSearchSublist.Image")));
            this.btnSearchSublist.Location = new System.Drawing.Point(570, 3);
            this.btnSearchSublist.Name = "btnSearchSublist";
            this.btnSearchSublist.Size = new System.Drawing.Size(30, 30);
            this.btnSearchSublist.TabIndex = 10;
            this.btnSearchSublist.UseVisualStyleBackColor = true;
            this.btnSearchSublist.Click += new System.EventHandler(this.btnSearchSublist_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(32, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "Search Word :";
            // 
            // tbWord
            // 
            this.tbWord.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbWord.Location = new System.Drawing.Point(24, 127);
            this.tbWord.Name = "tbWord";
            this.tbWord.Size = new System.Drawing.Size(600, 30);
            this.tbWord.TabIndex = 11;
            this.tbWord.TextChanged += new System.EventHandler(this.tbWord_TextChanged);
            // 
            // clbWordlist
            // 
            this.clbWordlist.BackColor = System.Drawing.Color.Cyan;
            this.clbWordlist.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbWordlist.FormattingEnabled = true;
            this.clbWordlist.Location = new System.Drawing.Point(3, 20);
            this.clbWordlist.Name = "clbWordlist";
            this.clbWordlist.Size = new System.Drawing.Size(254, 354);
            this.clbWordlist.TabIndex = 12;
            this.clbWordlist.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.clbWordlist_ItemCheck);
            this.clbWordlist.SelectedIndexChanged += new System.EventHandler(this.clbWordlist_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnReverse);
            this.panel1.Controls.Add(this.btnQuit);
            this.panel1.Controls.Add(this.btnDelAll);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.btnAddSublist);
            this.panel1.Controls.Add(this.flpMeaning);
            this.panel1.Controls.Add(this.btnAddWord);
            this.panel1.Controls.Add(this.clbWordlist);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Location = new System.Drawing.Point(21, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 388);
            this.panel1.TabIndex = 13;
            // 
            // btnReverse
            // 
            this.btnReverse.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnReverse.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnReverse.FlatAppearance.BorderSize = 3;
            this.btnReverse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReverse.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReverse.ForeColor = System.Drawing.Color.White;
            this.btnReverse.Location = new System.Drawing.Point(522, 145);
            this.btnReverse.Name = "btnReverse";
            this.btnReverse.Size = new System.Drawing.Size(78, 31);
            this.btnReverse.TabIndex = 20;
            this.btnReverse.Text = "Reverse";
            this.btnReverse.UseVisualStyleBackColor = false;
            this.btnReverse.Click += new System.EventHandler(this.btnReverse_Click);
            // 
            // btnQuit
            // 
            this.btnQuit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnQuit.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnQuit.FlatAppearance.BorderSize = 3;
            this.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnQuit.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQuit.ForeColor = System.Drawing.Color.White;
            this.btnQuit.Location = new System.Drawing.Point(522, 277);
            this.btnQuit.Name = "btnQuit";
            this.btnQuit.Size = new System.Drawing.Size(78, 31);
            this.btnQuit.TabIndex = 16;
            this.btnQuit.Text = "Quit";
            this.btnQuit.UseVisualStyleBackColor = false;
            this.btnQuit.Click += new System.EventHandler(this.btnQuit_Click);
            // 
            // btnDelAll
            // 
            this.btnDelAll.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDelAll.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnDelAll.FlatAppearance.BorderSize = 3;
            this.btnDelAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelAll.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelAll.ForeColor = System.Drawing.Color.White;
            this.btnDelAll.Location = new System.Drawing.Point(522, 219);
            this.btnDelAll.Name = "btnDelAll";
            this.btnDelAll.Size = new System.Drawing.Size(78, 52);
            this.btnDelAll.TabIndex = 18;
            this.btnDelAll.Text = "Delete All";
            this.btnDelAll.UseVisualStyleBackColor = false;
            this.btnDelAll.Click += new System.EventHandler(this.btnDelAll_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnDelete.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnDelete.FlatAppearance.BorderSize = 3;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDelete.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(522, 182);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(78, 31);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEdit.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnEdit.FlatAppearance.BorderSize = 3;
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEdit.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.White;
            this.btnEdit.Location = new System.Drawing.Point(522, 108);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(78, 31);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAddSublist
            // 
            this.btnAddSublist.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddSublist.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnAddSublist.FlatAppearance.BorderSize = 3;
            this.btnAddSublist.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddSublist.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddSublist.ForeColor = System.Drawing.Color.White;
            this.btnAddSublist.Location = new System.Drawing.Point(522, 59);
            this.btnAddSublist.Name = "btnAddSublist";
            this.btnAddSublist.Size = new System.Drawing.Size(78, 43);
            this.btnAddSublist.TabIndex = 15;
            this.btnAddSublist.Text = "Add Sublist";
            this.btnAddSublist.UseVisualStyleBackColor = false;
            this.btnAddSublist.Click += new System.EventHandler(this.btnAddSublist_Click);
            // 
            // flpMeaning
            // 
            this.flpMeaning.AutoScroll = true;
            this.flpMeaning.BackColor = System.Drawing.Color.Cyan;
            this.flpMeaning.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpMeaning.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flpMeaning.Location = new System.Drawing.Point(263, 20);
            this.flpMeaning.Name = "flpMeaning";
            this.flpMeaning.Size = new System.Drawing.Size(253, 354);
            this.flpMeaning.TabIndex = 13;
            this.flpMeaning.WrapContents = false;
            // 
            // btnAddWord
            // 
            this.btnAddWord.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAddWord.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnAddWord.FlatAppearance.BorderSize = 3;
            this.btnAddWord.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAddWord.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddWord.ForeColor = System.Drawing.Color.White;
            this.btnAddWord.Location = new System.Drawing.Point(522, 20);
            this.btnAddWord.Name = "btnAddWord";
            this.btnAddWord.Size = new System.Drawing.Size(78, 33);
            this.btnAddWord.TabIndex = 15;
            this.btnAddWord.Text = "Add Word";
            this.btnAddWord.UseVisualStyleBackColor = false;
            this.btnAddWord.Click += new System.EventHandler(this.btnAddWord_Click);
            // 
            // panel7
            // 
            this.panel7.Location = new System.Drawing.Point(522, 20);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(78, 288);
            this.panel7.TabIndex = 19;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbSearchSublist);
            this.panel6.Controls.Add(this.btnSearchSublist);
            this.panel6.Location = new System.Drawing.Point(21, 62);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(603, 36);
            this.panel6.TabIndex = 14;
            // 
            // tbSearchSublist
            // 
            this.tbSearchSublist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbSearchSublist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbSearchSublist.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSearchSublist.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbSearchSublist.Location = new System.Drawing.Point(4, 3);
            this.tbSearchSublist.Name = "tbSearchSublist";
            this.tbSearchSublist.Size = new System.Drawing.Size(560, 30);
            this.tbSearchSublist.TabIndex = 0;
            // 
            // lbWordInserted
            // 
            this.lbWordInserted.AutoSize = true;
            this.lbWordInserted.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbWordInserted.ForeColor = System.Drawing.Color.Gold;
            this.lbWordInserted.Location = new System.Drawing.Point(20, 559);
            this.lbWordInserted.Name = "lbWordInserted";
            this.lbWordInserted.Size = new System.Drawing.Size(60, 23);
            this.lbWordInserted.TabIndex = 15;
            this.lbWordInserted.Text = "label3";
            // 
            // Word_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(640, 602);
            this.Controls.Add(this.lbWordInserted);
            this.Controls.Add(this.tbWord);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Word_List";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word_List";
            this.panel1.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchSublist;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbWord;
        private System.Windows.Forms.CheckedListBox clbWordlist;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpMeaning;
        private System.Windows.Forms.Button btnDelAll;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAddWord;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnQuit;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnAddSublist;
        private System.Windows.Forms.Button btnReverse;
        private System.Windows.Forms.Label lbWordInserted;
        private System.Windows.Forms.TextBox tbSearchSublist;
    }
}