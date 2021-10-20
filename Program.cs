using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace DummyFrame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#########################################################");
         
            IWebDriver webDriver = new ChromeDriver(@"C:\Users\sumit\source\repos\DummyFrame");
            webDriver.Manage().Window.Maximize();
            webDriver.Url = "https://www.tcw.com/";
        }
    }
}
