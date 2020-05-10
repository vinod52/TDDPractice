using OpenQA.Selenium;
using System;

namespace TDDPractice
{
    public class ComplicatedPage
    {
        public ComplicatedPage(IWebDriver driver)
        {
            Driver = driver;
        }

        public IWebDriver Driver { get; }
        internal void Open()
        {
            Driver.Navigate().GoToUrl("https://ultimateqa.com/complicated-page/");
            Driver.Manage().Window.Maximize();
        }

        internal void Search(string SearchTerm)
        {
            Driver.FindElement(By.XPath("(//div/input[@id='s'])[1]")).SendKeys(SearchTerm);
            Driver.FindElement(By.XPath("(//input[@id='searchsubmit'])[1]")).Click();
        }
    }
}