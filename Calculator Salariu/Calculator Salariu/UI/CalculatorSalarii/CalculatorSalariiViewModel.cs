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
            SalariatiFiltrati = new List<Salariat>();
            Parametrii = new Parametrii();
            Filtru = "";

            DataService = new DataService();

            SalariatSelectat = new Salariat { Nume = "", Prenume = "", Functie = "" };
        }

        #endregion

        #region Properties

        public List<Salariat> Salariati { get; set; }
        public List<Salariat> SalariatiFiltrati { get; set; }

        public Parametrii Parametrii { get; set; }

        private IDataService DataService { get; set; }

        public Salariat SalariatSelectat { get; set; }

        public string Filtru { get; set; }

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
            Filtrare();
        }

        public List<Salariat> GetSalariati()
        {
            return DataService.GetSalariati();
        }

        public void Filtrare()
        {
            if (string.IsNullOrWhiteSpace(Filtru))
            {
                SalariatiFiltrati = Salariati;
            }
            else
            {
                SalariatiFiltrati = new List<Salariat>();
                Salariati.ForEach(s =>
                {
                    if (s.Nume.ToLower().Contains(Filtru) || s.Prenume.ToLower().Contains(Filtru) || s.Functie.ToLower().Contains(Filtru))
                    {
                        SalariatiFiltrati.Add(s);
                    }
                });
            }
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

        public int AdaugaSalariat(Salariat salariat)
        {
            return DataService.AdaugaSalariat(salariat);
        }

        public int StergeSalariat(Salariat salariat)
        {
            return DataService.StergeSalariat(salariat);
        }

        public int ModificaSalariat(Salariat salariat)
        {
            return DataService.ModificaSalariat(salariat);
        }

        #endregion
    }
}
