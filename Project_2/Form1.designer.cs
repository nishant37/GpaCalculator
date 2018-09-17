namespace Project_2
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
            this.lblGpa = new System.Windows.Forms.Label();
            this.lbGrade = new System.Windows.Forms.Label();
            this.lblCredit = new System.Windows.Forms.Label();
            this.txtCredit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEnter = new System.Windows.Forms.Button();
            this.txtReset = new System.Windows.Forms.Button();
            this.txtExit = new System.Windows.Forms.Button();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.LabelGpa = new System.Windows.Forms.Label();
            this.Remove_Last = new System.Windows.Forms.Button();
            this.Btn_Show = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblGpa
            // 
            this.lblGpa.AutoSize = true;
            this.lblGpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGpa.Location = new System.Drawing.Point(254, 60);
            this.lblGpa.Name = "lblGpa";
            this.lblGpa.Size = new System.Drawing.Size(311, 46);
            this.lblGpa.TabIndex = 0;
            this.lblGpa.Text = "GPA Calculator";
            // 
            // lbGrade
            // 
            this.lbGrade.AutoSize = true;
            this.lbGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbGrade.Location = new System.Drawing.Point(123, 146);
            this.lbGrade.Name = "lbGrade";
            this.lbGrade.Size = new System.Drawing.Size(248, 32);
            this.lbGrade.TabIndex = 1;
            this.lbGrade.Text = "Grade of course 1:";
            // 
            // lblCredit
            // 
            this.lblCredit.AutoSize = true;
            this.lblCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredit.Location = new System.Drawing.Point(48, 202);
            this.lblCredit.Name = "lblCredit";
            this.lblCredit.Size = new System.Drawing.Size(323, 32);
            this.lblCredit.TabIndex = 3;
            this.lblCredit.Text = "Credit hours of course 1:";
            // 
            // txtCredit
            // 
            this.txtCredit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCredit.Location = new System.Drawing.Point(418, 202);
            this.txtCredit.Name = "txtCredit";
            this.txtCredit.Size = new System.Drawing.Size(68, 35);
            this.txtCredit.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(266, 258);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 32);
            this.label2.TabIndex = 5;
            this.label2.Text = "GPA = ";
            // 
            // txtEnter
            // 
            this.txtEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEnter.Location = new System.Drawing.Point(620, 146);
            this.txtEnter.Name = "txtEnter";
            this.txtEnter.Size = new System.Drawing.Size(100, 41);
            this.txtEnter.TabIndex = 7;
            this.txtEnter.Text = "Enter";
            this.txtEnter.UseVisualStyleBackColor = true;
            this.txtEnter.Click += new System.EventHandler(this.txtEnter_Click);
            // 
            // txtReset
            // 
            this.txtReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReset.Location = new System.Drawing.Point(620, 222);
            this.txtReset.Name = "txtReset";
            this.txtReset.Size = new System.Drawing.Size(100, 45);
            this.txtReset.TabIndex = 8;
            this.txtReset.Text = "Reset";
            this.txtReset.UseVisualStyleBackColor = true;
            this.txtReset.Click += new System.EventHandler(this.txtReset_Click);
            // 
            // txtExit
            // 
            this.txtExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExit.Location = new System.Drawing.Point(620, 441);
            this.txtExit.Name = "txtExit";
            this.txtExit.Size = new System.Drawing.Size(100, 42);
            this.txtExit.TabIndex = 9;
            this.txtExit.Text = "Exit";
            this.txtExit.UseVisualStyleBackColor = true;
            this.txtExit.Click += new System.EventHandler(this.txtExit_Click);
            // 
            // txtGrade
            // 
            this.txtGrade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrade.Location = new System.Drawing.Point(418, 146);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(68, 35);
            this.txtGrade.TabIndex = 2;
            this.txtGrade.TextChanged += new System.EventHandler(this.txtGrade_TextChanged_1);
            // 
            // LabelGpa
            // 
            this.LabelGpa.AutoSize = true;
            this.LabelGpa.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.LabelGpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelGpa.Location = new System.Drawing.Point(414, 268);
            this.LabelGpa.Name = "LabelGpa";
            this.LabelGpa.Size = new System.Drawing.Size(87, 32);
            this.LabelGpa.TabIndex = 10;
            this.LabelGpa.Text = "0.000";
            // 
            // Remove_Last
            // 
            this.Remove_Last.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove_Last.Location = new System.Drawing.Point(551, 363);
            this.Remove_Last.Name = "Remove_Last";
            this.Remove_Last.Size = new System.Drawing.Size(169, 41);
            this.Remove_Last.TabIndex = 11;
            this.Remove_Last.Text = "Remove Last";
            this.Remove_Last.UseVisualStyleBackColor = true;
            this.Remove_Last.Click += new System.EventHandler(this.Remove_Last_Click);
            // 
            // Btn_Show
            // 
            this.Btn_Show.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Show.Location = new System.Drawing.Point(585, 304);
            this.Btn_Show.Name = "Btn_Show";
            this.Btn_Show.Size = new System.Drawing.Size(134, 38);
            this.Btn_Show.TabIndex = 12;
            this.Btn_Show.Text = "Show All";
            this.Btn_Show.UseVisualStyleBackColor = true;
            this.Btn_Show.Click += new System.EventHandler(this.Btn_Show_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 534);
            this.Controls.Add(this.Btn_Show);
            this.Controls.Add(this.Remove_Last);
            this.Controls.Add(this.LabelGpa);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.txtExit);
            this.Controls.Add(this.txtReset);
            this.Controls.Add(this.txtEnter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCredit);
            this.Controls.Add(this.lblCredit);
            this.Controls.Add(this.lbGrade);
            this.Controls.Add(this.lblGpa);
            this.Name = "Form1";
            this.Text = "DataEntry";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGpa;
        public System.Windows.Forms.Label lbGrade;
        public System.Windows.Forms.Label lblCredit;
        public System.Windows.Forms.TextBox txtCredit;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Button txtEnter;
        public System.Windows.Forms.Button txtReset;
        public System.Windows.Forms.Button txtExit;
        public System.Windows.Forms.TextBox txtGrade;
        public System.Windows.Forms.Label LabelGpa;
        public System.Windows.Forms.Button Remove_Last;
        public System.Windows.Forms.Button Btn_Show;
    }
}

