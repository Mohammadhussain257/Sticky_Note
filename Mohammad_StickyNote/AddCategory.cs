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
    public partial class AddCategory : Form
    {
        string username;
        public AddCategory(string username)
        {
            InitializeComponent();
            this.username = username;
            CenterToScreen();
        }
        addCategoryBLL categorybll = new addCategoryBLL();
        StickyNoteBLL stickyNotesbll = new StickyNoteBLL();
        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int categoryid;
        int userId;
        private void btnSave_Click(object sender, EventArgs e)
        {
            DataTable dt = categorybll.getUserId(username);
            int userId = int.Parse(dt.Rows[0][0].ToString());
            if (!string.IsNullOrEmpty(txtCategory.Text.Trim()))
            {
                string categoryName = txtCategory.Text;
                bool isCategoryExist = categorybll.checkCategory(userId,categoryName);
                if (isCategoryExist)
                {
                    MessageBox.Show("Category name already exist");
                    return;
                }
                else if (txtCategory.Text == "")
                {
                    MessageBox.Show("Enter category name first");
                }
                else if (btnSave.Text == "Save")
                {
                    
                    string category = txtCategory.Text;
                    categorybll.addCetegory(userId, category);
                    dataGridView1.DataSource = categorybll.showCategory(userId);
                    MessageBox.Show("Category added");
                    txtCategory.Clear();
                    StickyNotes stickyNote = new StickyNotes(this.username);
                    this.Hide();
                    stickyNote.ShowDialog();
                    this.Close();
                }
                else if (btnSave.Text == "Update")
                {
                    string category = txtCategory.Text;
                    categorybll.updateCategory(categoryid,category);
                    dataGridView1.DataSource = categorybll.showCategory(userId);
                    MessageBox.Show("Updated Successfully");
                    txtCategory.Text = "";
                }
            }
        }
    
        private void AddCategory_Load(object sender, EventArgs e)
        {
            DataTable dt = categorybll.getUserId(username);
            int userId = int.Parse(dt.Rows[0][0].ToString());
            dataGridView1.DataSource = categorybll.showCategory(userId);
        }
       
        public Point mouseLoaction;
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mouseLoaction = new Point(-e.X,-e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point mousePosition = Control.MousePosition;
                mousePosition.Offset(mouseLoaction.X, mouseLoaction.Y);
                Location = mousePosition;
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSave.Text = "Update";
            dataGridView1.DataSource = categorybll.showCategory(userId);

        }
        DataTable dt;
        private void dataGridView1_Click(object sender, EventArgs e)
        {
            dt = categorybll.getUserId(username);
            userId = int.Parse(dt.Rows[0][0].ToString());
            dt = stickyNotesbll.ShowStickyNotes(userId);
            int columnIndex = dataGridView1.CurrentCell.ColumnIndex;
            categoryid = int.Parse(dataGridView1.CurrentRow.Cells["categoryIds"].Value.ToString());
            if (dataGridView1.CurrentRow.Cells[columnIndex].Value.ToString() == "Edit")
            {
                dt = categorybll.EditCategory(categoryid);
                txtCategory.Text = dt.Rows[0][0].ToString();
            }
            else if (dataGridView1.CurrentRow.Cells[columnIndex].Value.ToString() == "Delete")
            {
                DialogResult result = MessageBox.Show("Are you sure to delete ?", "Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    categorybll.deleteCategory(categoryid);
                    dataGridView1.DataSource = categorybll.showCategory(userId);
                }
            }
        }
    }
}
