using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohammad_StickyNote
{
   public class AccountSettingbll : DbConnection
    {
        public DataTable accountSetting(int userId)
        {
           string sql = "select firstName,lastName,gender,dob,email,userName,"+
                "userPassword,confirmPassword from Users where userId=" + userId;
           DataTable dt=retrieveInfo(sql);
           return dt;  
        }

        public void updateAccountSetting(int userId,string fname,string lname,string gender,
            string dob,string email,string userName,string password,string confirmpass)
        {
            string sql = "update Users set firstName='"+fname+"',lastName='"+lname+"'"+
                ",gender='"+gender+"',dob='"+dob+"',email='"+email+"',userName='"+userName+"'"+
                ",userPassword='"+password+"',confirmPassword='"+confirmpass+"' where userId=" + userId;
            manipulateInfo(sql);
        }

        public int countUpdateAccount()
        {
            DataTable data = null;
            string sql = "select COUNT(userId) from Users";
            try
            {
                data = retrieveInfo(sql);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            return int.Parse(data.Rows[0][0].ToString());
        }
    }
}
