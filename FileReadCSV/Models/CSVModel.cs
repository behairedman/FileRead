using System;
using System.Collections.Generic;
using System.Text;
using System.IO;


// escaping https://www.codeproject.com/articles/371232/escaping-in-csharp-characters-strings-string-forma


namespace FileRead
{
    public class CSVModel
    {
        public string path { get; }
        public string name { get; }
        public string delimiter { get; }
        public string[] content { get; }
        public string[] header { get; }


        public CSVModel() { }

        public CSVModel(string filePath, string delimiter)
        {
            this.path = filePath;
            this.name = Path.GetFileName(filePath);
            this.delimiter = delimiter;

            this.content = System.IO.File.ReadAllLines(@$"{this.path}");

            this.header = content[0].Split(delimiter);

            for (int i = 0; i < this.content.Length - 1; i++)
            {
                this.content[i] = this.content[i + 1];
            }

        }








    }
}
