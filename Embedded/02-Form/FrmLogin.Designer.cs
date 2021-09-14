namespace Embedded
{
    partial class FrmLogin
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
            this.LabelNum = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.LablePwd = new System.Windows.Forms.Label();
            this.TextNum = new System.Windows.Forms.TextBox();
            this.TextName = new System.Windows.Forms.TextBox();
            this.TextPwd = new System.Windows.Forms.TextBox();
            this.BtnLogin = new System.Windows.Forms.Button();
            this.BtnRegister = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LabelNum
            // 
            this.LabelNum.AutoSize = true;
            this.LabelNum.Location = new System.Drawing.Point(35, 58);
            this.LabelNum.Name = "LabelNum";
            this.LabelNum.Size = new System.Drawing.Size(41, 12);
            this.LabelNum.TabIndex = 0;
            this.LabelNum.Text = "学号：";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Location = new System.Drawing.Point(35, 100);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(41, 12);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "姓名：";
            // 
            // LablePwd
            // 
            this.LablePwd.AutoSize = true;
            this.LablePwd.Location = new System.Drawing.Point(35, 140);
            this.LablePwd.Name = "LablePwd";
            this.LablePwd.Size = new System.Drawing.Size(41, 12);
            this.LablePwd.TabIndex = 2;
            this.LablePwd.Text = "密码：";
            // 
            // TextNum
            // 
            this.TextNum.Location = new System.Drawing.Point(82, 55);
            this.TextNum.Name = "TextNum";
            this.TextNum.Size = new System.Drawing.Size(125, 21);
            this.TextNum.TabIndex = 3;
            // 
            // TextName
            // 
            this.TextName.Location = new System.Drawing.Point(82, 97);
            this.TextName.Name = "TextName";
            this.TextName.Size = new System.Drawing.Size(125, 21);
            this.TextName.TabIndex = 4;
            // 
            // TextPwd
            // 
            this.TextPwd.Location = new System.Drawing.Point(82, 137);
            this.TextPwd.Name = "TextPwd";
            this.TextPwd.PasswordChar = '*';
            this.TextPwd.Size = new System.Drawing.Size(125, 21);
            this.TextPwd.TabIndex = 5;
            // 
            // BtnLogin
            // 
            this.BtnLogin.Location = new System.Drawing.Point(37, 194);
            this.BtnLogin.Name = "BtnLogin";
            this.BtnLogin.Size = new System.Drawing.Size(75, 23);
            this.BtnLogin.TabIndex = 6;
            this.BtnLogin.Text = "登录";
            this.BtnLogin.UseVisualStyleBackColor = true;
            this.BtnLogin.Click += new System.EventHandler(this.BtnLogin_Click);
            // 
            // BtnRegister
            // 
            this.BtnRegister.Location = new System.Drawing.Point(132, 194);
            this.BtnRegister.Name = "BtnRegister";
            this.BtnRegister.Size = new System.Drawing.Size(75, 23);
            this.BtnRegister.TabIndex = 7;
            this.BtnRegister.Text = "注册";
            this.BtnRegister.UseVisualStyleBackColor = true;
            this.BtnRegister.Click += new System.EventHandler(this.BtnRegister_Click);
            // 
            // FrmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(246, 266);
            this.Controls.Add(this.BtnRegister);
            this.Controls.Add(this.BtnLogin);
            this.Controls.Add(this.TextPwd);
            this.Controls.Add(this.TextName);
            this.Controls.Add(this.TextNum);
            this.Controls.Add(this.LablePwd);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.LabelNum);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmLogin";
            this.Text = "登录界面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LabelNum;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label LablePwd;
        private System.Windows.Forms.TextBox TextNum;
        private System.Windows.Forms.TextBox TextName;
        private System.Windows.Forms.TextBox TextPwd;
        private System.Windows.Forms.Button BtnLogin;
        private System.Windows.Forms.Button BtnRegister;
    }
}