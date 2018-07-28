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
    public partial class SendEmail : Form
    {
        public SendEmail()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        sendEmailBLL emailbll = new sendEmailBLL();
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtEmail.Text.Trim()))
            {
                emailbll._email = txtEmail.Text;
                bool isValidEmail = emailbll.checkEmail();
                if (isValidEmail)
                {
                    this.Hide();
                    ResetAccount reset = new ResetAccount(emailbll._email);
                    reset.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Email !!!");
                }
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
