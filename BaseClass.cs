using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading;


namespace CheckAltronSite
{
    public class BaseClass
    {
        protected IWebDriver webdriver;

       /* [OneTimeSetUp] // выполнять один раз
        protected void DoBeforeAllTheTests()
        {
            webdriver = new ChromeDriver();
        }
       */
        /*[OneTimeTearDown]

        protected void DoAfterAllTheTests()
        {

        }
        */
        [SetUp] // выполнять каждый раз перед запуском теста

        public void DobeforeEach()
        {
            webdriver = new ChromeDriver();
            webdriver.Manage().Cookies.DeleteAllCookies();
            webdriver.Navigate().GoToUrl(TestSettings.HostPrefix);
            TypeOfWait.ShouldLocate(webdriver, "http://altron.ua/"); // проверка на то что я нахожусь именно на этой странице
            webdriver.Manage().Window.Maximize();
            
        }

        [TearDown]
        
        protected void DoAfterEach()
        {
            webdriver.Quit();
        }
    }
}
