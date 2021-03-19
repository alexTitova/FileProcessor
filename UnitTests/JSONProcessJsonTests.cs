using Microsoft.VisualStudio.TestTools.UnitTesting;
using FileProcessor;
using System;
using System.Collections.Generic;
using System.Text;

namespace FileProcessor.Tests
{
    [TestClass()]
    public class JSONProcessJsonTests
    {

        [TestMethod()]
        public void ProcessFileTest()
        {
            JSONProcess file = new JSONProcess();
            file.ProcessFile("testJson.json");
            string expectedData = "Work with JSON file";
            Assert.AreEqual(expectedData, file.Data);
        }
    }
}