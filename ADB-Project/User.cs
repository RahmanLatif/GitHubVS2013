using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADB_Project
{
    public class User
    {
        public string username;
        public string password;
        public string UserType;
        public User(string usr, string pass, string UserType)
        {
            this.username = usr;
            this.password = pass;
            this.UserType = UserType;
        }
        public bool Login()
        {
            Authentication auth = new Authentication("adb");
            bool ret = auth.MatchUsernameWithPassword("user", username, password);
            if (ret)
            {
                DataBase db = new DataBase("adb");
                db.OpenCon();
                string query = "select * from user where binary UserName = \"" + username + "\" and binary Password = \"" + password + "\";";
                DataSet ds = db.Query(query);
                string Ut = ds.Tables[0].Rows[0][1].ToString();
                db.CloseCon();
                if (Ut != this.UserType)
                    return false;
            }
            return ret;
        }
        public DataSet GetInfo(int pid)
        {
            DataBase db = new DataBase("adb");
            db.OpenCon();
            string query = "select * from patient where binary PatientId = \"" + pid + "\";";
            DataSet ds = db.Query(query);
            db.CloseCon();
            return ds;
        }
    }
}
