using DatabaseToolsNS.MariaDb;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Crud
{
    public class CoursCrud
    {
        public static List<Cours> GetById(int Id)
        {
            List<Cours> listCours = new List<Cours>();
            var sqlCmd = DatabaseConnection.GetInstance().SqlConnection.CreateCommand();
            sqlCmd.CommandText = "SELECT c.* FROM cours c "
                                +"INNER JOIN cours_formation_link cf1 ON cf1.Cours_id = c.Id "
                                +"WHERE cf1.Formation_id = @Id";
            sqlCmd.Parameters.AddWithValue("@Id", Id);
            sqlCmd.ExecuteNonQuery();
            var da = new MySqlDataAdapter(sqlCmd);
            var datSetFormation = new DataSet();
            da.Fill(datSetFormation);
            foreach (DataRow row in datSetFormation.Tables[0].Rows)
            {
                listCours.Add(CreateCourFromRow(row));
            }
            return listCours;
        }

        private static Cours CreateCourFromRow(DataRow row)
        {
            Cours cour = new Cours();
            DatabaseToolsNS.Tools.DataTableUtil.SetPropertiesFromDataRow(cour, row);
            return cour;
        }

        public static Cours Insert(Cours cours)
        {
            var sqlCmd = DatabaseConnection.GetInstance().SqlConnection.CreateCommand();
            sqlCmd.CommandText = "INSERT INTO cours(Matiere) "
                                + "VALUES(@Matiere) "
                                + ";SELECT LAST_INSERT_ID() from cours ";
            sqlCmd.Parameters.AddWithValue("@Matiere", cours.Matiere);
            cours.Id = Convert.ToInt32(sqlCmd.ExecuteScalar());
            return cours;
        }

        public static int Delete(int id)
        {
            var sqlCmd = DatabaseConnection.GetInstance().SqlConnection.CreateCommand();
            sqlCmd.CommandText = "DELETE FROM cours "
                                + "WHERE Id = @Id ";
            sqlCmd.Parameters.AddWithValue("@Id", id);
            return sqlCmd.ExecuteNonQuery();
        }
    }
}
