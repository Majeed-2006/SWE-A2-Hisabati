namespace Personal_Budgeting_UI
{
    partial class frmMain
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
            Title = new Label();
            btnDashboard = new Button();
            btnAccountInfo = new Button();
            btnBudgets = new Button();
            btnCategories = new Button();
            btnTransactions = new Button();
            btnExit = new Button();
            label1 = new Label();
            pnlViewContainer = new Panel();
            btnBack = new Button();
            pnlViewContainer.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Title.AutoSize = true;
            Title.FlatStyle = FlatStyle.Popup;
            Title.Font = new Font("Stencil", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.Location = new Point(232, 9);
            Title.Name = "Title";
            Title.Size = new Size(327, 76);
            Title.TabIndex = 1;
            Title.Text = "Hisabati";
            // 
            // btnDashboard
            // 
            btnDashboard.BackColor = Color.White;
            btnDashboard.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnDashboard.FlatAppearance.MouseDownBackColor = Color.White;
            btnDashboard.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.Font = new Font("Akhbar MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            btnDashboard.ForeColor = Color.Black;
            btnDashboard.Location = new Point(163, 180);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(200, 44);
            btnDashboard.TabIndex = 2;
            btnDashboard.Text = "Dashboard";
            btnDashboard.UseVisualStyleBackColor = false;
            btnDashboard.Click += btnDashboard_Click;
            // 
            // btnAccountInfo
            // 
            btnAccountInfo.BackColor = Color.White;
            btnAccountInfo.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnAccountInfo.FlatAppearance.MouseDownBackColor = Color.White;
            btnAccountInfo.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnAccountInfo.FlatStyle = FlatStyle.Flat;
            btnAccountInfo.Font = new Font("Akhbar MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            btnAccountInfo.ForeColor = Color.Black;
            btnAccountInfo.Location = new Point(163, 342);
            btnAccountInfo.Name = "btnAccountInfo";
            btnAccountInfo.Size = new Size(200, 44);
            btnAccountInfo.TabIndex = 3;
            btnAccountInfo.Text = "Account Info";
            btnAccountInfo.UseVisualStyleBackColor = false;
            btnAccountInfo.Click += btnAccountInfo_Click;
            // 
            // btnBudgets
            // 
            btnBudgets.BackColor = Color.White;
            btnBudgets.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnBudgets.FlatAppearance.MouseDownBackColor = Color.White;
            btnBudgets.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnBudgets.FlatStyle = FlatStyle.Flat;
            btnBudgets.Font = new Font("Akhbar MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            btnBudgets.ForeColor = Color.Black;
            btnBudgets.Location = new Point(413, 262);
            btnBudgets.Name = "btnBudgets";
            btnBudgets.Size = new Size(200, 44);
            btnBudgets.TabIndex = 4;
            btnBudgets.Text = "Budgets";
            btnBudgets.UseVisualStyleBackColor = false;
            btnBudgets.Click += btnBudgets_Click;
            // 
            // btnCategories
            // 
            btnCategories.BackColor = Color.White;
            btnCategories.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnCategories.FlatAppearance.MouseDownBackColor = Color.White;
            btnCategories.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnCategories.FlatStyle = FlatStyle.Flat;
            btnCategories.Font = new Font("Akhbar MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            btnCategories.ForeColor = Color.Black;
            btnCategories.Location = new Point(163, 262);
            btnCategories.Name = "btnCategories";
            btnCategories.Size = new Size(200, 44);
            btnCategories.TabIndex = 5;
            btnCategories.Text = "Categories";
            btnCategories.UseVisualStyleBackColor = false;
            btnCategories.Click += btnCategories_Click;
            // 
            // btnTransactions
            // 
            btnTransactions.BackColor = Color.White;
            btnTransactions.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnTransactions.FlatAppearance.MouseDownBackColor = Color.White;
            btnTransactions.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnTransactions.FlatStyle = FlatStyle.Flat;
            btnTransactions.Font = new Font("Akhbar MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            btnTransactions.ForeColor = Color.Black;
            btnTransactions.Location = new Point(413, 180);
            btnTransactions.Name = "btnTransactions";
            btnTransactions.Size = new Size(200, 44);
            btnTransactions.TabIndex = 6;
            btnTransactions.Text = "Transactions";
            btnTransactions.UseVisualStyleBackColor = false;
            btnTransactions.Click += btnTransactions_Click;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.White;
            btnExit.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnExit.FlatAppearance.MouseDownBackColor = Color.White;
            btnExit.FlatAppearance.MouseOverBackColor = Color.Gray;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Font = new Font("Akhbar MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            btnExit.ForeColor = Color.Black;
            btnExit.Location = new Point(413, 342);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(200, 44);
            btnExit.TabIndex = 7;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.FlatStyle = FlatStyle.Popup;
            label1.Font = new Font("Sylfaen", 26.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(179, 98);
            label1.Name = "label1";
            label1.Size = new Size(456, 46);
            label1.TabIndex = 8;
            label1.Text = "How can We help you today?";
            // 
            // pnlViewContainer
            // 
            pnlViewContainer.Controls.Add(btnBack);
            pnlViewContainer.Dock = DockStyle.Fill;
            pnlViewContainer.Location = new Point(0, 0);
            pnlViewContainer.Name = "pnlViewContainer";
            pnlViewContainer.Size = new Size(800, 450);
            pnlViewContainer.TabIndex = 9;
            pnlViewContainer.Visible = false;
            pnlViewContainer.Paint += panel1_Paint;
            // 
            // btnBack
            // 
            btnBack.FlatAppearance.BorderColor = Color.DodgerBlue;
            btnBack.Font = new Font("Akhbar MT", 12F, FontStyle.Regular, GraphicsUnit.Point, 178);
            btnBack.Location = new Point(298, 394);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(200, 44);
            btnBack.TabIndex = 0;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            btnBack.Click += btnBack_Click;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Title);
            Controls.Add(btnBudgets);
            Controls.Add(btnAccountInfo);
            Controls.Add(btnTransactions);
            Controls.Add(btnDashboard);
            Controls.Add(btnCategories);
            Controls.Add(btnExit);
            Controls.Add(pnlViewContainer);
            Name = "frmMain";
            Text = "frmMain";
            Load += frmMain_Load;
            pnlViewContainer.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Title;
        private Button btnDashboard;
        private Button btnAccountInfo;
        private Button btnBudgets;
        private Button btnCategories;
        private Button btnTransactions;
        private Button btnExit;
        private Label label1;
        private Panel pnlViewContainer;
        private Button btnBack;
    }
}