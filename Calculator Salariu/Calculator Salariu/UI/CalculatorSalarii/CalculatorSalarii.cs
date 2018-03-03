using Calculator_Salariu.DAL.Model;
using Calculator_Salariu.UI.CalculatorSalarii;
using Calculator_Salariu.UI.CalculatorSalarii.Forms;
using System;
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

        private void adaugaSalariatButton_Click(object sender, EventArgs e)
        {
            var form = new AdaugaSalariat();

            if (form.ShowDialog() == DialogResult.Yes)
            {
                var result = CalculatorViewModel.AdaugaSalariat(form.Salariat);

                if (result > 0)
                {
                    CalculatorViewModel.IncarcaSalariatii();
                    SyncDataEvidenta();
                }
                else
                {
                    MessageBox.Show("Eroare!");
                }
            }
        }

        private void salariatiGridView_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var o = (Salariat)salariatBindingSource.Current;

            MessageBox.Show(o.Nume + " " + o.Prenume);
        }

        private void salariatiGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            CalculatorViewModel.SalariatSelectat = (Salariat)salariatBindingSource[e.RowIndex];
            
            SyncDataDetaliiSalariat(CalculatorViewModel.SalariatSelectat);
        }

        private void stergeSalariatButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Sunteți sigur că doriți să ștergeți acest salariat?", "Atenție", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                var result = CalculatorViewModel.StergeSalariat(CalculatorViewModel.SalariatSelectat);

                if (result > 0)
                {
                    CalculatorViewModel.IncarcaSalariatii();
                    SyncDataEvidenta();
                }
                else
                {
                    MessageBox.Show("Eroare la ștergere!");
                }
            }
        }

        private void anuleazaModificarileButton_Click(object sender, EventArgs e)
        {
            CalculatorViewModel.IncarcaSalariatii();
            SyncDataEvidenta();
        }

        private void cautareTextBox_TextChanged(object sender, EventArgs e)
        {
            CalculatorViewModel.Filtru = cautareTextBox.Text.ToLower();
            CalculatorViewModel.Filtrare();
            SyncDataEvidenta();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            CalculatorViewModel.IncarcaSalariatii();
            SyncDataEvidenta();
        }

        private void salveazaModificarileButton_Click(object sender, EventArgs e)
        {
            foreach (Salariat salariat in salariatBindingSource)
            {
                CalculatorViewModel.ModificaSalariat(salariat);
            }

            cautareTextBox.Text = "";
            CalculatorViewModel.Filtru = "";
            CalculatorViewModel.IncarcaSalariatii();
            SyncDataEvidenta();
        }

        private void tiparireFluturasButton_Click(object sender, EventArgs e)
        {

        }

        #endregion Events

        #region Private Functionality

        #region SyncData

        private void SyncData()
        {
            SyncDataConfigurare();
            SyncDataEvidenta();
            SyncDataTiparire();
            SyncDataDetaliiSalariat(CalculatorViewModel.SalariatSelectat);
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
            salariatBindingSource.Clear();

            CalculatorViewModel.SalariatiFiltrati.ForEach(s => salariatBindingSource.Add(s));
        }

        private void SyncDataDetaliiSalariat(Salariat salariat)
        {
            if (salariat == null || salariat.Nr_crt == 0)
            {
                detaliiSalariatGroup.Visible = false;
                return;
            }

            detaliiSalariatGroup.Visible = true;

            numeLabel.Text = (salariat.Nume != null ? salariat.Nume.ToUpper() : "") + " " + (salariat.Prenume ?? "");
            functieLabel.Text = salariat.Functie ?? "";

            tableLayoutPanel1.Visible = false;

            salariuLabel.Text = salariat.SalariuBaza + " RON";
            sporLabel.Text = salariat.ProcentSpor + " RON";
            premiiBruteLabel.Text = salariat.PremiiBrute + " RON";
            totalBrutLabel.Text = (salariat.TotalBrut ?? 0) + " RON";
            brutImpozabilLabel.Text = (salariat.BrutImpozabil ?? 0) + " RON";
            impozitLabel.Text = (salariat.Impozit ?? 0) + " RON";
            casLabel.Text = (salariat.CAS ?? 0) + " RON";
            cassLabel.Text = (salariat.CASS ?? 0) + " RON";
            retineriLabel.Text = salariat.Retineri + " RON";
            viratCardLabel.Text = (salariat.ViratCard ?? 0) + " RON";

            tableLayoutPanel1.Visible = true;
        }


        #endregion

        #endregion
    }
}