using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CheckAltronSite.PageObjects
{
    class CheckFormOrderProduct
    {
        private IWebDriver webdriver;

        private readonly By _ButtonZakazAmurA18 = By.XPath("//a [@class='zakaz']"); // плохой хпас

        public CheckFormOrderProduct(IWebDriver webdriver)
        {
            this.webdriver = webdriver;
        }

        public MainMenuPageObject AmurA18() // клик на кноаку заказ
        {
            TypeOfWait.WaitElement(webdriver, _ButtonZakazAmurA18);
            webdriver.FindElement(_ButtonZakazAmurA18).Click();
            TypeOfWait.WaitInterval();

            return new MainMenuPageObject(webdriver);
        }
    }
}