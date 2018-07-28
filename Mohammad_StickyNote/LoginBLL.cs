using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohammad_StickyNote
{
  public  class LoginBLL : DbConnection
    {
        private string username;
        private string password;

        public string _username
            {
            get { return username; }
            set { username = value; }
            }
        public string _password
        {
            get { return password; }
            set { password = value; }
        }
  
        public bool CheckUser()
        {
            string sql = "select userName,userPassword from Users where userName='" + username+ "'and userPassword='" + password+"'";
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
    }
}
