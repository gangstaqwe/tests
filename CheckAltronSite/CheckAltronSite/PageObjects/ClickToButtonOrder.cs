using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CheckAltronSite.PageObjects
{
    class ClickToButtonOrder
    {
        private IWebDriver webdriver;
        private readonly By _FieldKanal = By.CssSelector("input[name='kanal']");
        private readonly By _FieldName = By.CssSelector("input[id='nam']");
        private readonly By _FieldOrganization = By.CssSelector("input[id='​​org']");
        private readonly By _FieldPhone = By.CssSelector("input[id='telefn']");
        private readonly By _FielMail = By.CssSelector("input[id='bmail']");
        private readonly By _ButtonWaitZakazat = By.ClassName("zakazat");
        

        public ClickToButtonOrder(IWebDriver webdriver)
        {
            this.webdriver = webdriver;
        }

        public MainMenuPageObject FormOrder(string chanell, string name, string org, string phone,string mail)
        {
            webdriver.Navigate().GoToUrl(TestSettings.UrlToOrderProduct);
            TypeOfWait.WaitElement(webdriver, _ButtonWaitZakazat);
            webdriver.FindElement(_FieldKanal).SendKeys(chanell);
            webdriver.FindElement(_FieldName).SendKeys(name);
            webdriver.FindElement(_FieldOrganization).SendKeys(org);
            webdriver.FindElement(_FieldPhone).SendKeys(phone);            
            webdriver.FindElement(_FielMail).SendKeys(mail);
            TypeOfWait.WaitInterval(2);
            return new MainMenuPageObject(webdriver);


        }

    }
}