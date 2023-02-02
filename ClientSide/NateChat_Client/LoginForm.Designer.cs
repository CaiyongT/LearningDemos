namespace NateChat_Client
{
    partial class LoginForm
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
            this.btn_SignUp = new System.Windows.Forms.Button();
            this.btn_Login = new System.Windows.Forms.Button();
            this.lbl_Acc = new System.Windows.Forms.Label();
            this.lbl_Pwd = new System.Windows.Forms.Label();
            this.txb_Acc = new System.Windows.Forms.TextBox();
            this.txb_Pwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_SignUp
            // 
            this.btn_SignUp.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_SignUp.Location = new System.Drawing.Point(473, 289);
            this.btn_SignUp.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_SignUp.Name = "btn_SignUp";
            this.btn_SignUp.Size = new System.Drawing.Size(138, 40);
            this.btn_SignUp.TabIndex = 3;
            this.btn_SignUp.Text = "SignUp";
            this.btn_SignUp.UseVisualStyleBackColor = true;
            // 
            // btn_Login
            // 
            this.btn_Login.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btn_Login.Location = new System.Drawing.Point(228, 289);
            this.btn_Login.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(138, 40);
            this.btn_Login.TabIndex = 2;
            this.btn_Login.Text = "LogIn";
            this.btn_Login.UseVisualStyleBackColor = true;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // lbl_Acc
            // 
            this.lbl_Acc.AutoSize = true;
            this.lbl_Acc.Location = new System.Drawing.Point(174, 103);
            this.lbl_Acc.Name = "lbl_Acc";
            this.lbl_Acc.Size = new System.Drawing.Size(98, 22);
            this.lbl_Acc.TabIndex = 2;
            this.lbl_Acc.Text = "Account:";
            // 
            // lbl_Pwd
            // 
            this.lbl_Pwd.AutoSize = true;
            this.lbl_Pwd.Location = new System.Drawing.Point(174, 193);
            this.lbl_Pwd.Name = "lbl_Pwd";
            this.lbl_Pwd.Size = new System.Drawing.Size(109, 22);
            this.lbl_Pwd.TabIndex = 2;
            this.lbl_Pwd.Text = "Password:";
            // 
            // txb_Acc
            // 
            this.txb_Acc.Location = new System.Drawing.Point(308, 103);
            this.txb_Acc.Name = "txb_Acc";
            this.txb_Acc.Size = new System.Drawing.Size(331, 32);
            this.txb_Acc.TabIndex = 0;
            // 
            // txb_Pwd
            // 
            this.txb_Pwd.Location = new System.Drawing.Point(308, 190);
            this.txb_Pwd.Name = "txb_Pwd";
            this.txb_Pwd.PasswordChar = '*';
            this.txb_Pwd.Size = new System.Drawing.Size(331, 32);
            this.txb_Pwd.TabIndex = 1;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 432);
            this.Controls.Add(this.txb_Pwd);
            this.Controls.Add(this.txb_Acc);
            this.Controls.Add(this.lbl_Pwd);
            this.Controls.Add(this.lbl_Acc);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.btn_SignUp);
            this.Font = new System.Drawing.Font("宋体", 16F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WelComeToNateChat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_SignUp;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.Label lbl_Acc;
        private System.Windows.Forms.Label lbl_Pwd;
        private System.Windows.Forms.TextBox txb_Acc;
        private System.Windows.Forms.TextBox txb_Pwd;
    }
}