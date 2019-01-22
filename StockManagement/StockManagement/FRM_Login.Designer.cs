namespace StockManagement
{
    partial class FRM_Login
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
            this.TB_Username = new System.Windows.Forms.TextBox();
            this.TB_Password = new System.Windows.Forms.TextBox();
            this.L_UserName = new System.Windows.Forms.Label();
            this.L_Password = new System.Windows.Forms.Label();
            this.BT_Clear = new System.Windows.Forms.Button();
            this.BT_Login = new System.Windows.Forms.Button();
            this.LL_ForgetPass = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // TB_Username
            // 
            this.TB_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Username.Location = new System.Drawing.Point(155, 50);
            this.TB_Username.Name = "TB_Username";
            this.TB_Username.Size = new System.Drawing.Size(215, 27);
            this.TB_Username.TabIndex = 0;
            this.TB_Username.Text = "admin";
            // 
            // TB_Password
            // 
            this.TB_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TB_Password.Location = new System.Drawing.Point(155, 89);
            this.TB_Password.Name = "TB_Password";
            this.TB_Password.PasswordChar = '*';
            this.TB_Password.Size = new System.Drawing.Size(215, 27);
            this.TB_Password.TabIndex = 1;
            this.TB_Password.Text = "admin";
            // 
            // L_UserName
            // 
            this.L_UserName.AutoSize = true;
            this.L_UserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_UserName.Location = new System.Drawing.Point(37, 53);
            this.L_UserName.Name = "L_UserName";
            this.L_UserName.Size = new System.Drawing.Size(104, 20);
            this.L_UserName.TabIndex = 2;
            this.L_UserName.Text = "User Name :";
            // 
            // L_Password
            // 
            this.L_Password.AutoSize = true;
            this.L_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.L_Password.Location = new System.Drawing.Point(48, 92);
            this.L_Password.Name = "L_Password";
            this.L_Password.Size = new System.Drawing.Size(93, 20);
            this.L_Password.TabIndex = 3;
            this.L_Password.Text = "Password :";
            // 
            // BT_Clear
            // 
            this.BT_Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Clear.Location = new System.Drawing.Point(155, 162);
            this.BT_Clear.Name = "BT_Clear";
            this.BT_Clear.Size = new System.Drawing.Size(82, 31);
            this.BT_Clear.TabIndex = 4;
            this.BT_Clear.Text = "Clear";
            this.BT_Clear.UseVisualStyleBackColor = true;
            this.BT_Clear.Click += new System.EventHandler(this.BT_Clear_Click);
            // 
            // BT_Login
            // 
            this.BT_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BT_Login.Location = new System.Drawing.Point(288, 162);
            this.BT_Login.Name = "BT_Login";
            this.BT_Login.Size = new System.Drawing.Size(82, 31);
            this.BT_Login.TabIndex = 5;
            this.BT_Login.Text = "Login";
            this.BT_Login.UseVisualStyleBackColor = true;
            this.BT_Login.Click += new System.EventHandler(this.BT_Login_Click);
            // 
            // LL_ForgetPass
            // 
            this.LL_ForgetPass.AutoSize = true;
            this.LL_ForgetPass.Location = new System.Drawing.Point(248, 128);
            this.LL_ForgetPass.Name = "LL_ForgetPass";
            this.LL_ForgetPass.Size = new System.Drawing.Size(122, 17);
            this.LL_ForgetPass.TabIndex = 6;
            this.LL_ForgetPass.TabStop = true;
            this.LL_ForgetPass.Text = "Forget Password?";
            this.LL_ForgetPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LL_ForgetPass_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 225);
            this.Controls.Add(this.LL_ForgetPass);
            this.Controls.Add(this.BT_Login);
            this.Controls.Add(this.BT_Clear);
            this.Controls.Add(this.L_Password);
            this.Controls.Add(this.L_UserName);
            this.Controls.Add(this.TB_Password);
            this.Controls.Add(this.TB_Username);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TB_Username;
        private System.Windows.Forms.TextBox TB_Password;
        private System.Windows.Forms.Label L_UserName;
        private System.Windows.Forms.Label L_Password;
        private System.Windows.Forms.Button BT_Clear;
        private System.Windows.Forms.Button BT_Login;
        private System.Windows.Forms.LinkLabel LL_ForgetPass;
    }
}