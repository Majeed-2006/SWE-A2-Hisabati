namespace Personal_Budgeting_UI
{
    partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new Label();
            labelLogin = new Label();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            labelUserName = new Label();
            label1 = new Label();
            buttonLogin = new Button();
            label2 = new Label();
            btnSignUp = new Button();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Title.AutoSize = true;
            Title.FlatStyle = FlatStyle.Popup;
            Title.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.Location = new Point(247, 22);
            Title.Name = "Title";
            Title.Size = new Size(327, 76);
            Title.TabIndex = 0;
            Title.Text = "Hisabati";
            // 
            // labelLogin
            // 
            labelLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelLogin.AutoSize = true;
            labelLogin.FlatStyle = FlatStyle.Popup;
            labelLogin.Font = new Font("Stencil", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLogin.Location = new Point(269, 131);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(272, 44);
            labelLogin.TabIndex = 1;
            labelLogin.Text = "Login Screen";
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(367, 223);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(207, 23);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(367, 271);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(207, 23);
            txtPassword.TabIndex = 3;
            // 
            // labelUserName
            // 
            labelUserName.AutoSize = true;
            labelUserName.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelUserName.Location = new Point(277, 224);
            labelUserName.Name = "labelUserName";
            labelUserName.Size = new Size(84, 22);
            labelUserName.TabIndex = 4;
            labelUserName.Text = "User Name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(277, 271);
            label1.Name = "label1";
            label1.Size = new Size(72, 22);
            label1.TabIndex = 5;
            label1.Text = "Password";
            // 
            // buttonLogin
            // 
            buttonLogin.Location = new Point(367, 317);
            buttonLogin.Name = "buttonLogin";
            buttonLogin.Size = new Size(124, 38);
            buttonLogin.TabIndex = 6;
            buttonLogin.Text = "Login";
            buttonLogin.UseVisualStyleBackColor = true;
            buttonLogin.Click += btnLogin_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.DarkRed;
            label2.Location = new Point(364, 363);
            label2.Name = "label2";
            label2.Size = new Size(131, 15);
            label2.TabIndex = 7;
            label2.Text = "Don't have an account?";
            // 
            // btnSignUp
            // 
            btnSignUp.Location = new Point(367, 385);
            btnSignUp.Name = "btnSignUp";
            btnSignUp.Size = new Size(124, 38);
            btnSignUp.TabIndex = 8;
            btnSignUp.Text = "SignUp";
            btnSignUp.UseVisualStyleBackColor = true;
            btnSignUp.Click += btnSignUp_Click;
            // 
            // frmLogin
            // 
            AcceptButton = buttonLogin;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSignUp);
            Controls.Add(label2);
            Controls.Add(buttonLogin);
            Controls.Add(label1);
            Controls.Add(labelUserName);
            Controls.Add(txtPassword);
            Controls.Add(txtUsername);
            Controls.Add(labelLogin);
            Controls.Add(Title);
            Name = "frmLogin";
            Text = "Hisabati - Login / signUp";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Label labelLogin;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label labelUserName;
        private Label label1;
        private Button buttonLogin;
        private Label label2;
        private System.Windows.Forms.Button btnSignUp;

    }
}
