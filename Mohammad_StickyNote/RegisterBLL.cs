using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mohammad_StickyNote
{
   public class RegisterBLL : DbConnection
    {
        private string fname;
        private string lname;
        private string gender;
        private string dob;
        private string email;
        private string username;
        private string password;
        private string confirmpassword;
        public string  _fname
            {
            get { return fname; }
            set { fname=value; }
            }
        public string _lname
        {
            get { return lname; }
            set { lname= value; }
        }
        public string _gender
        {
            get { return gender; }
            set {  gender= value; }
        }
        public string _dob
        {
            get { return dob; }
            set {  dob= value; }
        }

        public string _email
        {
            get { return email; }
            set { email= value; }
        }
        public string _username
        {
            get { return username; }
            set {  username= value; }
        }
        public string _password
        {
            get { return password; }
            set {  password= value; }
        }
        public string _confirmpassword
        {
            get { return confirmpassword; }
            set {  confirmpassword= value; }
        }

        public bool checkRegistration()
        {
            string sql = "select userName from Users where userName='"+username+"'";
            DataTable dt = retrieveInfo(sql);
            if (dt.Rows.Count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void insertUserInfo()
        {
            string sql = "insert into Users(firstName,lastName,gender,dob,email,userName,userPassword,confirmPassword)"+
            "values('" + fname+"','"+lname+"','"+gender+"','"+dob+"','"+email+"','"+username+"','"+password+"','"+confirmpassword+"')";
            manipulateInfo(sql);   
        }

        public int countUser()
        {
            DataTable data = null;
            string sql = "select COUNT(userId) from Users";
            data = retrieveInfo(sql);
            return int.Parse(data.Rows[0][0].ToString());
        }

        public DataTable getUserDetails(string username)
        {
            string sql = "select firstName,lastName,gende,dob,email,userName,userPassword,confirmPassword FROM Users where userName="+username;
            DataTable dt=retrieveInfo(sql);
            return dt;
        }

    }
}
