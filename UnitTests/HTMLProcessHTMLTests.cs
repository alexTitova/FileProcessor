using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileProcessor;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileProcessor.Tests
{
    [TestClass()]
    public class HTMLProcessHTMLTests
    {

        [TestMethod()]
        public void ProcessFileTest()
        {
            HTMLProcess file = new HTMLProcess();
            file.ProcessFile("testHTML.html");
            string expectedData = "Work with HTML file";
            Assert.AreEqual(expectedData, file.Data);
        }
    }
}