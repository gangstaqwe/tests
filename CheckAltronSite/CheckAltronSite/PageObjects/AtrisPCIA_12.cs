using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CheckAltronSite.PageObjects
{

    class AtrisPCIA_12
    {

        private IWebDriver webdriver;
        private readonly By _ProductAtrisPCI_A12 = By.CssSelector("div h2 a[href='/audio-registratory-amur/sistema-opoveshcheniya/atris-pci-a-12.html']");

        public AtrisPCIA_12(IWebDriver webdriver)
        {
            this.webdriver = webdriver;
        }

        public MainMenuPageObject AtrisPcIA12()
        {
            TypeOfWait.WaitElement(webdriver, _ProductAtrisPCI_A12);
            webdriver.FindElement(_ProductAtrisPCI_A12).Click();
            
            return new MainMenuPageObject(webdriver);
        }
    }
}
