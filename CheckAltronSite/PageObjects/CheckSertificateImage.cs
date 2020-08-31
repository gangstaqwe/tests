using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckAltronSite.PageObjects
{
    class CheckSertificateImage
    {
        private IWebDriver webdriver;

        private readonly By _CheckImageDisplay = By.CssSelector("p a img[src='/images/thumbnails/images/002-200x275.jpg']");
        private readonly string _component = "component";


        public CheckSertificateImage(IWebDriver webdriver)
        {
            this.webdriver = webdriver;
        }

        public MainMenuPageObject ClickToImage()
        {
            webdriver.FindElement(_CheckImageDisplay).Click();
            return new MainMenuPageObject(webdriver);
            
        }

        public bool CheckAllImages()
        {
            try
            {
                webdriver.PageSource.Contains(_component);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
    }


}
