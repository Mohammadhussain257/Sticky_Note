namespace Mohammad_StickyNote
{
    partial class StickyNotes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topPanel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.leftPanel = new System.Windows.Forms.Panel();
            this.rectangleShape1 = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.gradientPanel1 = new Mohammad_StickyNote.GradientPanel();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblAllNote = new System.Windows.Forms.LinkLabel();
            this.linkShowCharts = new System.Windows.Forms.LinkLabel();
            this.accountSetting = new System.Windows.Forms.LinkLabel();
            this.singOut = new System.Windows.Forms.LinkLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.linkShowCompleteNote = new System.Windows.Forms.LinkLabel();
            this.addCategory = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.createNote = new System.Windows.Forms.LinkLabel();
            this.lblUser = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.topPanel.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.gradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPanel
            // 
            this.topPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(30)))), ((int)(((byte)(81)))));
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Controls.Add(this.btnClose);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(882, 28);
            this.topPanel.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 22);
            this.label1.TabIndex = 8;
            this.label1.Text = "Sticky Note";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(849, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(33, 28);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // leftPanel
            // 
            this.leftPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(152)))), ((int)(((byte)(158)))));
            this.leftPanel.Controls.Add(this.gradientPanel1);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 28);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(213, 517);
            this.leftPanel.TabIndex = 1;
            // 
            // rectangleShape1
            // 
            this.rectangleShape1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.rectangleShape1.BackColor = System.Drawing.Color.Transparent;
            this.rectangleShape1.BackgroundImage = global::Mohammad_StickyNote.Properties.Resources.note_logo;
            this.rectangleShape1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.rectangleShape1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rectangleShape1.BorderWidth = 2;
            this.rectangleShape1.CornerRadius = 10;
            this.rectangleShape1.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Central;
            this.rectangleShape1.Location = new System.Drawing.Point(23, 3);
            this.rectangleShape1.Name = "rectangleShape1";
            this.rectangleShape1.Size = new System.Drawing.Size(104, 94);
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(233)))), ((int)(((byte)(173)))));
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(213, 28);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(669, 517);
            this.MainPanel.TabIndex = 2;
            // 
            // gradientPanel1
            // 
            this.gradientPanel1.ColorBottom = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(196)))), ((int)(((byte)(232)))));
            this.gradientPanel1.ColorTop = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(54)))), ((int)(((byte)(109)))));
            this.gradientPanel1.Controls.Add(this.txtSearch);
            this.gradientPanel1.Controls.Add(this.btnSearch);
            this.gradientPanel1.Controls.Add(this.lblAllNote);
            this.gradientPanel1.Controls.Add(this.linkShowCharts);
            this.gradientPanel1.Controls.Add(this.accountSetting);
            this.gradientPanel1.Controls.Add(this.singOut);
            this.gradientPanel1.Controls.Add(this.label2);
            this.gradientPanel1.Controls.Add(this.linkShowCompleteNote);
            this.gradientPanel1.Controls.Add(this.addCategory);
            this.gradientPanel1.Controls.Add(this.label4);
            this.gradientPanel1.Controls.Add(this.createNote);
            this.gradientPanel1.Controls.Add(this.lblUser);
            this.gradientPanel1.Controls.Add(this.label3);
            this.gradientPanel1.Controls.Add(this.shapeContainer1);
            this.gradientPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gradientPanel1.Name = "gradientPanel1";
            this.gradientPanel1.Size = new System.Drawing.Size(213, 517);
            this.gradientPanel1.TabIndex = 13;
            // 
            // txtSearch
            // 
            this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearch.Location = new System.Drawing.Point(11, 213);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(180, 20);
            this.txtSearch.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Silver;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.Black;
            this.btnSearch.Location = new System.Drawing.Point(43, 246);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(108, 26);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblAllNote
            // 
            this.lblAllNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblAllNote.AutoSize = true;
            this.lblAllNote.BackColor = System.Drawing.Color.Transparent;
            this.lblAllNote.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllNote.ForeColor = System.Drawing.Color.White;
            this.lblAllNote.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblAllNote.LinkColor = System.Drawing.Color.White;
            this.lblAllNote.Location = new System.Drawing.Point(15, 323);
            this.lblAllNote.Name = "lblAllNote";
            this.lblAllNote.Size = new System.Drawing.Size(118, 21);
            this.lblAllNote.TabIndex = 13;
            this.lblAllNote.TabStop = true;
            this.lblAllNote.Text = "Show All Note";
            this.lblAllNote.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblAllNote_LinkClicked);
            // 
            // linkShowCharts
            // 
            this.linkShowCharts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkShowCharts.AutoSize = true;
            this.linkShowCharts.BackColor = System.Drawing.Color.Transparent;
            this.linkShowCharts.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkShowCharts.ForeColor = System.Drawing.Color.White;
            this.linkShowCharts.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkShowCharts.LinkColor = System.Drawing.Color.White;
            this.linkShowCharts.Location = new System.Drawing.Point(15, 352);
            this.linkShowCharts.Name = "linkShowCharts";
            this.linkShowCharts.Size = new System.Drawing.Size(102, 21);
            this.linkShowCharts.TabIndex = 12;
            this.linkShowCharts.TabStop = true;
            this.linkShowCharts.Text = "Note Status";
            this.linkShowCharts.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkShowCharts_LinkClicked);
            // 
            // accountSetting
            // 
            this.accountSetting.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountSetting.AutoSize = true;
            this.accountSetting.BackColor = System.Drawing.Color.Transparent;
            this.accountSetting.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accountSetting.ForeColor = System.Drawing.Color.White;
            this.accountSetting.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.accountSetting.LinkColor = System.Drawing.Color.White;
            this.accountSetting.Location = new System.Drawing.Point(15, 445);
            this.accountSetting.Name = "accountSetting";
            this.accountSetting.Size = new System.Drawing.Size(140, 21);
            this.accountSetting.TabIndex = 7;
            this.accountSetting.TabStop = true;
            this.accountSetting.Text = "Account Setting";
            this.accountSetting.Click += new System.EventHandler(this.accountSetting_Click);
            // 
            // singOut
            // 
            this.singOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.singOut.AutoSize = true;
            this.singOut.BackColor = System.Drawing.Color.Transparent;
            this.singOut.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singOut.ForeColor = System.Drawing.Color.White;
            this.singOut.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.singOut.LinkColor = System.Drawing.Color.White;
            this.singOut.Location = new System.Drawing.Point(16, 479);
            this.singOut.Name = "singOut";
            this.singOut.Size = new System.Drawing.Size(77, 21);
            this.singOut.TabIndex = 3;
            this.singOut.TabStop = true;
            this.singOut.Text = "Sign Out";
            this.singOut.Click += new System.EventHandler(this.singOut_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(41, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name";
            // 
            // linkShowCompleteNote
            // 
            this.linkShowCompleteNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linkShowCompleteNote.AutoSize = true;
            this.linkShowCompleteNote.BackColor = System.Drawing.Color.Transparent;
            this.linkShowCompleteNote.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkShowCompleteNote.ForeColor = System.Drawing.Color.White;
            this.linkShowCompleteNote.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkShowCompleteNote.LinkColor = System.Drawing.Color.White;
            this.linkShowCompleteNote.Location = new System.Drawing.Point(15, 289);
            this.linkShowCompleteNote.Name = "linkShowCompleteNote";
            this.linkShowCompleteNote.Size = new System.Drawing.Size(178, 21);
            this.linkShowCompleteNote.TabIndex = 10;
            this.linkShowCompleteNote.TabStop = true;
            this.linkShowCompleteNote.Text = "Show Complete Note";
            this.linkShowCompleteNote.Click += new System.EventHandler(this.linkShowCompleteNote_Click);
            // 
            // addCategory
            // 
            this.addCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addCategory.AutoSize = true;
            this.addCategory.BackColor = System.Drawing.Color.Transparent;
            this.addCategory.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addCategory.ForeColor = System.Drawing.Color.White;
            this.addCategory.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.addCategory.LinkColor = System.Drawing.Color.White;
            this.addCategory.Location = new System.Drawing.Point(16, 413);
            this.addCategory.Name = "addCategory";
            this.addCategory.Size = new System.Drawing.Size(124, 21);
            this.addCategory.TabIndex = 5;
            this.addCategory.TabStop = true;
            this.addCategory.Text = "Add Category";
            this.addCategory.Click += new System.EventHandler(this.addCategory_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(66, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "By Title";
            // 
            // createNote
            // 
            this.createNote.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createNote.AutoSize = true;
            this.createNote.BackColor = System.Drawing.Color.Transparent;
            this.createNote.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNote.ForeColor = System.Drawing.Color.White;
            this.createNote.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.createNote.LinkColor = System.Drawing.Color.White;
            this.createNote.Location = new System.Drawing.Point(15, 382);
            this.createNote.Name = "createNote";
            this.createNote.Size = new System.Drawing.Size(109, 21);
            this.createNote.TabIndex = 4;
            this.createNote.TabStop = true;
            this.createNote.Text = "Create Note";
            this.createNote.Click += new System.EventHandler(this.createNote_Click);
            // 
            // lblUser
            // 
            this.lblUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.Color.White;
            this.lblUser.Location = new System.Drawing.Point(42, 139);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(38, 21);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Null";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 8;
            this.label3.Text = "Search Note";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.rectangleShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(213, 517);
            this.shapeContainer1.TabIndex = 16;
            this.shapeContainer1.TabStop = false;
            // 
            // StickyNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 545);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.topPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StickyNotes";
            this.Text = "StickyNotes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.StickyNotes_Load);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.gradientPanel1.ResumeLayout(false);
            this.gradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.LinkLabel accountSetting;
        private System.Windows.Forms.LinkLabel addCategory;
        private System.Windows.Forms.LinkLabel createNote;
        private System.Windows.Forms.LinkLabel singOut;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel linkShowCompleteNote;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.LinkLabel linkShowCharts;
        private GradientPanel gradientPanel1;
        private System.Windows.Forms.LinkLabel lblAllNote;
        private System.Windows.Forms.Button btnSearch;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.RectangleShape rectangleShape1;
    }
}