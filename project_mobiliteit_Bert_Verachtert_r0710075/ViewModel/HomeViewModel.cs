using GalaSoft.MvvmLight;
using project_mobiliteit_Bert_Verachtert_r0710075.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_mobiliteit_Bert_Verachtert_r0710075.ViewModel
{
    public class HomeViewModel : ViewModelBase
    {
        private string email;
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
        public HomeViewModel()
        {
            Messenger.Default.Register<string>(this, OnEmailReceived);           
        }

        private void OnEmailReceived(string email)
        {
            Email = email;
        }
    }
}
