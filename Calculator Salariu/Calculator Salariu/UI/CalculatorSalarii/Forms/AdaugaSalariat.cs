using Calculator_Salariu.DAL.Model;
using Calculator_Salariu.Utils;
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

        private void browseImageButton_Click(object sender, EventArgs e)
        {
            var dialog = new OpenFileDialog();
            dialog.Multiselect = false;
            dialog.Title = "Vă rugăm să alegeți o poză";
            dialog.Filter = "JPG|*.jpg|PNG|*.png";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                if (!string.IsNullOrWhiteSpace(dialog.FileName))
                {
                    pictureBox.ImageLocation = dialog.FileName;
                    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

                    Salariat.Imagine = ImageUtils.ConvertFileToByte(pictureBox.ImageLocation);
                }
            }
        }
    }
}
