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
    public class LoginDataService
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["azure"].ConnectionString;
        private static IDbConnection db = new SqlConnection(connectionString);

        public List<Login> GetLogins()
        {
            string sql = "Select * from Login order by email";
            List<Login> logins = (List<Login>)db.Query<Login>(sql);
            return logins;
        }

        public List<Login> GetLoginByEmail(string email)
        {
            string sql = "Select * from Login where Email = @email";
            List<Login> lijst = (List<Login>)db.Query<Login>(sql, new { email });
            return lijst;
        }

        public void InsertLogin(Login login)
        {
            string sql = "Insert into Login (email, wachtwoord, gebruikerID) values (@email, @wachtwoord, @gebruikerID)";
            db.Query(sql, login);
        }
    }
}
