using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Warframe.Database
{
    public class Database
    {
        private static SqlConnection conn = new SqlConnection("Data Source=LAP7OP\\SQLEXPRESS;Initial Catalog=Warframe;Integrated Security=True");

        public static List<int> GetModId(String name)
        {
            List<int> mods = new List<int>();
            try
            {
                conn.Open();
                SqlCommand query = new SqlCommand("SELECT Id FROM MODS WHERE ModName = '" + name + "';" , conn);
                SqlDataReader results = query.ExecuteReader();

                while (results.Read())
                {
                    mods.Add((int)results["Id"]);
                }
                conn.Close();
            }
            catch (Exception e)
            {
                //Should probably do something here hey
            }
            return mods;
        }

        public static String GetModName(int id)
        {
            String name = "";
            try
            {
                conn.Open();
                SqlCommand query = new SqlCommand("SELECT ModName FROM MODS WHERE Id = "+ id +";", conn);
                SqlDataReader results = query.ExecuteReader();

                if (results.Read())
                {
                    name = results["ModName"].ToString();
                }
                conn.Close();
            }
            catch (Exception e)
            {
                //Should probably do something here hey
            }
            return name;
        }

        public static int GetModDrain(int id)
        {
            int drain = 0;
            try
            {
                conn.Open();
                SqlCommand query = new SqlCommand("SELECT Drain FROM MODS WHERE Id = " + id + ";", conn);
                SqlDataReader results = query.ExecuteReader();

                if (results.Read())
                {
                    drain = (int)results["Drain"];
                }
                conn.Close();
            }
            catch (Exception e)
            {
                //Should probably do something here hey
            }
            return drain;
        }

        public static int GetModDrain(int id, int rank)
        {
            return GetModDrain(id) + rank;
        }

        public static int GetModMaxRank(int id)
        {
            int rank = 0;
            try
            {
                conn.Open();
                SqlCommand query = new SqlCommand("SELECT MaxRank FROM MODS WHERE Id = " + id + ";", conn);
                SqlDataReader results = query.ExecuteReader();

                if (results.Read())
                {
                    rank = (int)results["MaxRank"];
                }
                conn.Close();
            }
            catch (Exception e)
            {
                //Should probably do something here hey
            }
            return rank;
        }

        private static String GetModText(int id)
        {
            String text = "";
            try
            {
                conn.Open();
                SqlCommand query = new SqlCommand("SELECT ModName FROM MODS WHERE Id = " + id + ";", conn);
                SqlDataReader results = query.ExecuteReader();

                if (results.Read())
                {
                    text = results["ModText"].ToString();
                }
                conn.Close();
            }
            catch (Exception e)
            {
                //Should probably do something here hey
            }
            return text;
        }

        /*
         * Some Utility functions
         */

        public static String FillNumbers(String initial, params int[] values)
        {
            char[] text = initial.ToCharArray();
            char[] output = new char[text.Length];

            char[] keyPhrase = {'=','=','='}; //the phrase you are searching for
            int j = 0; //state value

            for(int i = 0; i < text.Length; i++)
            {
                if (text[i] == keyPhrase[j])
                {
                    j++;

                    if(j == keyPhrase.Length)
                    {
                        output[i] = '1';
                    }
                }
                else
                {
                    while(j > 0)
                    {
                        output[i - j] = text[i];
                        j--;
                    }
                    output[i] = text[i];
                }
            }
            return new String(output);
        }
    }
}
