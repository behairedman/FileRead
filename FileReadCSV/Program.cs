using System;
using System.Collections.Generic;


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

            // One String
            //string text = System.IO.File.ReadAllText(@"C:\Users\BastianHartmann\source\repos\behairedman\FileRead\FileReadCSV\CSVs\Output.csv");


            // As Array
            //string[] lines = System.IO.File.ReadAllLines(@"C:\Users\BastianHartmann\source\repos\behairedman\FileRead\FileReadCSV\CSVs\Output.csv");

            //string[] header = lines[0].Split(",");
            //foreach (var h in header)
            //{
            //    Console.WriteLine(h);
            //}


            // Datable
            // https://docs.microsoft.com/en-us/dotnet/api/system.data.datatable?view=net-5.0

            //CSVModel output = new CSVModel(@"C:\Users\BastianHartmann\source\repos\behairedman\FileRead\FileReadCSV\CSVs\Output.csv", ",");

            //Console.WriteLine($"{output.name}");
            //Console.WriteLine($"{output.header[0]}, {output.header[1]}, {output.header[2]}");
            //Console.WriteLine($"{output.content[0]}");

            //// https://stackoverflow.com/questions/17795167/xml-loaddata-data-at-the-root-level-is-invalid-line-1-position-1
            //XmlDocument xmlDoc = new XmlDocument();

            //XmlDocument xmlDoc = new XmlDocument();
            ////xmlDoc.Load(@"C:\Users\BastianHartmann\source\repos\behairedman\FileRead\FileReadCSV\xlsx\Uebungs1.xlsx\xl\sharedStrings.xml");

            //xmlDoc.Load(@"C:\Users\BastianHartmann\source\repos\behairedman\FileRead\FileReadCSV\xlsx\xl\sharedStrings.xml");
            //string xmlText = xmlDoc.InnerXml;

            //DataSet ds = new DataSet();
            //ds.ReadXml(@"C:\Users\BastianHartmann\source\repos\behairedman\FileRead\FileReadCSV\xlsx\xl\sharedStrings.xml");


            //Console.WriteLine(ds.Tables[2]);

            // Connect EXCEL sheet with OLEDB using connection string
            // if the File extension is .XLS using below connection string
            //In following sample 'szFilePath' is the variable for filePath
            //string szConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;
            //           "Data Source = '" + szFilePath + 
            //           "';Extended Properties=\"Excel 8.0;HDR=YES;\"";

            // if the File extension is .XLSX using below connection string






           
        }
    }
}
