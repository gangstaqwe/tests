using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace CheckAltronSite.PageObjects
{
    class CallBackPageObject
    {
        private IWebDriver webdriver;

        private readonly By _ContactPhone = By.XPath("//input [@name='call_phone']");
        private readonly By _ContactName = By.XPath("//input [@name='call_name']");
        private readonly By _ButtonSend = By.CssSelector("div form input[value='Отправить!']");


        public CallBackPageObject(IWebDriver webdriver)
        {
            this.webdriver = webdriver;
        }

        public MainMenuPageObject CallBack(string login, string Number)
        {     
            webdriver.FindElement(_ContactPhone).SendKeys(Number);
            TypeOfWait.WaitInterval();
            webdriver.FindElement(_ContactName).SendKeys(login);
            TypeOfWait.WaitElement(webdriver,_ButtonSend); // жду елемента
            return new MainMenuPageObject(webdriver);
        }

    }
}
