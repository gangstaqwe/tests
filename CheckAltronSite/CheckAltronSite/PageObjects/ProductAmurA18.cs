using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CheckAltronSite.PageObjects
{
    class ProductAmurA18
    {
        private IWebDriver webdriver;

        private readonly By _ButtonZakazAmurA18 = By.XPath("//a [@class='zakaz']"); 

        public ProductAmurA18(IWebDriver webdriver)
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
