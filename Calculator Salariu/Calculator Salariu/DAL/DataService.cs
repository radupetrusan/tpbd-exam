using Calculator_Salariu.DAL.Model;
using System.Collections.Generic;
using System.Linq;

namespace Calculator_Salariu.DAL
{
    public class DataService : IDataService
    {
        #region Salariati

        public List<Salariat> GetSalariati()
        {
            using (var model = new ModelContainer())
            {
                return model.Salariati.ToList();
            }
        }

        public int AdaugaSalariat(Salariat salariat)
        {
            using (var model = new ModelContainer())
            {
                try
                {
                    model.Salariati.Add(salariat);
                    model.SaveChanges();

                    return 1;
                }
                catch
                {
                    return -1;
                }
                
            }
        }

        public int ModificaSalariat(Salariat salariat)
        {
            using (var model = new ModelContainer())
            {
                try
                {
                    var salariatExistent = model.Salariati.FirstOrDefault(s => s.Nr_crt == salariat.Nr_crt);

                    if (salariatExistent != null)
                    {
                        salariatExistent.Nume = salariat.Nume;
                        salariatExistent.Prenume = salariat.Prenume;
                        salariatExistent.Functie = salariat.Functie;

                        salariatExistent.SalariuBaza = salariat.SalariuBaza;
                        salariatExistent.ProcentSpor = salariat.ProcentSpor;
                        salariatExistent.Retineri = salariat.Retineri;
                        salariatExistent.PremiiBrute = salariat.PremiiBrute;

                        salariatExistent.Imagine = salariat.Imagine;

                        model.SaveChanges();
                    }

                    return 1;
                }
                catch
                {
                    return -1;
                }
                
            }
        }

        public int StergeSalariat(Salariat salariat)
        {
            using (var model = new ModelContainer())
            {
                try
                {
                    var salariatExistent = model.Salariati.FirstOrDefault(s => s.Nr_crt == salariat.Nr_crt);

                    model.Salariati.Remove(salariatExistent);
                    model.SaveChanges();

                    return 1;
                }
                catch
                {
                    return -1;
                }
                
            }
        }

        #endregion

        #region Parametrii

        public Parametrii GetParametrii()
        {
            using (var model = new ModelContainer())
            {
                var parametrii = model.Parametrii.FirstOrDefault();

                if (parametrii == null)
                {
                    parametrii = new Parametrii();
                }

                return parametrii;
            }
        }

        public int ModificaParametrii(Parametrii parametrii)
        {
            using (var model = new ModelContainer())
            {
                Parametrii parametriiExistenti;

                if ((parametriiExistenti = model.Parametrii.SingleOrDefault()) != null)
                {
                    if (parametriiExistenti.Parola.Equals(parametrii.Parola))
                    {
                        parametriiExistenti.CAS = parametrii.CAS;
                        parametriiExistenti.CASS = parametrii.CASS;
                        parametriiExistenti.Impozit = parametrii.Impozit;

                        model.SaveChanges();

                        return 1;
                    }

                    return -1;

                }
                else
                {
                    model.Parametrii.Add(parametrii);
                    model.SaveChanges();

                    return 1;
                }

            }
        }

        public int ModificaParolaParametrii(string parolaNoua, string parolaActuala)
        {
            using (var model = new ModelContainer())
            {
                var parametrii = model.Parametrii.SingleOrDefault();

                if (parametrii != null)
                {
                    if (parametrii.Parola.Equals(parolaActuala))
                    {
                        parametrii.Parola = parolaNoua;
                        model.SaveChanges();

                        return 1;
                    }

                    return -1;
                }

                return 0;
            }
        }

        #endregion
    }
}