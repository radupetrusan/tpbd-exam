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
    public partial class AdaugaSalariat : Form
    {
        public AdaugaSalariat()
        {
            InitializeComponent();

            Salariat = new Salariat();
        }

        public Salariat Salariat { get; set; }

        private void salvareSalariatButton_Click(object sender, EventArgs e)
        {
            Salariat.Nume = numeTextBox.Text;
            Salariat.Prenume = prenumeTextBox.Text;
            Salariat.Functie = functieTextBox.Text;
            Salariat.SalariuBaza = (int)salariuBazaNumeric.Value;
            Salariat.ProcentSpor = (int)sporNumeric.Value;
            Salariat.PremiiBrute = (int)premiiBruteNumeric.Value;
            Salariat.Retineri = (int)retineriNumeric.Value;
        }
    }
}
