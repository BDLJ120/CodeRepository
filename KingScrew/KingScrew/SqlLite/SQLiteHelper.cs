using System.Data;
using System.Data.SQLite;

namespace KingScrew
{
	public static class SQLiteHelper
    {
        const string dbFileName = "d:\\YAuto\\YAutoDB.sqlite";
        static string connectionStr = string.Format("Data Source={0};Version=3;", dbFileName);
        static SQLiteConnection con;
        public static SQLiteConnection GetConnection()
        {
            if (!System.IO.File.Exists(dbFileName))
            {
                return null;
            }
            if (con == null || con.State == ConnectionState.Closed || con.State == ConnectionState.Broken)
            {
                con = new SQLiteConnection(connectionStr);
                con.Open();
            }
            return con;
        }

        public static int ExecuteNonQuery(string sql)
        {
            var cmd = new SQLiteCommand(sql, GetConnection());
            return cmd.ExecuteNonQuery();
        }

        public static DataTable ExecuteQuery(string sql)
        {
            var dt = new DataTable();
            var cmd = new SQLiteCommand(sql, GetConnection());
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                var values = new string[dr.FieldCount];
                for (int i = 0; i < dr.FieldCount; i++)
                {
                    if (dt.Columns.Count != dr.FieldCount)
                    {
                        dt.Columns.Add(dr.GetName(i));
                    }
                    values[i] = dr[i].ToString();                 
                }
                dt.Rows.Add(values);
            }
            return dt;
        }

    }
}
