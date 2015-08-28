using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PowerPOS
{
    public class Util
    {

        public static DataTable DBQuery(string sql)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            DataTable dt = new DataTable();
            try
            {
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(sql, Param.SQLiteConnection);
                adapter.Fill(dt);
            }
            catch (Exception ex)
            {
                //WriteErrorLog(ex.Message);
                //WriteErrorLog(ex.StackTrace);
            }
            return dt;
        }
        public static void DBExecute(string sql)
        {
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            try
            {
                SQLiteCommand command = new SQLiteCommand(sql, Param.SQLiteConnection);
                command.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                //WriteErrorLog(ex.Message);
                //WriteErrorLog(ex.StackTrace);
            }
        }
    }
}
