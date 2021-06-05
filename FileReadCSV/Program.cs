using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Xml;




namespace FileRead
{
    class Program
    {

        static void Main(string[] args)
        {


            //https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-from-a-text-file

            // Datable
            // https://docs.microsoft.com/en-us/dotnet/api/system.data.datatable?view=net-5.0


            //// https://stackoverflow.com/questions/17795167/xml-loaddata-data-at-the-root-level-is-invalid-line-1-position-1

            ////https://www.codingame.com/playgrounds/9014/read-write-excel-file-with-oledb-in-c-without-interop
            //string szConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\BastianHartmann\source\repos\behairedman\FileRead\FileReadCSV\xlsx\Uebungs1.xlsx; Extended Properties='Excel 12.0;'";

            string path = @"C:\Users\BastianHartmann\source\repos\behairedman\FileRead\FileReadCSV\xlsx\Uebungs1 - Kopie.xlsx";
            string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;";

            using (OleDbConnection connection = new(connStr))
            {
                connection.Open();

                OleDbDataAdapter OleDBDataAdaper = new OleDbDataAdapter("select * from [Sheet1$]", connection);
                DataSet excelDataSet = new DataSet();
                OleDBDataAdaper.Fill(excelDataSet);

                //Inhalt auf Excelmodel mappen
                //schema anschauen um header zu generieren



                //using (StreamWriter file = File.AppendText(@"C:\Users\BastianHartmann\source\repos\behairedman\FileRead\FileReadCSV\xlsx\Uebungs1 - Kopie.csv"))
                //{
                //    foreach (DataRow row in excelDataSet.Tables[0].Rows)
                //    {
                //        foreach (var column in row.ItemArray)
                //        {
                //            file.Write($"{column},");
                //        }
                //        file.WriteLine($"{Environment.NewLine}");

                //        Console.WriteLine();
                //    }
                //}




                connection.Close();
            }






        }
    }
}
