using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckAltronSite.PageObjects
{
    class ForIPTelephone
    {
        private IWebDriver webdriver;
        private readonly By _ClickToImagesIptelephone = By.XPath("//img[@src='/images/stories/virtuemart/product/resized/voip_1_novyj-razmer9_resize_212x500.jpg']");

        public ForIPTelephone(IWebDriver webdriver)
        {
            this.webdriver = webdriver;
        }

        public MainMenuPageObject ClickToImage() // клик на продукт относящийся к IP телефонии
        {
            TypeOfWait.WaitElement(webdriver, _ClickToImagesIptelephone);
            webdriver.FindElement(_ClickToImagesIptelephone).Click();
            return new MainMenuPageObject(webdriver);
        }

    }
}
