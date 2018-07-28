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
    public partial class CreateNote : Form
    {
        string username;
        public CreateNote(string username)
        {
            InitializeComponent();
            this.username = username;
            CenterToScreen();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        CreateNoteBll notebll = new CreateNoteBll();
        addCategoryBLL getUserIdByUserName = new addCategoryBLL();
        private void CreateNote_Load(object sender, EventArgs e)
        {
            DataTable data = getUserIdByUserName.getUserId(username);
            int userId = int.Parse(data.Rows[0][0].ToString());
            DataTable dt = notebll.getCategory(userId);
            cmbCategory.DataSource = dt; 
            cmbCategory.DisplayMember = "categoryName";
            cmbCategory.ValueMember = "categoryId";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text == "")
            {
                MessageBox.Show("Title is empty", "Empty Title", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else if (txtContent.Text == "")
            {
                MessageBox.Show("Content is empty Cannot create note", "Empty Content",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                DataTable dt = getUserIdByUserName.getUserId(username);
                int userId = int.Parse(dt.Rows[0][0].ToString());
                int categoryId = (int)cmbCategory.SelectedValue;
                string noteTitle = txtTitle.Text;
                string noteCategory = cmbCategory.Text;
                string noteContent = txtContent.Text;
                notebll.insertNoteInfo(userId, categoryId, noteTitle, noteCategory,noteContent);
                MessageBox.Show("Note Added Successfully");
                txtTitle.Clear();
                txtContent.Clear();

                
                this.Hide();
                StickyNotes stickyNotes = new StickyNotes(username);
                stickyNotes.ShowDialog();
                this.Close();

            }
          
        }
        public Point mouseLocation;
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLocation = new Point(-e.X,-e.Y);
        }

        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
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
