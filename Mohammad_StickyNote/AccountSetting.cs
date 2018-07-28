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
    public partial class AccountSetting : Form
    {
        string username;
        public AccountSetting(string username)
        {
            InitializeComponent();
            this.username = username;
            CenterToScreen();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            StickyNotes stickyNote = new StickyNotes(this.username);
            stickyNote.ShowDialog();
            this.Close();
            
        }

        public Point mouseLocation;
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X, -e.Y);
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePosition = Control.MousePosition;
                mousePosition.Offset(mouseLocation.X, mouseLocation.Y);
                Location = mousePosition;
            }
        }
        AccountSettingbll acbll = new AccountSettingbll();
        int userId;
        private void AccountSetting_Load(object sender, EventArgs e)
        {
            
            addCategoryBLL getUserIdByUserName = new addCategoryBLL();
            DataTable dt = getUserIdByUserName.getUserId(this.username);
            userId = int.Parse(dt.Rows[0][0].ToString());
            DataTable data=acbll.accountSetting(userId);
            txtFname.Text = data.Rows[0][0].ToString();
            txtLname.Text = data.Rows[0][1].ToString();
            string gender = data.Rows[0][2].ToString();
            if (gender == "Male")
            {
                rdoMale.Checked = true;
            } else if (gender == "Female")
            {
                rdoFemale.Checked = true;
            } else if (gender == "Other")
            {
                rdoOther.Checked = true;
            }
            datePicker.Text = data.Rows[0][3].ToString();
            txtEmail.Text = data.Rows[0][4].ToString();
            txtUsername.Text = data.Rows[0][5].ToString();
            txtPassword.Text = data.Rows[0][6].ToString();
            txtConfirmPassword.Text = data.Rows[0][7].ToString();
        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
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
            string fname = txtFname.Text;
            string lname = txtLname.Text;
            string gender="";
            if (rdoMale.Checked)
            {
                gender = rdoMale.Text;
            }
            else if (rdoFemale.Checked)
            {
                gender = rdoFemale.Text;
            }
            else if (rdoOther.Checked)
            {
                gender = rdoOther.Text;
            }
            string dob = datePicker.Text; ;
            string email = txtEmail.Text;
            string Uname= txtUsername.Text;
            string password= txtPassword.Text;
            string confirmpassword = txtConfirmPassword.Text;
            acbll.updateAccountSetting(userId,fname,lname,gender,dob,email,Uname,password,confirmpassword);
            this.username = txtUsername.Text;
            MessageBox.Show("Account updated successfully");
            StickyNotes stickyNotes = new StickyNotes(this.username);
            stickyNotes.ShowDialog();
            this.Close();
        }
    }
}
