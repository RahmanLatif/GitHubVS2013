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
            string query = "select * from patient where binary PID = \"" + pid + "\";";
            DataSet ds = db.Query(query);
            db.CloseCon();
            return ds;
        }

        public KeyValuePair<bool, string> AddUser(string uname, string pass, string conpass, string utype)
        {
            if (uname == "")
                return new KeyValuePair<bool, string>(false, "Enter A Username !!");
            if (pass == "")
                return new KeyValuePair<bool, string>(false, "Enter A Password !!");
            if (utype == "")
                return new KeyValuePair<bool, string>(false, "Choose A User Type !!");
            if (pass != conpass)
                return new KeyValuePair<bool, string>(false, "Password Don't Match !!");
            Authentication au = new Authentication("adb");
            DataBase db = new DataBase("adb");
            if (au.Auth_UserN("user", uname))
                return new KeyValuePair<bool, string>(false, "This User Existed Before !!");
            db.OpenCon();
            string query = "insert into user (UserName, UserType, Password) values ('" + uname + "','" + utype + "','" + pass + "');";
            bool done = db.NonQuery(query);
            db.CloseCon();
            return new KeyValuePair<bool, string>(true, "User Added.");
        }
        public KeyValuePair<DataSet, MySqlDataAdapter> getComments(int pid)
        {
            DataBase db = new DataBase("adb");
            db.OpenCon();
            string query = "select * from comments where binary PID = \"" + pid + "\";";
            KeyValuePair<DataSet, MySqlDataAdapter> ret = db.Queryupd(query);
            db.CloseCon();
            return ret;
        }
        public KeyValuePair<DataSet, MySqlDataAdapter> GetExamination(int pid)
        {
            DataBase db = new DataBase("adb");
            db.OpenCon();
            string query = "select * from examination where binary PID = \"" + pid + "\";";
            KeyValuePair<DataSet, MySqlDataAdapter> ret = db.Queryupd(query);
            db.CloseCon();
            return ret;
        }
        public KeyValuePair<DataSet, MySqlDataAdapter> GetImageStudies(int pid)
        {
            DataBase db = new DataBase("adb");
            db.OpenCon();
            string query = "select * from imagingstudies where binary PID = \"" + pid + "\";";
            KeyValuePair<DataSet, MySqlDataAdapter> ret = db.Queryupd(query);
            db.CloseCon();
            return ret;
        }
        public KeyValuePair<DataSet, MySqlDataAdapter> GetTemprature(int pid)
        {
            DataBase db = new DataBase("adb");
            db.OpenCon();
            string query = "select * from temperaturechart where binary PID = \"" + pid + "\";";
            KeyValuePair<DataSet, MySqlDataAdapter> ret = db.Queryupd(query);
            db.CloseCon();
            return ret;
        }
        public KeyValuePair<DataSet, MySqlDataAdapter> GetCoagulationProfile(int pid)
        {
            DataBase db = new DataBase("adb");
            db.OpenCon();
            string query = "select * from coagulationprofile where binary PID = \"" + pid + "\";";
            KeyValuePair<DataSet, MySqlDataAdapter> ret = db.Queryupd(query);
            db.CloseCon();
            return ret;
        }
        public KeyValuePair<DataSet, MySqlDataAdapter> GetCompleteBloodPicture(int pid)
        {
            DataBase db = new DataBase("adb");
            db.OpenCon();
            string query = "select * from completebloodpicture where binary PID = \"" + pid + "\";";
            KeyValuePair<DataSet, MySqlDataAdapter> ret = db.Queryupd(query);
            db.CloseCon();
            return ret;
        }
        public KeyValuePair<DataSet, MySqlDataAdapter> GetElectrolyTeskIdneyfun(int pid)
        {
            DataBase db = new DataBase("adb");
            db.OpenCon();
            string query = "select * from electrolyteskidneyfun where binary PID = \"" + pid + "\";";
            KeyValuePair<DataSet, MySqlDataAdapter> ret = db.Queryupd(query);
            db.CloseCon();
            return ret;
        }
        public KeyValuePair<DataSet, MySqlDataAdapter> GetLiverFun(int pid)
        {
            DataBase db = new DataBase("adb");
            db.OpenCon();
            string query = "select * from liverfun where binary PID = \"" + pid + "\";";
            KeyValuePair<DataSet, MySqlDataAdapter> ret = db.Queryupd(query);
            db.CloseCon();
            return ret;
        }
        public KeyValuePair<DataSet, MySqlDataAdapter> GetFluid(int pid)
        {
            DataBase db = new DataBase("adb");
            db.OpenCon();
            string query = "select * from fluidchart where binary PID = \"" + pid + "\";";
            KeyValuePair<DataSet, MySqlDataAdapter> ret = db.Queryupd(query);
            db.CloseCon();
            return ret;
        }
        public KeyValuePair<DataSet, MySqlDataAdapter> GetHistoryOfPast(int pid)
        {
            DataBase db = new DataBase("adb");
            db.OpenCon();
            string query = "select * from pasthistory where binary PID = \"" + pid + "\";";
            KeyValuePair<DataSet, MySqlDataAdapter> ret = db.Queryupd(query);
            db.CloseCon();
            return ret;
        }
        public KeyValuePair<DataSet, MySqlDataAdapter> GetComplain(int pid)
        {
            DataBase db = new DataBase("adb");
            db.OpenCon();
            string query = "select * from complain where binary PID = \"" + pid + "\";";
            KeyValuePair<DataSet, MySqlDataAdapter> ret = db.Queryupd(query);
            db.CloseCon();
            return ret;
        }

        public KeyValuePair<DataSet, MySqlDataAdapter> GetMedicalHistory(int pid)
        {
            DataBase db = new DataBase("adb");
            db.OpenCon();
            string query = "select * from medicalhistory where binary PID = \"" + pid + "\";";
            KeyValuePair<DataSet, MySqlDataAdapter> ret = db.Queryupd(query);
            db.CloseCon();
            return ret;
        }
        public KeyValuePair<DataSet, MySqlDataAdapter> GetFamilyHistory(int pid)
        {
            DataBase db = new DataBase("adb");
            db.OpenCon();
            string query = "select * from familyhistory where binary PID = \"" + pid + "\";";
            KeyValuePair<DataSet, MySqlDataAdapter> ret = db.Queryupd(query);
            db.CloseCon();
            return ret;
        }
        public KeyValuePair<DataSet, MySqlDataAdapter> GetPresentHistory(int pid)
        {
            DataBase db = new DataBase("adb");
            db.OpenCon();
            string query = "select * from prillness where binary PID = \"" + pid + "\";";
            KeyValuePair<DataSet, MySqlDataAdapter> ret = db.Queryupd(query);
            db.CloseCon();
            return ret;
        }
        public bool newExamination(int pid, List<string> all)
        {
            DateTimePicker nw = new DateTimePicker();
            nw.Value = DateTime.Now;
            DataBase db = new DataBase("adb");
            db.OpenCon();
            string query = "insert into examination (PID,GeneralLock,HeadAndNeckExam ,ChestExam ,CardiacExam,Pulse,BloodPressure,Temperature,RespiratoryRate ,Inspection,SuperficialPalpation,DeepPalpation ,Percussion,Auscultation,ProvisionalDiagnosi, ExDate)values (" + pid + ",'" + all[0] + "','" + all[1] + "','" + all[2] + "','" + all[3] + "','" + all[4] + "','" + all[5] + "','" + all[6] + "','" + all[7] + "','" + all[8] + "','" + all[9] + "','" + all[10] + "','" + all[11] + "','" + all[12] + "','" + all[13] + "','" + nw.Value.ToString("yyyy-MM-dd") + "') ;";
            bool ret = db.NonQuery(query);
            db.CloseCon();
            return ret;
        }
        public bool newImagingStudies(int pid, List<string> all)
        {
            DataBase db = new DataBase("adb");
            db.OpenCon();
            string query = "insert into imagingstudies (PID,ChestXRay,Abdominal_U_S ,MSCTAbdomen ,Others)values (" + pid + ",'" + all[0] + "','" + all[1] + "','" + all[2] + "','" + all[3] + "') ;";
            bool ret = db.NonQuery(query);
            db.CloseCon();
            return ret;
        }
    }
}
