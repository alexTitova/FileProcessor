using FileProcess;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileProcessor
{
    public class HTMLProcess : IFileProcess
    {
        public string Data { get; set; }


        public HTMLProcess()
        {

        }


        public void ProcessFile(string filePath)
        {
            if (File.Exists(filePath) && (Path.GetExtension(filePath) == ".html"))
            {
                this.Data = "Work with HTML file";
            }
            else
            {
                throw new Exception("file does not exist or has wrong extension");
            }
        }
    }
}
