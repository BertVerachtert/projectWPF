using project_mobiliteit_Bert_Verachtert_r0710075.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace project_mobiliteit_Bert_Verachtert_r0710075.Extensions
{
    public class DialogService
    {
        Window melding = null;
        Window registratie = null;
        Window home = null;
        Window main = null;

        public void ShowMeldingDialog()
        {
            melding = new MeldingWindow();
            melding.ShowDialog();
        }

        public void CloseMeldingDialog()
        {
            if (melding != null)
                melding.Close();
        }
        
        public void ShowRegistratieDialog()
        {
            registratie = new RegisterWindow();
            registratie.ShowDialog();
        }

        public void CloseRegsitratieDialog()
        {
            if (registratie != null)
                registratie.Close();
        }    

        public void ShowHomeDialog()
        {
            main = new MainWindow();
            home = new HomeWindow();
            home.ShowDialog();
        }

        public void CloseHomeDialog()
        {
            if (home != null)
                home.Close();
        }

        public void CloseMainDialog()
        {
            if (main != null)
                main.Close();
        }
    }
}
