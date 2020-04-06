using GalaSoft.MvvmLight;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_mobiliteit_Bert_Verachtert_r0710075.Model
{
    public class Gebruiker : ObservableObject
    {
        private int id, huisnummer;
        private string voornaam, naam, straat, gemeente;

        public Gebruiker(string voornaam, string naam, string straat, int huisnummer, string gemeente)
        {
            Voornaam = voornaam;
            Naam = naam;
            Straat = straat;
            Huisnummer = huisnummer;
            Gemeente = gemeente;
        }

        public Gebruiker()
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

        public string Voornaam
        {
            get
            {
                return voornaam;
            }

            set
            {
                Set(() => Voornaam, ref voornaam, value);
            }
        }

        public string Naam
        {
            get
            {
                return naam;
            }

            set
            {
                Set(() => Naam, ref naam, value);
            }
        }

        public string Straat
        {
            get
            {
                return straat;
            }

            set
            {
                Set(() => Straat, ref straat, value);
            }
        }

        public int Huisnummer
        {
            get
            {
                return huisnummer;
            }

            set
            {
                Set(() => Huisnummer, ref huisnummer, value);
            }
        }

        public string Gemeente
        {
            get
            {
                return gemeente;
            }

            set
            {
                Set(() => Gemeente, ref gemeente, value);
            }
        }
    }
}
