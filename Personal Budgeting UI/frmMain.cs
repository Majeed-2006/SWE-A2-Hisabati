using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Personal_Budgeting_UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowControl(new ctrlDashboard());
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            ShowControl(new ctrlTransactions());
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            ShowControl(new ctrlCategories());
        }

        private void btnBudgets_Click(object sender, EventArgs e)
        {
            ShowControl(new ctrlBudget());
        }

        private void btnAccountInfo_Click(object sender, EventArgs e)
        {
            ShowControl(new ctrlAccountInfo());
        }

        private void frmMain_Load(object sender, EventArgs e)
        {


            btnDashboard.ForeColor = Color.Black;
            btnTransactions.ForeColor = Color.Black;
            btnAccountInfo.ForeColor = Color.Black;
            btnBudgets.ForeColor = Color.Black;
            btnExit.ForeColor = Color.Black;
            btnCategories.ForeColor = Color.Black;
            btnDashboard.BackColor = Color.White;
            btnTransactions.BackColor = Color.White;
            btnAccountInfo.BackColor = Color.White;
            btnBudgets.BackColor = Color.White;
            btnExit.BackColor = Color.White;
            btnCategories.BackColor = Color.White;


        }
        private void ShowControl(UserControl control)
        {
           
            foreach (Control c in this.Controls)
            {
                if (c.Name != "pnlViewContainer") c.Visible = false;
            }

            
            pnlViewContainer.Visible = true;
            pnlViewContainer.Dock = DockStyle.Fill;

            btnBack.Visible = true;

            var oldUserControl = pnlViewContainer.Controls.OfType<UserControl>().FirstOrDefault();
            if (oldUserControl != null) pnlViewContainer.Controls.Remove(oldUserControl);

           
            control.Dock = DockStyle.Fill;
            pnlViewContainer.Controls.Add(control);

           
            control.SendToBack();
            btnBack.BringToFront();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pnlViewContainer.Visible = false;

           
            foreach (Control c in this.Controls)
            {
                c.Visible = true;
            }
            btnBack.Visible = false;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            this.Hide(); 
        }
    }
}
