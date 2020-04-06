using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using project_mobiliteit_Bert_Verachtert_r0710075.Extensions;
using project_mobiliteit_Bert_Verachtert_r0710075.Messages;
using project_mobiliteit_Bert_Verachtert_r0710075.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace project_mobiliteit_Bert_Verachtert_r0710075.ViewModel
{
    public class RegisterViewModel : ViewModelBase
    {
        private DialogService dialogService;
        private string voornaam, naam, straat, gemeente, email, wachtwoord;
        private int huisnummer;
        public ICommand InsertGebruikerCommand { get; private set; }
        public string Voornaam
        {
            get
            {
                return voornaam;
            }
            set
            {
                voornaam = value;
                RaisePropertyChanged(() => Voornaam);
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
                naam = value;
                RaisePropertyChanged(() => Naam);
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
                straat = value;
                RaisePropertyChanged(() => Straat);
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
                huisnummer = value;
                RaisePropertyChanged(() => Huisnummer);
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
                gemeente = value;
                RaisePropertyChanged(() => Gemeente);
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
                email = value;
                RaisePropertyChanged(() => Email);
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
                wachtwoord = value;
                RaisePropertyChanged(() => Wachtwoord);
            }
        }
        public RegisterViewModel()
        {
            InsertGebruikerCommand = new RelayCommand(ToevoegenGebruiker);
            dialogService = new DialogService();
        }

        private void ToevoegenGebruiker()
        {
            GebruikerDataService gebruikerDS = new GebruikerDataService();
            LoginDataService loginDS = new LoginDataService();
            List<Login> lijst = loginDS.GetLogins();         

            if(Voornaam != null)
            {
                if(Naam != null)
                {
                    if(lijst.Any(z => z.Email == Email))
                    {
                        Messenger.Default.Send<string>("Email bestaat al!");
                        dialogService.ShowMeldingDialog();
                    }
                    else
                    {
                        if(Email != null)
                        {
                            if(Wachtwoord != null)
                            {
                                Gebruiker nieuwGebruiker = new Gebruiker(Voornaam, Naam, Straat, Huisnummer, Gemeente);
                                gebruikerDS.InsertGebruiker(nieuwGebruiker);
                                GebruikerDataService nieuwDS = new GebruikerDataService();
                                List<Gebruiker> lijstGebruiker = nieuwDS.GetLaatsteGebruiker();
                                foreach (var gebruiker in lijstGebruiker)
                                {
                                    Login nieuwLogin = new Login(Email, Wachtwoord, gebruiker.ID);
                                    loginDS.InsertLogin(nieuwLogin);
                                }
                                Messenger.Default.Send<UpdateFinishedMessage>(new UpdateFinishedMessage(UpdateFinishedMessage.MessageType.Inserted));
                            } else
                            {
                                Messenger.Default.Send<string>("Het wachtwoord is niet ingevuld!");
                                dialogService.ShowMeldingDialog();
                            }                           
                        }
                        else
                        {
                            Messenger.Default.Send<string>("De email is niet ingevuld!");
                            dialogService.ShowMeldingDialog();
                        }                        
                    }
                    
                }
                else
                {
                    Messenger.Default.Send<string>("De naam is niet ingevuld!");
                    dialogService.ShowMeldingDialog();
                }
            }
            else
            {
                Messenger.Default.Send<string>("De voornaam is niet ingevuld!");
                dialogService.ShowMeldingDialog();
            }
            
        }
    }
}
