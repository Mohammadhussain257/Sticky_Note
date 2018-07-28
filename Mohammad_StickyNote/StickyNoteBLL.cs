using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohammad_StickyNote
{
    public class StickyNoteBLL : DbConnection
    {
        public DataTable ShowStickyNotes(int userId)
        {
            string sql = "select noteId,userId,noteTitle,noteCategory,noteDate,noteContent,noteCompleteStatus,noteStickyStatux"
                +" from stickyNote where userId="+userId+ " and noteStickyStatux=1 ORDER BY noteDate DESC";
            DataTable dt = retrieveInfo(sql);
            return dt;
        }
        public DataTable shoAllNote(int userId)
        {
            string sql = "select noteId,userId,noteTitle,noteCategory,noteDate,noteContent,noteCompleteStatus,noteStickyStatux"
                +" from stickyNote where userId=" + userId+ "ORDER BY noteDate DESC";
            DataTable dt = retrieveInfo(sql);
            return dt;
        }
        public void completeStickyNote(int noteId)
        {
            string sql = "update stickyNote set noteCompleteStatus=1 where noteId=" + noteId;
            manipulateInfo(sql);
        }

        public int countComplete_Sticky_Note_()
        {
            DataTable data = null;
            string sql = "select COUNT(noteId) from stickyNote";
            data = retrieveInfo(sql);
            return int.Parse(data.Rows[0][0].ToString());
        }

        public void makestickyStatus_0(int noteId)
        {
            string sql = "update stickyNote set noteStickyStatux=0 where noteId=" + noteId;
            manipulateInfo(sql);
        }
        public void makeStickyStatus_1(int noteId)
        {
            string sql = "update stickyNote set noteStickyStatux=1 where noteId=" + noteId;
            manipulateInfo(sql);
        }

        public void inCompleteNote(int noteId)
        {
            string sql = "update stickyNote set noteCompleteStatus=0 where noteId=" + noteId;
            manipulateInfo(sql);
        }
        public void deleteStickyNote(int noteId)
        {
            string sql = "delete from stickyNote where noteId="+noteId;
            manipulateInfo(sql);
        }
        public DataTable showCompleteNotes(int userId)
        {
            string sql = "select noteId,userId,noteTitle,noteCategory,noteDate,noteContent,noteCompleteStatus,noteStickyStatux"
                +" from stickyNote where userId = "+userId+ " and noteCompleteStatus = 1 ORDER BY noteDate DESC";
            DataTable dt = retrieveInfo(sql);
            return dt;
        }

        public void updateNoteContent(int noteId,string noteContent)
        {
            string sql = "update stickyNote set noteContent='"+ noteContent+"' where noteId=" + noteId;
            manipulateInfo(sql);
        }

        public void updateNoteTitle(int noteId, string noteTitle)
        {
            string sql = "update stickyNote set noteTitle='" + noteTitle + "' where noteId=" + noteId;
            manipulateInfo(sql);
        }

        public void updateNoteCategory(int noteId, string noteCategory)
        {
            string sql = "update stickyNote set noteCategory='" + noteCategory + "' where noteId=" + noteId;
            manipulateInfo(sql);
        }

        //Fill combobox
        public DataTable fillCombobox(int userId)
        {
            string sql = "select categoryId,categoryName from Category where userId=" + userId+ "";
            DataTable dt = retrieveInfo(sql);
            return dt;
        }

        public DataTable searchStickyNotes(int userId, string title, string displayNotesStatus)
        {
            string sql = null;
            if(displayNotesStatus.Equals("Sticky"))
            {
                sql = "select noteId,userId,noteTitle,noteCategory,noteDate,noteContent,noteCompleteStatus,noteStickyStatux"
                    +" from stickyNote where userId=" + userId + " and noteStickyStatux=1 and noteTitle='" + title + "'";
            }
            else if (displayNotesStatus.Equals("All"))
            {
                sql = "select noteId,userId,noteTitle,noteCategory,noteDate,noteContent,noteCompleteStatus,noteStickyStatux"
                    +" from stickyNote where userId=" + userId + " and noteTitle='" + title + "'";
            }
            else if (displayNotesStatus.Equals("Completed"))
            {
                sql = "select noteId,userId,noteTitle,noteCategory,noteDate,noteContent,noteCompleteStatus,noteStickyStatux"
                    +" from stickyNote where userId=" + userId + " and noteCompleteStatus = 1 and noteTitle='" + title + "'";
            }

            DataTable dt = retrieveInfo(sql);
            return dt;
        }

    }
}
