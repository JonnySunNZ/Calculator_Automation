using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new FirefoxDriver();

            driver.Url = "https://jonnysunnz.github.io/Calculator/page.html";

            IWebElement button1 = driver.FindElement(By.XPath("/html/body/div/form/input[2]"));
            IWebElement button2 = driver.FindElement(By.XPath("/html/body/div/form/input[3]"));
            IWebElement buttonPlus = driver.FindElement(By.XPath("/html/body/div/form/input[5]"));
            IWebElement buttonEqual = driver.FindElement(By.XPath("/html/body/div/form/input[16]"));

            button1.Click();
            buttonPlus.Click();
            button2.Click();

            Thread.Sleep(2000);

            buttonEqual.Click();

        }
    }
}
