using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace ADB_Project
{

    public class Authentication
    {
        DataBase mydb;
        public Authentication(string dB)
        {
            mydb = new DataBase(dB);
            play();
        }
        private void play()
        {
            mydb.OpenCon();
        }
        public bool Auth_UserN(string Tname, string Uname)
        {
            string query = "select * from " + Tname + " where BINARY name = \"" + Uname + "\";";
            try
            {
                DataSet ds = mydb.Query(query);
                if (ds.Tables[0].Rows.Count == 0 || ds == null)
                {
                    mydb.CloseCon();
                    return false;
                }
            }
            catch (Exception ex)
            {
                mydb.CloseCon();
                return false;
            }
            mydb.CloseCon();
            return true;
        }
        public bool MatchUsernameWithPassword(string Tname, string Uname, string Pass)
        {
            string query = "SELECT * FROM " + Tname + " where BINARY UserName = \"" + Uname + "\" and BINARY Password = \"" + Pass + "\";";
            try
            {
                DataSet ds = mydb.Query(query);
                if (ds.Tables[0].Rows.Count == 0 || ds == null)
                {
                    mydb.CloseCon();
                    return false;
                }
            }
            catch (Exception ex)
            {
                mydb.CloseCon();
                return false;
            }
            mydb.CloseCon();
            return true;
        }
    }
}