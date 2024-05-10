namespace CarlosMoran_Clients_Project.Forms {
    partial class LoginForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            btn_login = new Button();
            txt_username = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_password = new TextBox();
            btn_newuser = new Button();
            SuspendLayout();
            // 
            // btn_login
            // 
            btn_login.Location = new Point(186, 274);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(117, 28);
            btn_login.TabIndex = 3;
            btn_login.Text = "Ok";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // txt_username
            // 
            txt_username.Location = new Point(98, 214);
            txt_username.MaxLength = 20;
            txt_username.Name = "txt_username";
            txt_username.PlaceholderText = "Username";
            txt_username.Size = new Size(130, 23);
            txt_username.TabIndex = 1;
            // 
            // label1
            // 
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Location = new Point(98, 188);
            label1.Name = "label1";
            label1.Size = new Size(130, 23);
            label1.TabIndex = 2;
            label1.Text = "Username";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.BorderStyle = BorderStyle.FixedSingle;
            label2.Location = new Point(267, 188);
            label2.Name = "label2";
            label2.Size = new Size(130, 23);
            label2.TabIndex = 4;
            label2.Text = "Password";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(267, 214);
            txt_password.MaxLength = 20;
            txt_password.Name = "txt_password";
            txt_password.PlaceholderText = "Password";
            txt_password.Size = new Size(130, 23);
            txt_password.TabIndex = 2;
            // 
            // btn_newuser
            // 
            btn_newuser.Location = new Point(186, 118);
            btn_newuser.Name = "btn_newuser";
            btn_newuser.Size = new Size(117, 28);
            btn_newuser.TabIndex = 5;
            btn_newuser.Text = "New User";
            btn_newuser.UseVisualStyleBackColor = true;
            btn_newuser.Click += btn_newuser_Click;
            // 
            // LoginForm
            // 
            AcceptButton = btn_login;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.png_lawyer_symbols_file_egyptian_law_icon_png_1017_881225821;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(492, 400);
            Controls.Add(btn_newuser);
            Controls.Add(label2);
            Controls.Add(txt_password);
            Controls.Add(label1);
            Controls.Add(txt_username);
            Controls.Add(btn_login);
            DoubleBuffered = true;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_login;
        private TextBox txt_username;
        private Label label1;
        private Label label2;
        private TextBox txt_password;
        private Button btn_newuser;
    }
}