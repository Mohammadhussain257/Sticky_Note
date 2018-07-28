using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohammad_StickyNote
{
   public class CreateNoteBll : DbConnection
    {
        public DataTable getCategory(int userId)
        {
            string sql = "select categoryId,categoryName from Category where userId="+userId;
            DataTable dt = retrieveInfo(sql);
            return dt;
        }

        public void insertNoteInfo(int userId,int categoryId,string noteTitle,string noteCategory,string noteContent)
        {
            string sql = "insert into stickyNote(userId,categoryId,noteTitle,noteCategory,noteDate,noteContent,noteCompleteStatus,noteStickyStatux)"+
                "values("+userId+","+categoryId+",'"+noteTitle+"','"+noteCategory+"','"+DateTime.Now.ToString()+"','"+noteContent+"',0,1)";
            manipulateInfo(sql);
        }

        public int countNote()
        {
            DataTable data = null;
            string sql = "select COUNT(noteId) from stickyNote";
            data = retrieveInfo(sql);
            return int.Parse(data.Rows[0][0].ToString());
        }
    }
}
