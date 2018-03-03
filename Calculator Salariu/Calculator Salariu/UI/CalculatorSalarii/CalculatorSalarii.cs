using Calculator_Salariu.UI.CalculatorSalarii;
using Calculator_Salariu.UI.CalculatorSalarii.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator_Salariu
{
    public partial class CalculatorSalarii : System.Windows.Forms.Form
    {
        private CalculatorSalariiViewModel CalculatorViewModel { get; set; }

        public CalculatorSalarii()
        {
            InitializeComponent();

            CalculatorViewModel = new CalculatorSalariiViewModel();
            CalculatorViewModel.IncarcaDatele();

            SyncData();
        }

        #region Events

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Doriți să închideți aplicația?", "Ieșire", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void modificareParametriiButton_Click(object sender, EventArgs e)
        {
            var form = new ModificaParametrii(CalculatorViewModel.Parametrii);

            if (form.ShowDialog() == DialogResult.Yes)
            {
                var result = CalculatorViewModel.ModificaParametrii(form.Parametrii);

                if (result > 0)
                {
                    CalculatorViewModel.IncarcaParametrii();
                    SyncDataConfigurare();
                }
                else
                {
                    MessageBox.Show("Parolă greșită!");
                }

            }
        }

        private void schimbaParolaButton_Click(object sender, EventArgs e)
        {
            if (parolaNouaTextBox.Text.Equals(parolaNouaConfirmaTextBox.Text))
            {
                var result = CalculatorViewModel.ModificaParola(parolaNouaTextBox.Text, parolaActualaTextBox.Text);

                switch (result)
                {
                    case 0:
                        MessageBox.Show("Nu există parametrii. Apăsați \"Modificare parametrii\" pentru a adăuga noi parametrii și o nouă parolă.", "Atenție", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        break;

                    case 1:
                        MessageBox.Show("Parola a fost schimbată cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        break;

                    case -1:
                        MessageBox.Show("Parola actuală nu a fost introdusă corect!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                }
            }
            else
            {
                MessageBox.Show("Parola nouă nu este aceiași cu parola nouă de confirmare!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            parolaActualaTextBox.Text = "";
            parolaNouaTextBox.Text = "";
            parolaNouaConfirmaTextBox.Text = "";
        }

        #endregion Events

        #region Private Functionality

        #region SyncData

        private void SyncData()
        {
            SyncDataConfigurare();
            SyncDataEvidenta();
            SyncDataTiparire();
        }

        private void SyncDataConfigurare()
        {
            casTextBox.Text = CalculatorViewModel.Parametrii.CAS.ToString();
            cassTextBox.Text = CalculatorViewModel.Parametrii.CASS.ToString();
            impozitTextBox.Text = CalculatorViewModel.Parametrii.Impozit.ToString();
        }

        private void SyncDataTiparire()
        {

        }

        private void SyncDataEvidenta()
        {

        }

        #endregion

        #endregion

    }
}