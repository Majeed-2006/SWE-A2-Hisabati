using BusinessLayerBL;
using System.Data;
using System.Windows.Forms;
namespace Personal_Budgeting_UI
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
         
            string usernameInput = txtUsername.Text.Trim(); 
            string passwordInput = txtPassword.Text;

           
            if (string.IsNullOrEmpty(usernameInput) || string.IsNullOrEmpty(passwordInput))
            {
                MessageBox.Show("Please enter both username and password.", "Input Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (clsUser.Login(usernameInput, passwordInput))
            {
              
                MessageBox.Show("Login successful! Welcome to Hisabati.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                frmMain mainForm = new frmMain();

                
                mainForm.Show();

               
                this.Hide();
            }
            else
            {
               
                MessageBox.Show("Invalid username or password!", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                txtPassword.Clear();
                txtPassword.Focus();
            }
        }
        private void btnSignUp_Click(object sender, EventArgs e)
        {
            frmSignUp frm = new frmSignUp();

           
            frm.ShowDialog();
        }

    }
}
