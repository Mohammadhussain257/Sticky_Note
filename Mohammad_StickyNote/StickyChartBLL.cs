using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace Mohammad_StickyNote
{
    class StickyChartBLL : DbConnection
    {
        public int todayNoteCharts(string countNotesStatus, string todayDate,int userId)
        {
            string sql = null;
            if (countNotesStatus == "completeNote")
            {
                sql = "select count(noteId) from stickyNote where noteDate='" + todayDate + "'and noteCompleteStatus=1"+
                    "and userId="+userId;
            }
            else if (countNotesStatus == "incompleteNote")
            {
                sql = "select count(noteId) from stickyNote where noteDate='" + todayDate + "'and noteCompleteStatus=0" +
                "and userId="+userId;
            }
            else if (countNotesStatus == "allNote")
            {
                sql = "select count(noteId) from stickyNote where noteDate='" + todayDate + "'and userId=" + userId ;
            }
            DataTable dt = null;
            dt = retrieveInfo(sql);
           return int.Parse(dt.Rows[0][0].ToString()); 
        }

        public int weekNoteCharts(string countNotesStatus, string todayDate,string weekendDate, int userId)
        {
            string sql = null;
            if (countNotesStatus == "completeNote")
            {
                sql = "select count(noteId) from stickyNote where noteDate between'"+todayDate+"'and '"+weekendDate+"'"+
                    "and noteCompleteStatus=1 and userId="+userId;
            }
            else if (countNotesStatus == "incompleteNote")
            {
                sql = "select count(noteId) from stickyNote where noteDate between'" + todayDate + "'and '" + weekendDate + "'" +
                   "and userId=" + userId;
            }
            else if (countNotesStatus == "allNote")
            {
                sql = "select count(noteId) from stickyNote where noteDate between'" + todayDate + "'and '" + weekendDate + "'" +
                    "and noteCompleteStatus=1 and userId=" + userId;
            }
            DataTable dt = null;
            dt = retrieveInfo(sql);
            return int.Parse(dt.Rows[0][0].ToString());
        }

        public int monthNoteCharts(string countNotesStatus, string todayDate,string endOfMonthDate, int userId)
        {
            string sql = null;
            if (countNotesStatus == "completeNote")
            {
                sql = "select count(noteId) from stickyNote where noteDate between'" + todayDate + "'and '" + endOfMonthDate + "'" +
                    "and noteCompleteStatus=1 and userId=" + userId;
            }
            else if (countNotesStatus == "incompleteNote")
            {
                sql = "select count(noteId) from stickyNote where noteDate between'" + todayDate + "'and '" + endOfMonthDate + "'" +
                   "and userId=" + userId;
            }
            else if (countNotesStatus == "allNote")
            {
                sql = "select count(noteId) from stickyNote where noteDate between'" + todayDate + "'and '" + endOfMonthDate + "'" +
                    "and noteCompleteStatus=1 and userId=" + userId;
            }
            DataTable dt = null;
            dt = retrieveInfo(sql);
            return int.Parse(dt.Rows[0][0].ToString());
        }

        public int yearNoteCharts(string countNotesStatus, string todayDate,string endOfYearDate, int userId)
        {
            string sql = null;
            if (countNotesStatus == "completeNote")
            {
                sql = "select count(noteId) from stickyNote where noteDate between'" + todayDate + "'and '" + endOfYearDate + "'" +
                    "and noteCompleteStatus=1 and userId=" + userId;
            }
            else if (countNotesStatus == "incompleteNote")
            {
                sql = "select count(noteId) from stickyNote where noteDate between'" + todayDate + "'and '" + endOfYearDate + "'" +
                   "and userId=" + userId;
            }
            else if (countNotesStatus == "allNote")
            {
                sql = "select count(noteId) from stickyNote where noteDate between'" + todayDate + "'and '" + endOfYearDate + "'" +
                    "and noteCompleteStatus=1 and userId=" + userId;
            }
            DataTable dt = null;
            dt = retrieveInfo(sql);
            return int.Parse(dt.Rows[0][0].ToString());
        }
    }
}
