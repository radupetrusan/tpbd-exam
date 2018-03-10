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
    public partial class SelectarePerioada : Form
    {
        public string Luna { get; set; }

        public string An { get; set; }

        public SelectarePerioada()
        {
            InitializeComponent();

            var anCurent = DateTime.Now.Year;
            var lunaCurenta = DateTime.Now.Month;
            anComboBox.Items.Add(anCurent - 1);
            anComboBox.Items.Add(anCurent);
            anComboBox.Items.Add(anCurent + 1);

            anComboBox.SelectedIndex = 1;
            lunaComboBox.SelectedIndex = lunaCurenta - 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Luna = lunaComboBox.Text;
            An = anComboBox.Text;
        }
    }
}
