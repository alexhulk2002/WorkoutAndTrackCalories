using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkoutAndTrackCalories
{
    public static class DatabaseTools
    {
        public static string connStr = $@"URI=file:{Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "aliment.db")}";
        public static SQLiteConnection Connection = new SQLiteConnection(connStr);
        public static void OpenConnection()
        {
            Connection.Open();
        }

        public static int CreateTable(string tableName, string tableColumns)
            => new SQLiteCommand($"CREATE TABLE IF NOT EXISTS {tableName}({tableColumns})", Connection)
                .ExecuteNonQuery();

        public static int InsertRow(string tableName, Dictionary<string, object> data)
        {
            var cmd = new SQLiteCommand($"INSERT INTO {tableName}({string.Join(", ", data.Select(i => i.Key))}) " +
                $"VALUES({string.Join(", ", data.Select(i => "@" + i.Key.ToUpper()))})", Connection);
            foreach (var item in data)
                cmd.Parameters.AddWithValue("@" + item.Key.ToUpper(), item.Value);
            return cmd.ExecuteNonQuery();
        }


    }
}

