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
    public partial class StickyNotes : Form
    {
        string username;
        int userId;
        StickyNoteBLL stickyNotesbll = new StickyNoteBLL();
        string displayNoteStatus = "Sticky";
        

        public StickyNotes(string username)
        {
            InitializeComponent();
            this.username = username;
            lblUser.Text = username;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void createNote_Click(object sender, EventArgs e)
        {
            
            CreateNote createNote = new CreateNote(username);
            createNote.ShowDialog();
            
        }

        private void addCategory_Click(object sender, EventArgs e)
        {
            AddCategory addCategory = new AddCategory(username);
            addCategory.ShowDialog();
        }

        private void singOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.ShowDialog();
            this.Close();
        }

        
        private void showStickyNotes(DataTable dataTable)
        {
            int width = this.MainPanel.Width;
            int x_axis = 10;
            int y_axis = 10;
            
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                //lblNoteId
                Label lblNoteId = new Label();
                lblNoteId.AutoSize = true;
                lblNoteId.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblNoteId.Name = "lblNoteId";
                lblNoteId.Text = "NoteId";
                lblNoteId.Location = new Point(80, 5);
                lblNoteId.Visible = false;

                // txtTitle
                TextBox txtTitle = new TextBox();
                txtTitle.Location = new Point(250, 11);
                txtTitle.Name = "txtTitle";
                txtTitle.Size = new Size(98, 20);
                txtTitle.TabIndex = 7;
                txtTitle.MouseLeave += (s, e) =>
                {
                    int noteId = int.Parse(lblNoteId.Text);
                    stickyNotesbll.updateNoteTitle(noteId, txtTitle.Text);
                };

                // lblDateCreate
                Label lblDateCreate = new Label();
                lblDateCreate.AutoSize = true;
                lblDateCreate.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblDateCreate.Location = new Point(880, 11);
                lblDateCreate.Name = "lblDateCreate";
                lblDateCreate.Size = new Size(100, 17);
                lblDateCreate.TabIndex = 3;
                lblDateCreate.Text = "Date Created : ";

                //lblNoteDate
                Label lblNoteDate = new Label();
                lblNoteDate.AutoSize = true;
                lblNoteDate.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblNoteDate.Location = new Point(980, 12);
                lblNoteDate.Name = "lblNoteDate";
                lblNoteDate.Size = new Size(30, 17);
                lblNoteDate.TabIndex = 9;
                lblNoteDate.Text = "Null";


                // txtContent 
                TextBox txtContent = new TextBox();
                txtContent.Location = new Point(170, 33);
                txtContent.Multiline = true;
                txtContent.Name = "txtContent";
                txtContent.Size = new Size(700, 84);
                txtContent.TabIndex = 0;
                txtContent.MouseLeave += (s, e) =>
                {
                    int noteId = int.Parse(lblNoteId.Text);
                    stickyNotesbll.updateNoteContent(noteId, txtContent.Text);
                };

                // chboxSticked
                CheckBox chboxSticked = new CheckBox();
                chboxSticked.AutoSize = true;
                chboxSticked.Font = new Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                chboxSticked.ForeColor = Color.Black;
                chboxSticked.Location = new Point(35, 50);
                chboxSticked.Name = "chboxSticked";
                chboxSticked.Size = new Size(72, 21);
                chboxSticked.TabIndex = 1;
                chboxSticked.Text = "Sticked";
                chboxSticked.UseVisualStyleBackColor = true;
                bool stickyStatus = bool.Parse(dataTable.Rows[i][7].ToString());
                if (stickyStatus == true)
                {
                    chboxSticked.Checked = true;
                }
                else
                {
                    chboxSticked.Checked = false;
                }
                chboxSticked.CheckedChanged += (s, e) =>
                {
                    int noteId = int.Parse(lblNoteId.Text);
                    if (chboxSticked.Checked)
                    {
                        stickyNotesbll.makeStickyStatus_1(noteId);
                        MainPanel.Controls.Clear();
                        if (displayNoteStatus.Equals("Sticky"))
                        {
                            showStickyNotes(stickyNotesbll.ShowStickyNotes(userId));
                        }
                        else if(displayNoteStatus.Equals("All"))
                        {
                            showStickyNotes(stickyNotesbll.shoAllNote(userId));
                        }
                        else if(displayNoteStatus.Equals("Completed"))
                        {
                            showStickyNotes(stickyNotesbll.showCompleteNotes(userId));
                        }
                    }
                    else if (chboxSticked.Checked == false)
                    {
                        stickyNotesbll.makestickyStatus_0(noteId);
                        MainPanel.Controls.Clear();
                        if (displayNoteStatus.Equals("Sticky"))
                        {
                            showStickyNotes(stickyNotesbll.ShowStickyNotes(userId));
                        }
                        else if (displayNoteStatus.Equals("All"))
                        {
                            showStickyNotes(stickyNotesbll.shoAllNote(userId));
                        }
                        else if (displayNoteStatus.Equals("Completed"))
                        {
                            showStickyNotes(stickyNotesbll.showCompleteNotes(userId));
                        }
                    }
                };
                // chboxCompleted
                CheckBox chboxCompleted = new CheckBox();
                chboxCompleted.AutoSize = true;
                chboxCompleted.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                chboxCompleted.ForeColor = Color.Black;
                chboxCompleted.Location = new Point(35, 90);
                chboxCompleted.Name = "chboxCompleted";
                chboxCompleted.Size = new Size(95, 21);
                chboxCompleted.TabIndex = 2;
                chboxCompleted.Text = "Completed";
                chboxCompleted.UseVisualStyleBackColor = true;
                bool completeStatus = bool.Parse(dataTable.Rows[i][6].ToString());
                if (completeStatus == true)
                {
                    chboxCompleted.Checked = true;
                }
                else
                {
                    chboxCompleted.Checked = false;
                }
                chboxCompleted.CheckedChanged += (s, e) =>
                {
                    int noteId = int.Parse(lblNoteId.Text);
                    if (chboxCompleted.Checked)
                    {
                        stickyNotesbll.completeStickyNote(noteId);
                        MainPanel.Controls.Clear();
                        if (displayNoteStatus.Equals("Sticky"))
                        {
                            showStickyNotes(stickyNotesbll.ShowStickyNotes(userId));
                        }
                        else if (displayNoteStatus.Equals("All"))
                        {
                            showStickyNotes(stickyNotesbll.shoAllNote(userId));
                        }
                        else if (displayNoteStatus.Equals("Completed"))
                        {
                            showStickyNotes(stickyNotesbll.showCompleteNotes(userId));
                        }
                    }
                    else if (chboxCompleted.Checked == false)
                    {
                        stickyNotesbll.inCompleteNote(noteId);
                        MainPanel.Controls.Clear();
                        if (displayNoteStatus.Equals("Sticky"))
                        {
                            showStickyNotes(stickyNotesbll.ShowStickyNotes(userId));
                        }
                        else if (displayNoteStatus.Equals("All"))
                        {
                            showStickyNotes(stickyNotesbll.shoAllNote(userId));
                        }
                        else if (displayNoteStatus.Equals("Completed"))
                        {
                            showStickyNotes(stickyNotesbll.showCompleteNotes(userId));
                        }
                    }
                    
                };

                // lblCategory
                Label lblCategory = new Label();
                lblCategory.AutoSize = true;
                lblCategory.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblCategory.Location = new Point(370, 11);
                lblCategory.Name = "lblCategory";
                lblCategory.Size = new Size(70, 17);
                lblCategory.TabIndex = 6;
                lblCategory.Text = "Category :";

                //selected category text
                TextBox txtcategoy = new TextBox();
                txtcategoy.Location = new Point(750, 11);
                txtcategoy.Name = "txtTitle";
                txtcategoy.Size = new Size(110, 20);
                txtcategoy.TabIndex = 7;
                txtcategoy.ReadOnly = true;

                // cmbCategory
                ComboBox cmbCategory = new ComboBox();
                cmbCategory.FormattingEnabled = true;
                cmbCategory.Location = new Point(450, 9);
                cmbCategory.Name = "cmbCategory";
                cmbCategory.Size = new Size(154, 21);
                cmbCategory.TabIndex = 8;
                cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

                DataTable dt = stickyNotesbll.fillCombobox(userId);
                cmbCategory.DataSource = dt;
                cmbCategory.DisplayMember = "categoryName";
                cmbCategory.ValueMember = "categoryId";
                cmbCategory.SelectedIndexChanged += (s, e) =>
                {
                    int noteId = int.Parse(lblNoteId.Text);
                    for (int j = 1; j <= cmbCategory.SelectedIndex; j++)
                    {
                        if (dt.Rows.Count > 1)
                        {
                            txtcategoy.Text = Convert.ToString(dt.Rows[j]["categoryName"]);
                            stickyNotesbll.updateNoteCategory(noteId, cmbCategory.Text);
                        }

                    }
                    
                };

                //selected category
                Label lblSelectedCategory = new Label();
                lblSelectedCategory.AutoSize = true;
                lblSelectedCategory.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblSelectedCategory.Location = new Point(610, 11);
                lblSelectedCategory.Name = "lblSelectedCategory";
                lblSelectedCategory.Size = new Size(70, 17);
                lblSelectedCategory.TabIndex = 6;
                lblSelectedCategory.Text = "Selected Category :";


                // lblTitle
                Label lblTitle = new Label();
                lblTitle.AutoSize = true;
                lblTitle.Font = new Font("Century Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, ((byte)(0)));
                lblTitle.Location = new Point(200, 11);
                lblTitle.Name = "lblTitle";
                lblTitle.Size = new Size(38, 17);
                lblTitle.TabIndex = 5;
                lblTitle.Text = "Title :";

                lblNoteId.Text = dataTable.Rows[i][0].ToString();
                txtTitle.Text = dataTable.Rows[i][2].ToString();
                txtcategoy.Text = dataTable.Rows[i][3].ToString();
                lblNoteDate.Text = dataTable.Rows[i][4].ToString();
                txtContent.Text = dataTable.Rows[i][5].ToString();

                // btnDelete
                Button btnDelete = new Button();
                btnDelete.BackgroundImage = global::Mohammad_StickyNote.Properties.Resources.delete;
                btnDelete.BackgroundImageLayout = ImageLayout.Zoom;
                btnDelete.Location = new Point(35, 10);
                btnDelete.Name = "btnDelete";
                btnDelete.Size = new Size(32, 33);
                btnDelete.TabIndex = 1;
                btnDelete.UseVisualStyleBackColor = true;
                btnDelete.Click += (s, a) =>
                {
                    int noteId = int.Parse(lblNoteId.Text);
                    if (MessageBox.Show("Confirm Delete ?", "Delete", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        stickyNotesbll.deleteStickyNote(noteId);
                        MessageBox.Show("Deleted");
                        MainPanel.Controls.Clear();
                        showStickyNotes(stickyNotesbll.ShowStickyNotes(userId));
                    }
                };

                //notePanel
                Panel NotePanel = new Panel();
                NotePanel.BackColor = Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(196)))), ((int)(((byte)(232)))));
                NotePanel.Controls.Add(lblNoteDate);
                NotePanel.Controls.Add(cmbCategory);
                NotePanel.Controls.Add(txtTitle);
                NotePanel.Controls.Add(lblCategory);
                NotePanel.Controls.Add(lblTitle);
                NotePanel.Controls.Add(lblDateCreate);
                NotePanel.Controls.Add(chboxCompleted);
                NotePanel.Controls.Add(lblNoteId);
                NotePanel.Controls.Add(btnDelete);
                NotePanel.Controls.Add(chboxSticked);
                NotePanel.Controls.Add(txtContent);
                NotePanel.Controls.Add(lblSelectedCategory);
                NotePanel.Controls.Add(txtcategoy);
                NotePanel.Location = new Point(x_axis, y_axis);
                NotePanel.Name = "NotePanel";
                NotePanel.Size = new Size(width, 120);
                NotePanel.TabIndex = 0;
                MainPanel.Controls.Add(NotePanel);
                if (NotePanel.Width >= width)
                {
                    x_axis = 10;
                    y_axis = y_axis + NotePanel.Height + 10;
                }
                
            }
           
          }
        private void StickyNotes_Load(object sender, EventArgs e)
        {
            //Getting userid  by username
            addCategoryBLL getUserIdByUserName = new addCategoryBLL();
            DataTable dt = getUserIdByUserName.getUserId(username);
            userId = int.Parse(dt.Rows[0][0].ToString());
            
            DataTable dataTable = stickyNotesbll.ShowStickyNotes(userId);
                showStickyNotes(dataTable);
        }

        private void linkShowCompleteNote_Click(object sender, EventArgs e)
        {
            displayNoteStatus = "Completed";
            MainPanel.Controls.Clear();
            showStickyNotes(stickyNotesbll.showCompleteNotes(userId));
        }

        private void accountSetting_Click(object sender, EventArgs e)
        {
            AccountSetting acs = new AccountSetting(username);
            acs.ShowDialog();
        }

        private void linkShowCharts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            StickyNoteCharts chart = new StickyNoteCharts(username);
            chart.ShowDialog();
        }

        private void lblAllNote_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            displayNoteStatus = "All";
            MainPanel.Controls.Clear();
            showStickyNotes(stickyNotesbll.shoAllNote(userId));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MainPanel.Controls.Clear();
            showStickyNotes(stickyNotesbll.searchStickyNotes(userId, txtSearch.Text, displayNoteStatus));
        }
    }
}