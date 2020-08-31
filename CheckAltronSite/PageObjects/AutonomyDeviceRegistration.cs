using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CheckAltronSite.PageObjects
{
    class AutonomyDeviceRegistration
    {
        private IWebDriver webDriver;
        private readonly By _AmurX = By.ClassName("item-172");

        public AutonomyDeviceRegistration(IWebDriver webDriver)
        {
            this.webDriver = webDriver;
        }

        public MainMenuPageObject AmurX()
        {
            webDriver.FindElement(_AmurX).Click();
            TypeOfWait.ShouldLocate(webDriver, "http://altron.ua/audio-registratory-amur/avtonomnye-ustrojstva-registratsii/amur-x.html");

            return new MainMenuPageObject(webDriver);
        }

    }
}
