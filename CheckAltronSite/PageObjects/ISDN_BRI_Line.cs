using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CheckAltronSite.PageObjects
{
    class ISDN_BRI_Line
    {
        private IWebDriver webdriver;
        private readonly By _ProductAmurNetBri6 = By.XPath("//img[@src='/images/stories/virtuemart/product/resized/amur-net-bri-64_212x500.jpg']");
        private readonly string _zakaz = "zakaz";

        public ISDN_BRI_Line(IWebDriver webdriver)
        {
            this.webdriver = webdriver;
        }


        public MainMenuPageObject AmurNetBri6() // метод нажатия на пролукт Амур бри
        {
            webdriver.FindElement(_ProductAmurNetBri6).Click();           
            return new MainMenuPageObject(webdriver);
        }

        public bool CheckButtonZakaz()
        {
            try
            {
                webdriver.PageSource.Contains(_zakaz);
                return true;
            }
            catch(NoSuchElementException)
            {
                return false;
            }
        }

    }
}
