using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace CheckAltronSite.PageObjects
{
    class ListWithDownloadFiles
    {
        private IWebDriver webdriver;
        private readonly By _AmurCalculatorClick = By.XPath("//a[text()='AMUR-Calculator']");
        private readonly By _CheckButtonDownload = By.CssSelector(".pd-buttons .pd-button-download");
        public ListWithDownloadFiles(IWebDriver webdriver)
        {
            this.webdriver = webdriver;
        }

        public MainMenuPageObject ClickToAmurCalculator()
        {
            webdriver.FindElement(_AmurCalculatorClick).Click();

            return new MainMenuPageObject(webdriver);
        }

        public bool CheckButtonDownload() // проверяю наличие элемента та странице
        {
            try
            {
                webdriver.FindElement(_CheckButtonDownload);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }
}
