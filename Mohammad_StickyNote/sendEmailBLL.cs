using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohammad_StickyNote
{
    public class sendEmailBLL
    {
        private string email;

        public string _email
        {
            get { return email; }
            set { email = value; }
        }
        DbConnection connection = new DbConnection();
        public bool checkEmail()
        {
            string sql = "select email from Users where email='" + email + "'";
            DataTable dt = connection.retrieveInfo(sql);
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
