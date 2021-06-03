using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Text;
using System.IO;
using System.Xml;

namespace FileRead
{
    public class ExcelModel
    {
        public string path { get; }
        public string name { get; }
        public string[] content { get; }
        public string[] header { get; }

        //list<T> als datensatz attribut - content rausnehmen

        public ExcelModel(string filePath)
        {
            this.path = filePath;
            this.name = Path.GetFileName(filePath);

            // this.content = System.IO.File.ReadAllLines(@$"{this.path}");


        }

        public void readxlsx() //Parameter durchdenken
        {
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

                foreach (DataRow row in excelDataSet.Tables[0].Rows)
                {
                    foreach (DataColumn column in excelDataSet.Tables[0].Columns)
                    {
                        Console.WriteLine(row[1].GetType());
                    }
                }
            }

        }



    }
}
