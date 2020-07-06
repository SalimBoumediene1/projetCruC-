using DatabaseToolsNS.MariaDb;
using DatabaseToolsNS.Tools;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using WebApi.Models;

namespace WebApi.Crud
{
    public class FormationCrud
    {
        public static Formation GetById(int Id)
        {
            Formation formation = new Formation();
            var sqlCmd = DatabaseConnection.GetInstance().SqlConnection.CreateCommand();
            sqlCmd.CommandText = "SELECT * FROM formation " +
                "WHERE Id = @Id";
            sqlCmd.Parameters.AddWithValue("@Id", Id);
            sqlCmd.ExecuteNonQuery();
            var da = new MySqlDataAdapter(sqlCmd);
            var datSetFormation = new DataSet();
            da.Fill(datSetFormation);
            //formation.DataSource = datSetFormation.Tables[0];
            if (datSetFormation.Tables[0].Rows.Count > 0)
            {
                return CreateFormationFromRow(datSetFormation.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        public static List<Formation> GetByActif(bool actif)
        {
            List<Formation> formations = new List<Formation>();
            var sqlCmd = DatabaseConnection.GetInstance().SqlConnection.CreateCommand();
            sqlCmd.CommandText = "SELECT * FROM formation ";
            if (actif)
            {
                sqlCmd.CommandText += "WHERE Deleted = false";
            }

            sqlCmd.Parameters.AddWithValue("@Deleted", actif);
            sqlCmd.ExecuteNonQuery();
            var da = new MySqlDataAdapter(sqlCmd);
            var datSetFormation = new DataSet();
            da.Fill(datSetFormation);

            foreach (DataRow row in datSetFormation.Tables[0].Rows)
            {
                formations.Add(CreateFormationFromRow(row));
            }
            return formations;
        }

        public static List<Formation> GetListOptimise(bool actif)
        {
            List<Formation> formations = new List<Formation>();
            var sqlCmd = DatabaseConnection.GetInstance().SqlConnection.CreateCommand();
            sqlCmd.CommandText = "SELECT f.*, c.Matiere, c.Id as Cours_ID "
                                + "FROM formation f "
                                + "LEFT OUTER JOIN cours_formation_link cf1 ON cf1.formation_id = f.id "
                                + "LEFT OUTER JOIN cours c ON c.id = cf1.cours_id ";
            if (actif)
            {
                sqlCmd.CommandText += "WHERE Deleted = false ";
            }
            sqlCmd.CommandText += "ORDER BY f.Id";
            var da = new MySqlDataAdapter(sqlCmd);
            var datSetFormation = new DataSet();
            da.Fill(datSetFormation);
            var lastformationId = 0;
            Formation formation = null;
            foreach (DataRow row in datSetFormation.Tables[0].Rows)
            {
                if (lastformationId != Convert.ToInt32(row["Id"]))
                {
                    formation = new Formation();
                    formation.Id = Convert.ToInt32(row["Id"]);
                    formation.FirstName = row["FirstName"].ToString();
                    formation.LastName = row["LastName"].ToString();
                    formation.Deleted = Convert.ToBoolean(row["Deleted"]);
                    formation.Cours = new List<Cours>();
                    lastformationId = formation.Id;
                }
                if (row["Matiere"] != null)
                {
                    var cours = new Cours();
                    cours.Id = Convert.ToInt32(row["Id"]);
                    cours.Matiere = row["Matiere"].ToString();
                    formation.Cours.Add(cours);

                }
                formations.Add(formation);
            }
            return formations;
        }

        private static Formation CreateFormationFromRow(DataRow row)
        {

            Formation formation = new Formation();
            setFormationFromRow(formation, row);
            formation.Cours = CoursCrud.GetById(formation.Id);
            return formation;
        }

        private static void setFormationFromRow(Formation formation, DataRow row)
        {
            DatabaseToolsNS.Tools.DataTableUtil.SetPropertiesFromDataRow(formation, row);
        }
    }
}
