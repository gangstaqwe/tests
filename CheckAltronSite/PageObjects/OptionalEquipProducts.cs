using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckAltronSite.PageObjects
{
    class OptionalEquipProducts
    {
        private IWebDriver webDriver;
        private readonly By _AmurUSBAlarm = By.CssSelector("div h2 a[href='/audio-registratory-amur/dopolnitelnoe-oborudovanie/amur-usb-alarm-detail.html']");
        private static string _DisplayAmurUsbAlarm = "AMUR-USB-Alarm";
        public OptionalEquipProducts(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public MainMenuPageObject AmurUSbAlarm()
        {
            webDriver.FindElement(_AmurUSBAlarm).Click();
            return new MainMenuPageObject(webDriver);
        }

        public bool CheckAmurusbAlarm()
        {
            try
            {
                webDriver.PageSource.Contains(_DisplayAmurUsbAlarm);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }

    }
}

