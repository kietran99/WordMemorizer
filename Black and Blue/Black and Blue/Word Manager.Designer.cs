namespace Black_and_Blue
{
    partial class Word_Manager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Word_Manager));
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rbNewWord = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNewWord = new System.Windows.Forms.TextBox();
            this.tbNewMeaning = new System.Windows.Forms.TextBox();
            this.pnlNewWord = new System.Windows.Forms.Panel();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.rbEdit = new System.Windows.Forms.RadioButton();
            this.panel9 = new System.Windows.Forms.Panel();
            this.pnlNewWord.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(640, 29);
            this.panel4.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(630, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 573);
            this.panel3.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(10, 573);
            this.panel2.TabIndex = 8;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(10, 592);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(620, 10);
            this.panel5.TabIndex = 9;
            // 
            // rbNewWord
            // 
            this.rbNewWord.AutoSize = true;
            this.rbNewWord.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNewWord.ForeColor = System.Drawing.Color.White;
            this.rbNewWord.Location = new System.Drawing.Point(3, 3);
            this.rbNewWord.Name = "rbNewWord";
            this.rbNewWord.Size = new System.Drawing.Size(167, 26);
            this.rbNewWord.TabIndex = 10;
            this.rbNewWord.Text = "Add a New Word";
            this.rbNewWord.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "New Word :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(3, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 13;
            this.label2.Text = "New Meaning :";
            // 
            // tbNewWord
            // 
            this.tbNewWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewWord.Location = new System.Drawing.Point(7, 35);
            this.tbNewWord.Name = "tbNewWord";
            this.tbNewWord.Size = new System.Drawing.Size(591, 30);
            this.tbNewWord.TabIndex = 0;
            this.tbNewWord.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNewWord.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNewWord_KeyDown);
            // 
            // tbNewMeaning
            // 
            this.tbNewMeaning.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNewMeaning.Location = new System.Drawing.Point(7, 94);
            this.tbNewMeaning.Name = "tbNewMeaning";
            this.tbNewMeaning.Size = new System.Drawing.Size(591, 30);
            this.tbNewMeaning.TabIndex = 1;
            this.tbNewMeaning.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbNewMeaning.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbNewMeaning_KeyDown);
            // 
            // pnlNewWord
            // 
            this.pnlNewWord.Controls.Add(this.label2);
            this.pnlNewWord.Controls.Add(this.label1);
            this.pnlNewWord.Controls.Add(this.tbNewWord);
            this.pnlNewWord.Controls.Add(this.tbNewMeaning);
            this.pnlNewWord.Location = new System.Drawing.Point(20, 235);
            this.pnlNewWord.Name = "pnlNewWord";
            this.pnlNewWord.Size = new System.Drawing.Size(604, 132);
            this.pnlNewWord.TabIndex = 16;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnAdd.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnAdd.FlatAppearance.BorderSize = 3;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(78, 27);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnCancel.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnCancel.FlatAppearance.BorderSize = 3;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(87, 3);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(78, 27);
            this.btnCancel.TabIndex = 18;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.rbEdit);
            this.panel7.Controls.Add(this.rbNewWord);
            this.panel7.Location = new System.Drawing.Point(27, 57);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(215, 90);
            this.panel7.TabIndex = 19;
            // 
            // rbEdit
            // 
            this.rbEdit.AutoSize = true;
            this.rbEdit.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEdit.ForeColor = System.Drawing.Color.White;
            this.rbEdit.Location = new System.Drawing.Point(3, 61);
            this.rbEdit.Name = "rbEdit";
            this.rbEdit.Size = new System.Drawing.Size(123, 26);
            this.rbEdit.TabIndex = 10;
            this.rbEdit.Text = "Edit a Word";
            this.rbEdit.UseVisualStyleBackColor = true;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnCancel);
            this.panel9.Controls.Add(this.btnAdd);
            this.panel9.Location = new System.Drawing.Point(453, 547);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(171, 39);
            this.panel9.TabIndex = 20;
            // 
            // Word_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(640, 602);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlNewWord);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel9);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Word_Manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word_Manager";
            this.pnlNewWord.ResumeLayout(false);
            this.pnlNewWord.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton rbNewWord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNewWord;
        private System.Windows.Forms.TextBox tbNewMeaning;
        private System.Windows.Forms.Panel pnlNewWord;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.RadioButton rbEdit;
    }
}