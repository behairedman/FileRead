using System;
using System.Collections.Generic;
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


        public ExcelModel(string filePath)
        {
            this.path = filePath;
            this.name = Path.GetFileName(filePath);

            // this.content = System.IO.File.ReadAllLines(@$"{this.path}");

            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(this.path);


        }

    }



}
