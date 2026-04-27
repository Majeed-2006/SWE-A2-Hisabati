namespace Personal_Budgeting_UI
{
    partial class frmSignUp
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
            labelFirstName = new Label();
            txtFirstName = new TextBox();
            Title = new Label();
            labelLogin = new Label();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtLastName = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            txtCurrency = new TextBox();
            btnSave = new Button();
            SuspendLayout();
            // 
            // labelFirstName
            // 
            labelFirstName.AutoSize = true;
            labelFirstName.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelFirstName.Location = new Point(236, 162);
            labelFirstName.Name = "labelFirstName";
            labelFirstName.Size = new Size(84, 22);
            labelFirstName.TabIndex = 5;
            labelFirstName.Text = "First Name";
            // 
            // txtFirstName
            // 
            txtFirstName.Location = new Point(328, 164);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(207, 23);
            txtFirstName.TabIndex = 6;
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Title.AutoSize = true;
            Title.FlatStyle = FlatStyle.Popup;
            Title.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.Location = new Point(226, 9);
            Title.Name = "Title";
            Title.Size = new Size(327, 76);
            Title.TabIndex = 7;
            Title.Text = "Hisabati";
            // 
            // labelLogin
            // 
            labelLogin.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            labelLogin.AutoSize = true;
            labelLogin.FlatStyle = FlatStyle.Popup;
            labelLogin.Font = new Font("Stencil", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelLogin.Location = new Point(236, 99);
            labelLogin.Name = "labelLogin";
            labelLogin.Size = new Size(299, 44);
            labelLogin.TabIndex = 8;
            labelLogin.Text = "SignUp Screen";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(236, 200);
            label1.Name = "label1";
            label1.Size = new Size(80, 22);
            label1.TabIndex = 9;
            label1.Text = "Last Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(236, 238);
            label2.Name = "label2";
            label2.Size = new Size(49, 22);
            label2.TabIndex = 10;
            label2.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(236, 314);
            label4.Name = "label4";
            label4.Size = new Size(70, 22);
            label4.TabIndex = 12;
            label4.Text = "Currency";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Sylfaen", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(236, 276);
            label5.Name = "label5";
            label5.Size = new Size(72, 22);
            label5.TabIndex = 13;
            label5.Text = "Password";
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(328, 202);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(207, 23);
            txtLastName.TabIndex = 14;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(328, 240);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(207, 23);
            txtEmail.TabIndex = 15;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(328, 278);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(207, 23);
            txtPassword.TabIndex = 16;
            // 
            // txtCurrency
            // 
            txtCurrency.CharacterCasing = CharacterCasing.Upper;
            txtCurrency.Location = new Point(328, 316);
            txtCurrency.Name = "txtCurrency";
            txtCurrency.Size = new Size(207, 23);
            txtCurrency.TabIndex = 17;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(328, 361);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(124, 38);
            btnSave.TabIndex = 18;
            btnSave.Text = "Register";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // frmSignUp
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSave);
            Controls.Add(txtCurrency);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtLastName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelLogin);
            Controls.Add(Title);
            Controls.Add(txtFirstName);
            Controls.Add(labelFirstName);
            Name = "frmSignUp";
            Text = "frmSignUp";
            Load += frmSignUp_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelFirstName;
        private TextBox txtFirstName;
        private Label Title;
        private Label labelLogin;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txtLastName;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtCurrency;
        private Button btnSave;
    }
}