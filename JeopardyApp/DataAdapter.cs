using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeopardyApp
{
    static class DataAdapter
    {
        static SqlConnection oConn = new SqlConnection("Data Source=stusql-cis151-101-fa19.cimq4ah3jd04.us-east-2.rds.amazonaws.com,1433; Initial Catalog=am0779663; User Id=am0779663; Password=779663");

        public static void Connect()
        {
            try
            {
                oConn.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Disconnect()
        {
            try
            {
                oConn.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static void Insert(string data)
        {
            string sqlIns = "INSERT INTO Leaderboard_Serialized(Data) VALUES(@data)";

            try
            {
                Connect();

                SqlCommand cmdIns = new SqlCommand(sqlIns, oConn);
                cmdIns.Parameters.AddWithValue("@data", data);

                cmdIns.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Disconnect();
            }
        }

        public static List<string> GetSerialized()
        {
            string sql = "SELECT * FROM Leaderboard_Serialized";

            SqlCommand cmd = new SqlCommand(sql, oConn);

            List<string> myLeaderboard = new List<string>();

            try
            {
                Connect();

                SqlDataReader reader = cmd.ExecuteReader();

                while(reader.Read())
                {
                    myLeaderboard.Add(reader["Data"].ToString());
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Disconnect();
            }

            return myLeaderboard;
        }

        public static List<Player> GetWinners()
        {
            List<Player> winnerList = new List<Player>();

            List<string> mySer = new List<string>();

            mySer = GetSerialized();

            foreach(string winner in mySer)
            {
                Player myWinner = Serializer.DeserializeNow(winner);
                winnerList.Add(myWinner);
            }
            return winnerList;
        }
    }
}
