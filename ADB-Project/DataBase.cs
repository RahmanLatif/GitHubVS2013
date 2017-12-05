using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
namespace ADB_Project
{
    public class DataBase
    {
        MySqlConnectionStringBuilder build;
        MySqlConnection myconnection;
        MySqlCommand cmd;
        MySqlCommandBuilder mscb;
        MySqlDataAdapter da;
        string DB;
        public DataBase(string db)
        {
            this.DB = db;
        }
        public void OpenCon()
        {
            build = new MySqlConnectionStringBuilder();
            build.Server = "localhost";
            build.Port = 3306;
            build.UserID = "root";
            build.Password = "";
            build.Database = DB;
            myconnection = new MySqlConnection(build.ToString());
            myconnection.Open();
        }
        public bool NonQuery(string query)
        {
            try
            {
                cmd = new MySqlCommand(query, myconnection);
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }
        public DataSet Query(string query)
        {
            DataSet ds = new DataSet();
            try
            {
                da = new MySqlDataAdapter(query, myconnection);
                da.Fill(ds);
            }
            catch(Exception ex)
            {
                return null;
            }
            return ds;
        }

        public KeyValuePair<DataSet, MySqlDataAdapter> Queryupd(string query)
        {
            DataSet ds = new DataSet();
            try
            {
                da = new MySqlDataAdapter(query, myconnection);
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                return new KeyValuePair<DataSet, MySqlDataAdapter>(null, null);
            }
            return new KeyValuePair<DataSet, MySqlDataAdapter>(ds, da);
        }

        public void CloseCon()
        {
            myconnection.Close();
        }
    }
}