using System.Collections.Generic;
using System.Data.SQLite;

namespace Blechelse
{
    public struct t_DatabaseRecord
    {
        public int RecordID;
        public string FileName;
        public string ContentShort;
        public string ContentLong;
        public string StationName;
    }

    public class Backend
    {
        private SQLiteConnection dbConn;

        public Backend(string dbFile)
        {
            dbConn = new SQLiteConnection($"Data Source={dbFile}");
        }

        public List<t_DatabaseRecord> GetStationNames()
        {
            List<t_DatabaseRecord> result = new List<t_DatabaseRecord>();
            dbConn.Open();
            SQLiteCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = "SELECT * FROM station_names";
            SQLiteDataReader r = cmd.ExecuteReader();
            while(r.Read())
            {
                result.Add(new t_DatabaseRecord
                {
                    RecordID = r.GetInt32(0),
                    FileName = r["filename"].ToString(),
                    ContentShort = r["content_short"].ToString(),
                    ContentLong = r["content"].ToString(),
                    StationName = r["name"].ToString(),
                });
            }
            dbConn.Close();
            return result;
        }

        public List<t_DatabaseRecord> GetVoiceSnippets(string tableName)
        {
            List<t_DatabaseRecord> result = new List<t_DatabaseRecord>();
            dbConn.Open();
            SQLiteCommand cmd = dbConn.CreateCommand();
            cmd.CommandText = $"SELECT * FROM {tableName}"; // yeah i know i don't give a fuck about sql injections in this case
            SQLiteDataReader r = cmd.ExecuteReader();
            while (r.Read())
            {
                result.Add(new t_DatabaseRecord
                {
                    RecordID = r.GetInt32(0),
                    FileName = r["filename"].ToString(),
                    ContentShort = r["content_short"].ToString(),
                    ContentLong = r["content"].ToString(),
                    StationName = "",
                });
            }
            dbConn.Close();
            return result;
        }
    }
}
