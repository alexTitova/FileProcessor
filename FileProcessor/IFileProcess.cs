using System;
using System.Collections.Generic;
using System.Text;

namespace FileProcess
{
    interface IFileProcess
    {
        string Data { get; set; }
        void ProcessFile(string filePath);
    }
}
