﻿using Calculator_Salariu.DAL.Model;
using Calculator_Salariu.UI.CalculatorSalarii;
using Calculator_Salariu.UI.CalculatorSalarii.Forms;
using Calculator_Salariu.Utils;
using System;
using System.Collections.Generic;
using System.IO;
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

        private void CalculatorSalarii_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Doriți să închideți aplicația?", "Ieșire", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

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
                    CalculatorViewModel.IncarcaDatele();
                    SyncData();
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
                var result = CalculatorViewModel.ModificaParola(CryptoUtils.GetHashString(parolaNouaTextBox.Text), CryptoUtils.GetHashString(parolaActualaTextBox.Text));

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
            var form = new AdaugaSalariat(null);

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
            var form = new SelectarePerioada();

            if (form.ShowDialog() == DialogResult.Yes)
            {
                var vizualizareForm = new VizualizareRaport();
                var salariati = new List<Salariat>() { CalculatorViewModel.SalariatSelectat };
                
                var directory = AppDomain.CurrentDomain.BaseDirectory;
                var path = Path.Combine(directory, "Reports\\FluturasSalariu\\FluturasSalariuReport.rdlc");

                ReportUtils.RefreshReport(vizualizareForm.reportViewer1, salariati, path, form.An, form.Luna);

                vizualizareForm.reportViewer1.Visible = true;

                vizualizareForm.ShowDialog();
            }
        }

        private void ajutorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Ajutor();
            form.ShowDialog();
        }

        private void despreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var form = new Despre();
            form.ShowDialog();
        }

        private void modificaSalariatButton_Click(object sender, EventArgs e)
        {
            var form = new AdaugaSalariat(CalculatorViewModel.SalariatSelectat);

            if (form.ShowDialog() == DialogResult.Yes)
            {
                CalculatorViewModel.ModificaSalariat(form.Salariat);
                CalculatorViewModel.IncarcaSalariatii();
                SyncDataEvidenta();
            }
        }

        private void CalculatorSalarii_Load(object sender, EventArgs e)
        {
            reportViewer.RefreshReport();
        }

        private void fluturasSalariiButton_Click(object sender, EventArgs e)
        {
            var form = new SelectarePerioada();
            if (form.ShowDialog() == DialogResult.Yes)
            {
                var salariati = CalculatorViewModel.GetSalariati();

                var directory = AppDomain.CurrentDomain.BaseDirectory;
                var path = Path.Combine(directory, "Reports\\FluturasSalariu\\FluturasSalariuReport.rdlc");

                ReportUtils.RefreshReport(reportViewer, salariati, path, form.An, form.Luna);

                reportViewer.Visible = true;
                inchideReportButton.Visible = true;
            }
        }

        private void statPlataButton_Click(object sender, EventArgs e)
        {
            var form = new SelectarePerioada();
            if (form.ShowDialog() == DialogResult.Yes)
            {
                var salariati = CalculatorViewModel.GetSalariati();

                var directory = AppDomain.CurrentDomain.BaseDirectory;
                var path = Path.Combine(directory, "Reports\\StatPlata\\StatPlataReport.rdlc");

                ReportUtils.RefreshReport(reportViewer, salariati, path, form.An, form.Luna);

                reportViewer.Visible = true;
                inchideReportButton.Visible = true;
            }
        }

        private void inchideReportButton_Click(object sender, EventArgs e)
        {
            inchideReportButton.Visible = false;
            reportViewer.Visible = false;
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
            var salariuBaza = 0;
            var spor = 0;
            var premii = 0;
            var cas = 0;
            var cass = 0;
            var impozit = 0;
            var virat = 0;
            var retineri = 0;
            var totalBrut = 0;
            var salarImpozabil = 0;

            salariatBindingSource.Clear();

            CalculatorViewModel.SalariatiFiltrati.ForEach(s =>
            {
                salariatBindingSource.Add(s);

                salariuBaza += s.SalariuBaza;
                spor += s.ProcentSpor;
                premii += s.PremiiBrute;
                cas += s.CAS ?? 0;
                cass += s.CASS ?? 0;
                impozit += s.Impozit ?? 0;
                virat += s.ViratCard ?? 0;
                retineri += s.Retineri;
                totalBrut += s.TotalBrut ?? 0;
                salarImpozabil += s.BrutImpozabil ?? 0;
            });

            spor = spor / CalculatorViewModel.SalariatiFiltrati.Count;

            var salariat = new Salariat
            {
                Nume = "",
                Prenume = "",
                Functie = "TOTAL",
                SalariuBaza = salariuBaza,
                ProcentSpor = spor,
                PremiiBrute = premii,
                CAS = cas,
                CASS = cass,
                Impozit = impozit,
                ViratCard = virat,
                Retineri = retineri,
                TotalBrut = totalBrut,
                BrutImpozabil = salarImpozabil
            };

            salariatBindingSource.Add(salariat);
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
            sporLabel.Text = salariat.ProcentSpor + " %";
            premiiBruteLabel.Text = salariat.PremiiBrute + " RON";
            totalBrutLabel.Text = (salariat.TotalBrut ?? 0) + " RON";
            brutImpozabilLabel.Text = (salariat.BrutImpozabil ?? 0) + " RON";
            impozitLabel.Text = (salariat.Impozit ?? 0) + " RON";
            casLabel.Text = (salariat.CAS ?? 0) + " RON";
            cassLabel.Text = (salariat.CASS ?? 0) + " RON";
            retineriLabel.Text = salariat.Retineri + " RON";
            viratCardLabel.Text = (salariat.ViratCard ?? 0) + " RON";

            tableLayoutPanel1.Visible = true;

            if (salariat.Imagine != null)
            {
                var imagine = ImageUtils.ConvertByteToImage(salariat.Imagine);

                pictureBox.Image = imagine;
            }
            else
            {
                pictureBox.Image = null;
            }
        }


        #endregion

        #endregion
    }
}