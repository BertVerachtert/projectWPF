using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_mobiliteit_Bert_Verachtert_r0710075.Model
{
    public class GebruikerDataService
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["azure"].ConnectionString;
        private static IDbConnection db = new SqlConnection(connectionString);

        public List<Gebruiker> GetLaatsteGebruiker()
        {
            string sql = "Select TOP 1 * from Gebruiker order by ID desc";
            List<Gebruiker> gebruikers = (List<Gebruiker>)db.Query<Gebruiker>(sql);
            return gebruikers;
        }
        public void InsertGebruiker (Gebruiker gebruiker)
        {
            string sql = "Insert into Gebruiker (voornaam, naam, straat, huisnummer, gemeente) values (@voornaam, @naam, @straat, @huisnummer, @gemeente)";
            db.Query(sql, gebruiker);
        }
    }
}
