using FileProcess;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileProcessor
{
    public class TextProcess : IFileProcess
    {

        public string Data { get; set; }
        public TextProcess()
        {

        }


        public void ProcessFile(string filePath)
        {
            if (File.Exists(filePath) && (Path.GetExtension(filePath) == ".txt"))
            {
                this.Data = "Work with Text file";
            }
            else
            {
                throw new Exception("file does not exist or has wrong extension");
            }
        }
    }
}
