using DatabaseToolsNS.MariaDb;
using System;

namespace WebApi.Tools
{
    public class Tools
    {

        public static void BddConnection()
        {
            var con = DatabaseConnection.GetInstance().SqlConnection;
            con.ConnectionString = "server=localhost;database=formation_c_sharp;uid=root;";
            try
            {
                con.Open();
            }
            catch (Exception ex)
            {
                //Log erreur

            }
        }
    }
}
