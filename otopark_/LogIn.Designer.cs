namespace otopark_
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            btn_login = new Button();
            tBox_user_name = new TextBox();
            tBox_password = new TextBox();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Image = (Image)resources.GetObject("btn_login.Image");
            btn_login.ImageAlign = ContentAlignment.MiddleLeft;
            btn_login.Location = new Point(70, 199);
            btn_login.Margin = new Padding(3, 4, 3, 4);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(142, 49);
            btn_login.TabIndex = 0;
            btn_login.Text = "Login";
            btn_login.TextAlign = ContentAlignment.MiddleRight;
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // tBox_user_name
            // 
            tBox_user_name.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            tBox_user_name.ForeColor = SystemColors.WindowFrame;
            tBox_user_name.Location = new Point(70, 56);
            tBox_user_name.Margin = new Padding(3, 4, 3, 4);
            tBox_user_name.Name = "tBox_user_name";
            tBox_user_name.Size = new Size(141, 27);
            tBox_user_name.TabIndex = 1;
            tBox_user_name.Text = "  Username";
            tBox_user_name.Click += tBox_user_name_Click;
            
            // 
            // tBox_password
            // 
            tBox_password.Font = new Font("Segoe UI", 9F, FontStyle.Italic);
            tBox_password.ForeColor = SystemColors.WindowFrame;
            tBox_password.Location = new Point(70, 121);
            tBox_password.Margin = new Padding(3, 4, 3, 4);
            tBox_password.Name = "tBox_password";
            tBox_password.PasswordChar = '*';
            tBox_password.Size = new Size(141, 27);
            tBox_password.TabIndex = 2;
            tBox_password.Text = "  Password";
            tBox_password.Click += tBox_password_Click;
            
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(274, 308);
            Controls.Add(tBox_password);
            Controls.Add(tBox_user_name);
            Controls.Add(btn_login);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form2";
            Text = "User";
           
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        public TextBox tBox_user_name;
        public TextBox tBox_password;
    }
}