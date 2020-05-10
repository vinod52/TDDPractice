using System;
using System.IO;
using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TDDPractice
{
    [TestClass]
    //[TestCategory("TDD Practice")]
    public class ComplicatedPageTest
    {        
        [TestMethod]
        public void TestMethod1()
        {                       
            var path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            var driver = new ChromeDriver(path);
            var complicatedPage = new ComplicatedPage(driver);
            complicatedPage.Open();
            complicatedPage.Search("Automation Testing");
        }
    }
}