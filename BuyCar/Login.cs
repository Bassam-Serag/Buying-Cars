using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BuyCar
{
    public partial class Login : Form
    {
        Context context = new Context();
        public Login()
        {
            InitializeComponent();
            context.Admins.Add(new Admin() { UserName = "Admin", Password = "Admin" });
            context.SaveChanges();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //Home home = new Home();
            //home.Show();
            //this.Hide();
            string username = textName.Text;
            string password = textPass.Text;
            try
            {
                Admin admin = context.Admins.Where(a => a.UserName.Equals(username)).FirstOrDefault();

                if (admin != null && admin.Password.Equals(password))
                {
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Invalid username or password", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Not valid Admin", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


    }
}

