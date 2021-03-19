using FileProcess;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileProcessor
{
    public class JSONProcess : IFileProcess
    {
        public string Data { get; set; }


        public JSONProcess()
        {

        }


        public void ProcessFile(string filePath)
        {
            if (File.Exists(filePath) && (Path.GetExtension(filePath) == ".json"))
            {
                this.Data = "Work with JSON file";
            }
            else
            {
                throw new Exception("file does not exist or has wrong extension");
            }
        }
    }
}
