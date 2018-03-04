using Calculator_Salariu.DAL.Model;
using Calculator_Salariu.Utils;
using System;
using System.Windows.Forms;

namespace Calculator_Salariu.UI.CalculatorSalarii.Forms
{
    public partial class ModificaParametrii : Form
    {
        public ModificaParametrii(Parametrii parametrii)
        {
            InitializeComponent();

            Parametrii = parametrii;

            cassNumeric.Value = (int)(parametrii.CASS * 100);
            casNumeric.Value = (int)(parametrii.CAS * 100);
            impozitNumeric.Value = (int)(parametrii.Impozit * 100);
        }

        public Parametrii Parametrii { get; set; }

        private void salvareButton_Click(object sender, EventArgs e)
        {
            Parametrii.CAS = (double)casNumeric.Value / 100;
            Parametrii.CASS = (double)cassNumeric.Value / 100;
            Parametrii.Impozit = (double)impozitNumeric.Value / 100;
            Parametrii.Parola = CryptoUtils.GetHashString(parolaTextBox.Text);
        }

        private void parolaTextBox_TextChanged(object sender, EventArgs e)
        {
            if (parolaTextBox.Text.Length > 0)
            {
                salvareButton.Enabled = true;
                return;
            }

            salvareButton.Enabled = false;
        }
    }
}
