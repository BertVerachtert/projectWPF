using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_mobiliteit_Bert_Verachtert_r0710075.Model
{
    public class Login : ObservableObject
    {
        private int id, gebruikerID;
        private string email, wachtwoord;

        public Login(string email, string wachtwoord, int gebruikerID)
        {
            Email = email;
            Wachtwoord = wachtwoord;
            GebruikerID = gebruikerID;
        }
        public Login()
        {

        }
        public int ID
        {
            get
            {
                return id;
            }

            set
            {
                Set("ID", ref id, value);
            }
        }

        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                Set(() => Email, ref email, value);
            }
        }
        public string Wachtwoord
        {
            get
            {
                return wachtwoord;
            }

            set
            {
                Set(() => Wachtwoord, ref wachtwoord, value);
            }
        }
        public int GebruikerID
        {
            get
            {
                return gebruikerID;
            }

            set
            {
                Set(() => GebruikerID, ref gebruikerID, value);
            }
        }
    }
}
