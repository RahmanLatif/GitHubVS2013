﻿namespace ADB_Project
{
    partial class Addnew
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
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.btnRstLogin = new System.Windows.Forms.Button();
            this.btnSbmtLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtbxConfirm = new System.Windows.Forms.TextBox();
            this.txtbxUsernameLogin = new System.Windows.Forms.TextBox();
            this.txtbxPassLogin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmboUserType = new System.Windows.Forms.ComboBox();
            this.pnlLogin.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLogin
            // 
            this.pnlLogin.BackColor = System.Drawing.Color.Silver;
            this.pnlLogin.Controls.Add(this.btnRstLogin);
            this.pnlLogin.Controls.Add(this.btnSbmtLogin);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.panel5);
            this.pnlLogin.Location = new System.Drawing.Point(11, 11);
            this.pnlLogin.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(224, 405);
            this.pnlLogin.TabIndex = 15;
            // 
            // btnRstLogin
            // 
            this.btnRstLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnRstLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRstLogin.ForeColor = System.Drawing.Color.White;
            this.btnRstLogin.Location = new System.Drawing.Point(26, 341);
            this.btnRstLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnRstLogin.Name = "btnRstLogin";
            this.btnRstLogin.Size = new System.Drawing.Size(79, 53);
            this.btnRstLogin.TabIndex = 20;
            this.btnRstLogin.Text = "Reset";
            this.btnRstLogin.UseVisualStyleBackColor = false;
            this.btnRstLogin.Click += new System.EventHandler(this.btnRstLogin_Click);
            // 
            // btnSbmtLogin
            // 
            this.btnSbmtLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnSbmtLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSbmtLogin.ForeColor = System.Drawing.Color.White;
            this.btnSbmtLogin.Location = new System.Drawing.Point(113, 341);
            this.btnSbmtLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnSbmtLogin.Name = "btnSbmtLogin";
            this.btnSbmtLogin.Size = new System.Drawing.Size(79, 53);
            this.btnSbmtLogin.TabIndex = 19;
            this.btnSbmtLogin.Text = "Submit";
            this.btnSbmtLogin.UseVisualStyleBackColor = false;
            this.btnSbmtLogin.Click += new System.EventHandler(this.btnSbmtLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Add New User";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Controls.Add(this.cmboUserType);
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.label7);
            this.panel5.Controls.Add(this.label3);
            this.panel5.Controls.Add(this.label8);
            this.panel5.Controls.Add(this.txtbxConfirm);
            this.panel5.Controls.Add(this.txtbxUsernameLogin);
            this.panel5.Controls.Add(this.txtbxPassLogin);
            this.panel5.Location = new System.Drawing.Point(19, 48);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(187, 289);
            this.panel5.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(2, 223);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Confirm Password";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 154);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Password";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 83);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Username";
            // 
            // txtbxConfirm
            // 
            this.txtbxConfirm.BackColor = System.Drawing.Color.White;
            this.txtbxConfirm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxConfirm.Location = new System.Drawing.Point(5, 256);
            this.txtbxConfirm.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxConfirm.Name = "txtbxConfirm";
            this.txtbxConfirm.PasswordChar = '*';
            this.txtbxConfirm.Size = new System.Drawing.Size(166, 21);
            this.txtbxConfirm.TabIndex = 5;
            // 
            // txtbxUsernameLogin
            // 
            this.txtbxUsernameLogin.BackColor = System.Drawing.Color.White;
            this.txtbxUsernameLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxUsernameLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxUsernameLogin.Location = new System.Drawing.Point(7, 118);
            this.txtbxUsernameLogin.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxUsernameLogin.Name = "txtbxUsernameLogin";
            this.txtbxUsernameLogin.Size = new System.Drawing.Size(166, 21);
            this.txtbxUsernameLogin.TabIndex = 2;
            // 
            // txtbxPassLogin
            // 
            this.txtbxPassLogin.BackColor = System.Drawing.Color.White;
            this.txtbxPassLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtbxPassLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbxPassLogin.Location = new System.Drawing.Point(7, 187);
            this.txtbxPassLogin.Margin = new System.Windows.Forms.Padding(2);
            this.txtbxPassLogin.Name = "txtbxPassLogin";
            this.txtbxPassLogin.PasswordChar = '*';
            this.txtbxPassLogin.Size = new System.Drawing.Size(166, 21);
            this.txtbxPassLogin.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 15);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "User Type";
            // 
            // cmboUserType
            // 
            this.cmboUserType.FormattingEnabled = true;
            this.cmboUserType.Items.AddRange(new object[] {
            "Xray technician",
            "Analysis technician"});
            this.cmboUserType.Location = new System.Drawing.Point(8, 48);
            this.cmboUserType.Name = "cmboUserType";
            this.cmboUserType.Size = new System.Drawing.Size(166, 21);
            this.cmboUserType.TabIndex = 15;
            // 
            // Addnew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 427);
            this.Controls.Add(this.pnlLogin);
            this.Name = "Addnew";
            this.Text = "Addnew";
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.Button btnRstLogin;
        private System.Windows.Forms.Button btnSbmtLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtbxUsernameLogin;
        private System.Windows.Forms.TextBox txtbxPassLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbxConfirm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmboUserType;
    }
}