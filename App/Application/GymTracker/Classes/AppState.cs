using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace GymTracker.Classes
{
    public static class AppState
    {
        public static readonly SQLiteConnection DbCon = new SQLiteConnection("Data Source=gymtracker.sqlite; Version=3");
        public static List<User> Userlist = new List<User>();
        public static DataSet Data = new DataSet();

        public static async void LoadData()
        {
            SQLiteDataAdapter dataAdapter = new SQLiteDataAdapter();

            await Task.Factory.StartNew(() =>
            {

                var sql = "SELECT * FROM users";
                var table = "Load";
                dataAdapter = new SQLiteDataAdapter(sql, DbCon);
                dataAdapter.Fill(Data, table);

                if (Data.Tables[0].Rows.Count > 0)
                {
                    for (int i = 0; i < Data.Tables[0].Rows.Count; i++)
                    {
                        var NewUser = new User()
                        {
                            Username = Data.Tables[0].Rows[i]["username"].ToString(),
                            Password = Data.Tables[0].Rows[i]["password"].ToString(),
                            SecurityQues = Data.Tables[0].Rows[i]["securityques"].ToString(),
                            SecurityAns = Data.Tables[0].Rows[i]["securityans"].ToString()
                        };

                        Userlist.Add(NewUser);
                    }
                }
            });
        }
    }
}
