using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohammad_StickyNote
{
    public class ResetAccountBLL : DbConnection
    {
        private string newUsername;
        private string newPassword;
        private string confirmPassword;

        public string _newUsername
            {
            get { return newUsername; }
            set { newUsername = value; }
            }
        public string _newPassword
        {
            get { return newPassword; }
            set { newPassword = value; }
        }

        public string _confirmPassword
        {
            get { return confirmPassword; }
            set { confirmPassword = value; }
        }
        public void resetAccount(String email)
        {
            string sql = "update Users set userName='"+newUsername+"',userPassword='"+newPassword+"',confirmPassword='"+confirmPassword+"' where email='"+email+"'";
            manipulateInfo(sql);
        }

        public int countReset_account()
        {
            DataTable data = null;
            string sql = "select COUNT(email) from Users";
            data = retrieveInfo(sql);
            return int.Parse(data.Rows[0][0].ToString());
        }
    }
}
