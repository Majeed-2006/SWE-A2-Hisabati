using BusinessLayerBL;
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
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void frmSignUp_Load(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstName.Text) || string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Please fill in all required fields!");
                return;
            }

            clsUser newUser = new clsUser();

            newUser.FirstName = txtFirstName.Text.Trim();
            newUser.LastName = txtLastName.Text.Trim();
            newUser.Email = txtEmail.Text.Trim();
            newUser.Password = txtPassword.Text;
            newUser.Currency = txtCurrency.Text.Trim();

            if (newUser.Save())
            {
                MessageBox.Show($"Registration Successful!\n\nYour Login Username is: {newUser.Username}",
                                "Welcome", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("Registration Failed! Please check your connection.", "Error");
            }
        }
    }
}
