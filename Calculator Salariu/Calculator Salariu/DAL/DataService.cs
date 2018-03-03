using Calculator_Salariu.DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator_Salariu.DAL
{
    public class DataService
    {
        #region Salariati

        public List<Salariat> GetSalariati()
        {
            using (var model = new ModelContainer())
            {
                return model.Salariati.ToList();
            }
        }

        public void AdaugaSalariat(Salariat salariat)
        {
            using (var model = new ModelContainer())
            {
                model.Salariati.Add(salariat);
                model.SaveChanges();
            }
        }

        public void ModificaSalariat(Salariat salariat)
        {
            using (var model = new ModelContainer())
            {
                var salariatExistent = model.Salariati.FirstOrDefault(s => s.Nr_crt == salariat.Nr_crt);

                if (salariatExistent != null)
                {
                    salariatExistent = salariat;
                    model.SaveChanges();
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
