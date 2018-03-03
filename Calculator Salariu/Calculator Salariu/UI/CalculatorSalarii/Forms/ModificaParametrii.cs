using Calculator_Salariu.DAL;
using Calculator_Salariu.DAL.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private DataService DataService { get; set; }

        private void salvareButton_Click(object sender, EventArgs e)
        {
            Parametrii.CAS = (double)casNumeric.Value / 100;
            Parametrii.CASS = (double)cassNumeric.Value / 100;
            Parametrii.Impozit = (double)impozitNumeric.Value / 100;
            Parametrii.Parola = parolaTextBox.Text;

            //var result = DataService.ModificaParametrii(Parametrii);
            //if (result == -1 )
            //{
            //    MessageBox.Show("Eroare. Parolă greșită!");
            //}
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
