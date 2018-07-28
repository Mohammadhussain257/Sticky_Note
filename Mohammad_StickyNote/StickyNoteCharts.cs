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
    public partial class StickyNoteCharts : Form
    {

        string username;
        int userId;
        public StickyNoteCharts(string username)
        {
            InitializeComponent();
            CenterToScreen();
            this.username = username;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Hide();
            StickyNotes stickyNote = new StickyNotes(username);
            stickyNote.ShowDialog();
            this.Close();
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

        private void StickyNoteCharts_Load(object sender, EventArgs e)
        {
            //Getting userid  by username
            addCategoryBLL getUserIdByUserName = new addCategoryBLL();
            DataTable dt = getUserIdByUserName.getUserId(username);
            userId = int.Parse(dt.Rows[0][0].ToString());
            StickyChartBLL stickychartbll = new StickyChartBLL();

            float completeNote, incompleteNote, allNote;

            //show data for today note
            completeNote = (float)stickychartbll.todayNoteCharts("completeNote", DateTime.Now.ToString(), userId);
            incompleteNote = (float)stickychartbll.todayNoteCharts("incompleteNote", DateTime.Now.ToString(),userId);
            allNote = (float)stickychartbll.todayNoteCharts("allNote", DateTime.Now.ToString(), userId);
            todayNote_chart(completeNote, incompleteNote);

            //show note data of one week
            completeNote = (float)stickychartbll.weekNoteCharts("completeNote", DateTime.Now.AddDays(-7).ToString(),DateTime.Now.ToString(),userId);
            incompleteNote = (float)stickychartbll.weekNoteCharts("incompleteNote",DateTime.Now.AddDays(-7).ToString(),DateTime.Now.ToString(),userId);
            allNote = (float)stickychartbll.weekNoteCharts("allNote",DateTime.Now.AddDays(-7).ToString(),DateTime.Now.ToString(),userId);
            weekNote_chart(completeNote, incompleteNote);

            //show note data of one month
            completeNote = (float)stickychartbll.monthNoteCharts("completeNote", DateTime.Now.AddDays(-1).ToString(), DateTime.Now.ToString(), userId);
            incompleteNote = (float)stickychartbll.monthNoteCharts("incompleteNote", DateTime.Now.AddDays(-1).ToString(), DateTime.Now.ToString(), userId);
            allNote = (float)stickychartbll.monthNoteCharts("allNote", DateTime.Now.AddDays(-1).ToString(), DateTime.Now.ToString(), userId);
            monthNote_chart(completeNote, incompleteNote);

            //show note data of one year
            completeNote = (float)stickychartbll.yearNoteCharts("completeNote", DateTime.Now.AddDays(-1).ToString(), DateTime.Now.ToString(), userId);
            incompleteNote = (float)stickychartbll.yearNoteCharts("incompleteNote", DateTime.Now.AddDays(-1).ToString(), DateTime.Now.ToString(), userId);
            allNote = (float)stickychartbll.yearNoteCharts("allNote", DateTime.Now.AddDays(-1).ToString(), DateTime.Now.ToString(), userId);
            yearNote_chart(completeNote, incompleteNote);
        }

        private void todayNote_chart(float todayCompleteNote, float todayIncompleteNote)
        {
            if (todayCompleteNote > 0 && todayIncompleteNote > 0)
            {
                DaysChart.Series["Today Note Series"].Points.AddXY("Complete", todayCompleteNote);
                DaysChart.Series["Today Note Series"].Points.AddXY("Incomplete", todayIncompleteNote);
                lbltodayNoteCompleted.Text = string.Format("{0:0.0}", todayCompleteNote) + "%";
                lbltodayNoteIncomplete.Text = string.Format("{0:0.0}", todayIncompleteNote) + "%";
            }
            else if (todayCompleteNote > 0 && todayIncompleteNote <= 0)
            {
                DaysChart.Series["Today Note Series"].Points.AddXY("Complete", todayCompleteNote);
                lbltodayNoteCompleted.Text = string.Format("{0:0.0}", todayIncompleteNote) + "%";
                lbltodayNoteIncomplete.Visible = false;
            }
            else if (todayCompleteNote <= 0 && todayIncompleteNote > 0)
            {
                DaysChart.Series["Today Note Series"].Points.AddXY("Incomplete", todayIncompleteNote);
                lbltodayNoteIncomplete.Text = string.Format("{0:0.0}", todayIncompleteNote) + "%";
                lbltodayNoteCompleted.Visible = false;
            }
            else
            {
                DaysChart.Series["Today Note Series"].Points.AddXY("No Data", 0);
                lbltodayNoteCompleted.Visible = false;
                lbltodayNoteIncomplete.Visible = false;
            }
        }
        private void weekNote_chart(float weekCompleteNote, float weekIncompleteNote)
        {
            if (weekCompleteNote > 0 && weekIncompleteNote > 0)
            {
                weekCharts.Series["Week Note Series"].Points.AddXY("Complete", weekCompleteNote);
                weekCharts.Series["Week Note Series"].Points.AddXY("Incomplete", weekIncompleteNote);
                lblWeekCompleteNote.Text = string.Format("{0:0.0}", weekCompleteNote) + "%";
                lblWeekIncompleteNote.Text = string.Format("{0:0.0}", weekIncompleteNote) + "%";
            }
            else if (weekCompleteNote > 0 && weekIncompleteNote <= 0)
            {
                weekCharts.Series["Week Note Series"].Points.AddXY("Complete", weekCompleteNote);
                lblWeekCompleteNote.Text = string.Format("{0:0.0}", weekCompleteNote) + "%";
                lblWeekIncompleteNote.Visible = false;
            }
            else if (weekCompleteNote <= 0 && weekIncompleteNote > 0)
            {
                weekCharts.Series["Week Note Series"].Points.AddXY("Incomplete", weekIncompleteNote);
                lblWeekIncompleteNote.Text = string.Format("{0:0.0}", weekCompleteNote) + "%";
                lblWeekCompleteNote.Visible = false;
            }
            else
            {
                weekCharts.Series["Week Note Series"].Points.AddXY("No Data", 0);
                lblWeekCompleteNote.Visible = false;
                lblWeekIncompleteNote.Visible = false;
            }
        }
        private void monthNote_chart(float monthCompleteNote, float monthIncompleteNote)
        {
            if (monthCompleteNote > 0 && monthIncompleteNote > 0)
            {
                monthsChart.Series["Month Note Series"].Points.AddXY("Complete", monthCompleteNote);
                monthsChart.Series["Month Note Series"].Points.AddXY("Incomplete", monthIncompleteNote);
                lblMonthCompleteNote.Text = string.Format("{0:0.0}", monthCompleteNote) + "%";
                lblMonthIncompleteNote.Text = string.Format("{0:0.0}", monthIncompleteNote) + "%";
            }
            else if (monthCompleteNote > 0 && monthIncompleteNote <= 0)
            {
                monthsChart.Series["Month Note Series"].Points.AddXY("Complete", monthCompleteNote);
                lblMonthCompleteNote.Text = string.Format("{0:0.0}", monthCompleteNote) + "%";
                lblMonthIncompleteNote.Visible = false;
            }
            else if (monthCompleteNote <= 0 && monthIncompleteNote > 0)
            {
                monthsChart.Series["Month Note Series"].Points.AddXY("Incomplete", monthIncompleteNote);
                lblMonthIncompleteNote.Text = string.Format("{0:0.0}", monthIncompleteNote) + "%";
                lblMonthCompleteNote.Visible = false;
            }
            else
            {
                monthsChart.Series["Month Note Series"].Points.AddXY("No Data", 0);
                lblMonthCompleteNote.Visible = false;
                lblMonthIncompleteNote.Visible = false;
            }
        }
        private void yearNote_chart(float yearCompleteNote, float yearIncompleteNote)
        {
            if (yearCompleteNote > 0 && yearIncompleteNote > 0)
            {
                yearCharts.Series["Year Note Series"].Points.AddXY("Complete", yearCompleteNote);
                yearCharts.Series["Year Note Series"].Points.AddXY("Incomplete", yearIncompleteNote);
                lblYearCompleteNote.Text = string.Format("{0:0.0}", yearCompleteNote) + "%";
                lblYearIncompleteNote.Text = string.Format("{0:0.0}", yearIncompleteNote) + "%";
            }
            else if (yearCompleteNote > 0 && yearIncompleteNote <= 0)
            {
                yearCharts.Series["Year Note_Series"].Points.AddXY("Complete", yearCompleteNote);
                lblYearCompleteNote.Text = string.Format("{0:0.0}", yearCompleteNote) + "%";
                lblYearIncompleteNote.Visible = false;
            }
            else if (yearCompleteNote <= 0 && yearIncompleteNote > 0)
            {
                yearCharts.Series["Year Note Series"].Points.AddXY("Incomplete", yearIncompleteNote);
                lblMonthIncompleteNote.Text = string.Format("{0:0.0}", yearIncompleteNote) + "%";
                lblYearCompleteNote.Visible = false;
            }
            else
            {
                yearCharts.Series["Year Note Series"].Points.AddXY("No Data", 0);
                lblYearCompleteNote.Visible = false;
                lblYearIncompleteNote.Visible = false;
            }
        }
    }
}
