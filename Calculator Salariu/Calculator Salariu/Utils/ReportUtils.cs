using Calculator_Salariu.DAL.Model;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.SqlServer;
using System.IO;

namespace Calculator_Salariu.Utils
{
    public static class ReportUtils
    {
        public static void RefreshReport(ReportViewer report, List<Salariat> dataSet, string reportPath, string an, string luna)
        {
            report.LocalReport.ReportPath = reportPath;
            ReportDataSource rds = new ReportDataSource("SalariatiDataSet", dataSet);
            report.LocalReport.DataSources.Clear();
            report.LocalReport.DataSources.Add(rds);

            var parameters = new ReportParameter[2];
            parameters[0] = new ReportParameter("Anul", an, false);
            parameters[1] = new ReportParameter("Luna", luna, false);

            report.LocalReport.SetParameters(parameters);

            report.ResetPageSettings();

            report.RefreshReport();
            report.LocalReport.Refresh();
        }
    }
}
