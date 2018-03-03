using System.Collections.Generic;
using Calculator_Salariu.DAL.Model;

namespace Calculator_Salariu.DAL
{
    public interface IDataService
    {
        int AdaugaSalariat(Salariat salariat);

        Parametrii GetParametrii();

        List<Salariat> GetSalariati();

        int ModificaParametrii(Parametrii parametrii);

        int ModificaParolaParametrii(string parolaNoua, string parolaActuala);

        int ModificaSalariat(Salariat salariat);

        int StergeSalariat(Salariat salariat);
    }
}