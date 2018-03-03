using Calculator_Salariu.DAL;
using Calculator_Salariu.DAL.Model;
using System.Collections.Generic;

namespace Calculator_Salariu.UI.CalculatorSalarii
{
    class CalculatorSalariiViewModel
    {
        #region Constructors

        public CalculatorSalariiViewModel()
        {
            Salariati = new List<Salariat>();
            Parametrii = new Parametrii();

            DataService = new DataService();
        }

        #endregion

        #region Properties

        public List<Salariat> Salariati { get; set; }

        public Parametrii Parametrii { get; set; }

        private DataService DataService { get; set; }

        #endregion

        #region Public Functionality

        public void IncarcaDatele()
        {
            IncarcaSalariatii();
            IncarcaParametrii();
        }

        public void IncarcaSalariatii()
        {
            Salariati = DataService.GetSalariati();
        }

        public void IncarcaParametrii()
        {
            Parametrii = DataService.GetParametrii();
        }

        public int ModificaParametrii(Parametrii parametrii)
        {
            return DataService.ModificaParametrii(parametrii);
        }

        public int ModificaParola(string parolaNoua, string parolaActuala)
        {
            return DataService.ModificaParolaParametrii(parolaNoua, parolaActuala);
        }

        #endregion
    }
}
