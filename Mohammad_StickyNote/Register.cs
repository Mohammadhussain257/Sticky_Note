using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mohammad_StickyNote
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            CenterToScreen();
        }
        RegisterBLL registerbll = new RegisterBLL();
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (txtFname.Text == "" || txtLname.Text == "" || txtEmail.Text == "" 
                || txtUsername.Text == "" || txtPassword.Text == "" || txtConfirmPassword.Text == "")
            {
                MessageBox.Show("Please fill up all fields first");
                return;
            }
            if (!this.txtEmail.Text.Contains('@') || !this.txtEmail.Text.Contains('.'))
            {
                MessageBox.Show("Please Enter A Valid Email", "Invalid Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (rdoMale.Checked == false && rdoFemale.Checked == false && rdoOther.Checked == false)
            {
                MessageBox.Show("Please select your gender");
                return;
            }
            else if (txtPassword.Text.Length < 5)
            {
                MessageBox.Show("password length must be five character");
                return;
            }
            else if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MessageBox.Show("Password mismatch");
                return;
            }
            else if (!string.IsNullOrEmpty(txtEmail.Text.Trim())&&!string.IsNullOrEmpty(txtUsername.Text.Trim()))
            {
                registerbll._username = txtUsername.Text;
                bool checkRegistration = registerbll.checkRegistration();
                if (checkRegistration)
                {
                    registerbll._fname = txtFname.Text;
                    registerbll._lname = txtLname.Text;
                    if (rdoMale.Checked)
                    {
                        registerbll._gender = rdoMale.Text;
                    }
                    else if (rdoFemale.Checked)
                    {
                        registerbll._gender = rdoFemale.Text;
                    }
                    else if (rdoOther.Checked)
                    {
                        registerbll._gender = rdoOther.Text;
                    }
                    registerbll._dob = datePicker.Text;
                    registerbll._email = txtEmail.Text;
                    registerbll._username = txtUsername.Text;
                    registerbll._password = txtPassword.Text;
                    registerbll._confirmpassword = txtConfirmPassword.Text;
                    registerbll.insertUserInfo();
                    MessageBox.Show("Signup Successfully");
                    this.Hide();
                    Login login = new Login();
                    login.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Username already exist");
                    return;
                }

            }
            
            txtFname.Clear();
            txtLname.Clear();
            txtEmail.Clear();
            txtUsername.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();
            rdoOther.Checked = false;
            rdoFemale.Checked = false;
            rdoMale.Checked = false;
        }
        public Point mouserLocation;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouserLocation = new Point(-e.X,-e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePosition = Control.MousePosition;
                mousePosition.Offset(mouserLocation.X, mouserLocation.Y);
                Location = mousePosition;
            }
        }
    }
}
