using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileProcessor;
using System;
using System.Collections.Generic;
using System.Text;
using FileProcess;

namespace FileProcessor.Tests
{
    [TestClass()]
    public class TextProcessTextTests
    {

        [TestMethod()]
        public void ProcessFileTest()
        {

            TextProcess file = new TextProcess();

            file.ProcessFile("testTXT.txt");
        
            string expectedData = "Work with Text file";
            Assert.AreEqual(expectedData, file.Data);
        }
    }
}