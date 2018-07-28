using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mohammad_StickyNote
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSingup_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register register = new Register();
            register.ShowDialog();
            this.Close();
        }

        private void lblLink_Click(object sender, EventArgs e)
        {
            this.Hide();
            SendEmail sendEmail = new SendEmail();
            sendEmail.ShowDialog();
            this.Close();
        }
        LoginBLL loginbll = new LoginBLL();
        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtUserName.Text.Trim())&&!string.IsNullOrEmpty(txtPassword.Text.Trim()))
            {
                loginbll._username = txtUserName.Text;
                loginbll._password = txtPassword.Text;
                bool isValidUser = loginbll.CheckUser();
                if (isValidUser)
                {
                    this.Hide();
                    StickyNoteCharts stickyNoteChart = new StickyNoteCharts(loginbll._username);
                    stickyNoteChart.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Either username or password is wrong !!!");
                    txtUserName.Clear();
                    txtPassword.Clear();
                }
            }          
        }
        public Point mouseLocation;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePosition = Control.MousePosition;
                mousePosition.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePosition;
            }
        }
    }
}
