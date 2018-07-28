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
    public partial class ResetAccount : Form
    {
        string email;
        public ResetAccount(string email)
        {
            this.email = email;
            InitializeComponent();
            CenterToScreen();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        ResetAccountBLL reset = new ResetAccountBLL();
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (txtNewUname.Text == "" && txtNewPass.Text == "" && txtNewCPass.Text == "")
            {
                MessageBox.Show("Please fill up all field first");
            }
            else if (txtNewPass.Text.Length < 5)
            {
                MessageBox.Show("password length must be five character");
            }
            else if (txtNewPass.Text != txtNewCPass.Text)
            {
                MessageBox.Show("password mismatch");
            } 
            else
            {
                //getting text boxes values
                reset._newUsername = txtNewUname.Text;
                reset._newPassword = txtNewPass.Text;
                reset._confirmPassword = txtNewCPass.Text;
                reset.resetAccount(email);
                MessageBox.Show("Account reset successfully");

                //open login form
                this.Hide();
                Login login = new Login();
                login.ShowDialog();
                this.Close();

                //Clear all text boxes
                txtNewCPass.Clear();
                txtNewPass.Clear();
                txtNewUname.Clear();
            }      
        }
        public Point mouseLocation;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X,-e.Y);
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
