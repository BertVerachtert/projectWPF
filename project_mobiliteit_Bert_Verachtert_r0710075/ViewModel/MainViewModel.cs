using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using project_mobiliteit_Bert_Verachtert_r0710075.Extensions;
using project_mobiliteit_Bert_Verachtert_r0710075.Messages;
using project_mobiliteit_Bert_Verachtert_r0710075.Model;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Input;

namespace project_mobiliteit_Bert_Verachtert_r0710075.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// Use the <strong>mvvminpc</strong> snippet to add bindable properties to this ViewModel.
    /// </para>
    /// <para>
    /// You can also use Blend to data bind with the tool's support.
    /// </para>
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private DialogService dialogService;
        public ICommand RegistratieCommand { get; private set; }
        public ICommand LoginCommand { get; private set; }
        private string email, wachtwoord;
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
        public MainViewModel()
        {
            Messenger.Default.Register<UpdateFinishedMessage>(this, OnMessageReceived);
            RegistratieCommand = new RelayCommand(RegistratieGebruiker);
            LoginCommand = new RelayCommand(LoginGebruiker);
            dialogService = new DialogService();
        }

        private void OnMessageReceived(UpdateFinishedMessage message)
        {
            dialogService.CloseRegsitratieDialog();
        }

        private void RegistratieGebruiker()
        {
            dialogService.ShowRegistratieDialog();
        }

        private void LoginGebruiker()
        {
            LoginDataService loginDS = new LoginDataService();
            List<Login> lijst = loginDS.GetLogins();
            if (lijst.Any(z => z.Email == Email) && lijst.Any(z => z.Wachtwoord == Wachtwoord))
            {
                Messenger.Default.Send<string>(Email);
                dialogService.ShowHomeDialog();
            }
            else
            {
                Messenger.Default.Send<string>("De gegevens komen niet overeen in de database");
                dialogService.ShowMeldingDialog();
            }
        }
    }
}