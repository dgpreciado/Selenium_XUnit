using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using Xunit;

namespace Selenium_XUnit
{
    [Collection("Test 1")]
    public class UnitTest1
    {
        [Fact]
        public void Test1a()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.utep.edu/");
            Console.WriteLine("1a");
            driver.Quit();
        }
        [Fact]
        public void Test1b()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://www.utep.edu/");
            Console.WriteLine("1b");
            driver.Quit();
        }
    }
    [Collection("Test 2")]
    public class UnitTest2
    {
        [Fact]
        public void Test2a()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://betamy.utep.edu/My");
            Console.WriteLine("2a");
            driver.Quit();
        }
        [Fact]
        public void Test2b()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("https://betamy.utep.edu/My");
            Console.WriteLine("2b");
            driver.Quit();
        }
    }
}
