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
        public static DataSet GenereazaDataSet(List<Salariat> salariati)
        {
            //var dataSet = new DataSet();

            var dataSet = ToDataSet<Salariat>(salariati);

            return dataSet;   
        }

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

            //report.ResetPageSettings();
            report.RefreshReport();
            report.LocalReport.Refresh();
        }

        private static DataSet ToDataSet<T>(this IList<T> list)
        {
            Type elementType = typeof(T);
            DataSet ds = new DataSet();
            DataTable t = new DataTable();
            ds.Tables.Add(t);

            //add a column to table for each public property on T
            foreach (var propInfo in elementType.GetProperties())
            {
                Type ColType = Nullable.GetUnderlyingType(propInfo.PropertyType) ?? propInfo.PropertyType;

                t.Columns.Add(propInfo.Name, ColType);
            }

            //go through each property on T and add each value to the table
            foreach (T item in list)
            {
                DataRow row = t.NewRow();

                foreach (var propInfo in elementType.GetProperties())
                {
                    row[propInfo.Name] = propInfo.GetValue(item, null) ?? DBNull.Value;
                }

                t.Rows.Add(row);
            }

            return ds;
        }
    }
}
