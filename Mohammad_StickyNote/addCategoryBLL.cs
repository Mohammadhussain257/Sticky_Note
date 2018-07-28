using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohammad_StickyNote
{
   public class addCategoryBLL : DbConnection
    {
        public DataTable getUserId(string username)
        {
            string sql = "select userId from Users where userName='" + username + "'";
            DataTable dt = retrieveInfo(sql);
            return dt;
        }
        public DataTable showCategory(int userId)
        {
            string sql = "select categoryId,categoryName from Category where  userId=" + userId;
            DataTable dt = retrieveInfo(sql);
            return dt;
        }
        public DataTable EditCategory(int categoryid)
        {
            string sql = "select categoryName from Category where categoryId=" + categoryid;
            DataTable dt = retrieveInfo(sql);
            return dt;
        }
        public void deleteCategory(int categoryid)
        {
            string sql = "delete from Category where categoryId=" + categoryid;
            manipulateInfo(sql);
        }
        public void updateCategory(int categoryid,string categoryName)
        {
            string sql = "update Category set categoryName='" + categoryName + "' where categoryId=" + categoryid;
        }
        public bool checkCategory(int userId,string categoryName)
        {
            string sql = "select userId,categoryName from category where categoryName='"+categoryName+"'and userId="+userId;
            DataTable dt = retrieveInfo(sql);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void addCetegory(int userId, string categoryName)
        {
            string sql = "insert into Category(userId,categoryName)values( "+userId+",'"+categoryName+"')";
            manipulateInfo(sql);
        }

        public int countAddCategory()
        {
            DataTable data = null;
            string sql = "select COUNT(categoryId) from Category";
            try
            {
                data = retrieveInfo(sql);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine(ex);
            }
           
            return int.Parse(data.Rows[0][0].ToString());
        }
    }
}
