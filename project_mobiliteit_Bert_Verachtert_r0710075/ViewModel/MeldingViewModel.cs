using GalaSoft.MvvmLight;
using project_mobiliteit_Bert_Verachtert_r0710075.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_mobiliteit_Bert_Verachtert_r0710075.ViewModel
{
    public class MeldingViewModel : ViewModelBase
    {
        private string message;
        public string Message
        {
            get
            {
                return message;
            }
            set
            {
                message = value;
                RaisePropertyChanged(() => Message);
            }
        }

        public MeldingViewModel() {
            Messenger.Default.Register<string>(this, OnMessageReceived);
        }

        private void OnMessageReceived(string bericht)
        {
            Message = bericht;
        }
    }
}
