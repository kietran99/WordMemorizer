namespace Black_and_Blue
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbControl1 = new pbControl.pbControl();
            this.pbMinimize = new pbControl.pbControl();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnList = new System.Windows.Forms.Button();
            this.btnNormal = new System.Windows.Forms.Button();
            this.btnTime = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lbCopyright = new System.Windows.Forms.Label();
            this.tbCurrentSublist = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel1.Controls.Add(this.pbControl1);
            this.panel1.Controls.Add(this.pbMinimize);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(531, 29);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // pbControl1
            // 
            this.pbControl1.HoverImage = ((System.Drawing.Image)(resources.GetObject("pbControl1.HoverImage")));
            this.pbControl1.Image = ((System.Drawing.Image)(resources.GetObject("pbControl1.Image")));
            this.pbControl1.Location = new System.Drawing.Point(502, 0);
            this.pbControl1.Name = "pbControl1";
            this.pbControl1.NormalImage = ((System.Drawing.Image)(resources.GetObject("pbControl1.NormalImage")));
            this.pbControl1.Size = new System.Drawing.Size(29, 29);
            this.pbControl1.TabIndex = 4;
            this.pbControl1.TabStop = false;
            this.pbControl1.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // pbMinimize
            // 
            this.pbMinimize.HoverImage = ((System.Drawing.Image)(resources.GetObject("pbMinimize.HoverImage")));
            this.pbMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pbMinimize.Image")));
            this.pbMinimize.Location = new System.Drawing.Point(467, 0);
            this.pbMinimize.Name = "pbMinimize";
            this.pbMinimize.NormalImage = ((System.Drawing.Image)(resources.GetObject("pbMinimize.NormalImage")));
            this.pbMinimize.Size = new System.Drawing.Size(29, 29);
            this.pbMinimize.TabIndex = 4;
            this.pbMinimize.TabStop = false;
            this.pbMinimize.Click += new System.EventHandler(this.pbMinimize_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("VNI-Ariston", 12F);
            this.label1.Location = new System.Drawing.Point(166, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(237, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Word Memorizer V1.0.1 (Beta)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 427);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(531, 10);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(521, 29);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(10, 398);
            this.panel3.TabIndex = 2;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            this.panel3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseMove);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.HotTrack;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 29);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(10, 398);
            this.panel4.TabIndex = 3;
            this.panel4.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseDown);
            this.panel4.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel4_MouseMove);
            // 
            // btnList
            // 
            this.btnList.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnList.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnList.FlatAppearance.BorderSize = 3;
            this.btnList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnList.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnList.ForeColor = System.Drawing.Color.White;
            this.btnList.Location = new System.Drawing.Point(63, 141);
            this.btnList.Name = "btnList";
            this.btnList.Size = new System.Drawing.Size(140, 98);
            this.btnList.TabIndex = 4;
            this.btnList.Text = "LIST";
            this.btnList.UseVisualStyleBackColor = false;
            this.btnList.Click += new System.EventHandler(this.btnList_Click);
            // 
            // btnNormal
            // 
            this.btnNormal.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNormal.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnNormal.FlatAppearance.BorderSize = 3;
            this.btnNormal.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnNormal.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormal.ForeColor = System.Drawing.Color.White;
            this.btnNormal.Location = new System.Drawing.Point(328, 141);
            this.btnNormal.Name = "btnNormal";
            this.btnNormal.Size = new System.Drawing.Size(140, 98);
            this.btnNormal.TabIndex = 4;
            this.btnNormal.Text = "NORMAL MODE";
            this.btnNormal.UseVisualStyleBackColor = false;
            this.btnNormal.Click += new System.EventHandler(this.btnNormal_Click);
            // 
            // btnTime
            // 
            this.btnTime.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnTime.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.btnTime.FlatAppearance.BorderSize = 3;
            this.btnTime.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTime.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTime.ForeColor = System.Drawing.Color.White;
            this.btnTime.Location = new System.Drawing.Point(63, 289);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(140, 98);
            this.btnTime.TabIndex = 4;
            this.btnTime.Text = "TIME ATTACK";
            this.btnTime.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.Yellow;
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(328, 289);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(140, 98);
            this.button4.TabIndex = 4;
            this.button4.Text = "COMING SOON";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Gold;
            this.label2.Location = new System.Drawing.Point(57, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 31);
            this.label2.TabIndex = 5;
            this.label2.Text = "CURRENT LIST :";
            // 
            // lbCopyright
            // 
            this.lbCopyright.AutoSize = true;
            this.lbCopyright.ForeColor = System.Drawing.Color.MistyRose;
            this.lbCopyright.Location = new System.Drawing.Point(397, 411);
            this.lbCopyright.Name = "lbCopyright";
            this.lbCopyright.Size = new System.Drawing.Size(122, 13);
            this.lbCopyright.TabIndex = 6;
            this.lbCopyright.Text = "Copyrights by RRaptor©";
            // 
            // tbCurrentSublist
            // 
            this.tbCurrentSublist.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.tbCurrentSublist.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.tbCurrentSublist.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbCurrentSublist.Location = new System.Drawing.Point(30, 80);
            this.tbCurrentSublist.Name = "tbCurrentSublist";
            this.tbCurrentSublist.Size = new System.Drawing.Size(466, 38);
            this.tbCurrentSublist.TabIndex = 7;
            this.tbCurrentSublist.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(531, 437);
            this.Controls.Add(this.tbCurrentSublist);
            this.Controls.Add(this.lbCopyright);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.btnNormal);
            this.Controls.Add(this.btnList);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Word Memorizer";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbMinimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private pbControl.pbControl pbMinimize;
        private pbControl.pbControl pbControl1;
        private System.Windows.Forms.Button btnList;
        private System.Windows.Forms.Button btnNormal;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbCopyright;
        private System.Windows.Forms.TextBox tbCurrentSublist;
    }
}

