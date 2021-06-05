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
        public DataSet contentDataSet { get; }

        //list<T> als datensatz attribut - content rausnehmen

        public ExcelModel(string filePath)
        {
            this.path = filePath;
            this.name = Path.GetFileName(filePath);
            // this.content = System.IO.File.ReadAllLines(@$"{this.path}");

        }

        public void readxlsxAsDataset() //Parameter durchdenken
        {
            ////https://www.codingame.com/playgrounds/9014/read-write-excel-file-with-oledb-in-c-without-interop
            //string szConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\BastianHartmann\source\repos\behairedman\FileRead\FileReadCSV\xlsx\Uebungs1.xlsx; Extended Properties='Excel 12.0;'";

            string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + path + ";Extended Properties=Excel 12.0;";

            using (OleDbConnection connection = new(connStr))
            {
                connection.Open();

                OleDbDataAdapter OleDBDataAdaper = new OleDbDataAdapter("select * from [Sheet1$]", connection);
                DataSet contentDataSet = new DataSet();
                OleDBDataAdaper.Fill(contentDataSet);

                connection.Close();
            }

        }

        public void printAsCSV( ) //pfad muss noch gesteltet werden
        {
            int number = 0;

            foreach(DataTable tab in contentDataSet.Tables)
            {
                if (File.Exists(path)) { number = number + 1; }

                using (StreamWriter file = File.AppendText($@"C:\Users\BastianHartmann\source\repos\behairedman\FileRead\FileReadCSV\xlsx\Sheet{number}.csv"))
                {
                    foreach (DataColumn col in contentDataSet.Tables[0].Columns)
                    {
                        if (col.Ordinal < contentDataSet.Tables[0].Columns[-1].Ordinal) // letztes komma
                        {
                            file.Write($"{col.ColumnName},");
                        }
                        else
                        {
                            file.Write($"{col.ColumnName}");
                        }
                    }

                    foreach (DataRow row in contentDataSet.Tables[0].Rows)
                    {
                        foreach (object[] column in row.ItemArray)
                        {
                         file.Write($"{column},");
                        }

                        file.WriteLine($"{Environment.NewLine}");
                    }
                }
                
            }
        }



    }
}
