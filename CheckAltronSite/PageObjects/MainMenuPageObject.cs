using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace CheckAltronSite.PageObjects
{
    class MainMenuPageObject
    {
        private IWebDriver webdriver;

        private readonly By _ContactButton = By.XPath("//a [@id='callback']");
        private readonly By _ProductAmurA18 = By.XPath("//li [@class='item-120']");
        private readonly By _ISDN_LINE_Box = By.XPath("//a [@href='/audio-registratory-amur/dlya-tsifrovykh-linij-isdn-bri.html']");
        private readonly By _ISDN_PRI_E1_3 = By.XPath("//a[@href='/audio-registratory-amur/dlya-tsifrovykh-linij-isdn-pri-e1.html']");
        private readonly By _ForIpTelephone = By.XPath("//a[text()='Для IP телефонии']");
        private readonly By _SystemCalling = By.CssSelector("li a[href='/audio-registratory-amur/sistema-opoveshcheniya.html']");
        private readonly By _AutonomyDeviceRegistraion = By.CssSelector("div ul li a[href='/audio-registratory-amur/avtonomnye-ustrojstva-registratsii.html']");
        private readonly By _OptionalEquipment = By.CssSelector("div ul li li a[href='/audio-registratory-amur/dopolnitelnoe-oborudovanie.html']");
        private readonly By _ButtonDownload = By.CssSelector("div ul li a[href='/skachat.html']");
        private readonly By _ButtonSertificate = By.CssSelector("a[href='/certifikaty.html']");
        private readonly By _ChangedLanguage = By.CssSelector("li a[href='/en/']");      
        private readonly By _ElementAudioRegistration = By.CssSelector("ul li[title='Аудиорегистраторы']");
        private readonly By _ImagesAudioregistration = By.CssSelector("p a[href='/audio-registratory-amur.html']");
        private readonly By _GPSNetMonitorImage = By.CssSelector("ul li[title='GPS мониторинг']");
        private readonly By _ImagesGPSMon = By.CssSelector("img[src='/images/slide_2.png']");
        private readonly By _ButtonSupport = By.CssSelector("li[title='Поддержка']");
        private readonly By _WaitImagesSupport = By.CssSelector("p a img[src='/images/slide_3.png']");



        public MainMenuPageObject(IWebDriver webdriver)
        {
            this.webdriver = webdriver;
        }
        
        public CallBackPageObject SignIn() // клик на контакты
        {       
            webdriver.FindElement(_ContactButton).Click();
            return new CallBackPageObject(webdriver);
        }

        public ProductAmurA18 Open() // клик на Амур18
        {
            webdriver.FindElement(_ProductAmurA18).Click();
            return new ProductAmurA18(webdriver);
        }

        public ISDN_BRI_Line ISDNBox() // клик на бокс
        {
            webdriver.FindElement(_ISDN_LINE_Box).Click();
            return new ISDN_BRI_Line(webdriver);
        }

        public void ISND_PRI_E1_3() // клик на цифровые линии
        {
            webdriver.FindElement(_ISDN_PRI_E1_3).Click();
            TypeOfWait.WaitElement(webdriver,_ISDN_PRI_E1_3);
            
        }

        public ForIPTelephone ClickToBoxIpTelephone() // клик на Ip телефонию
        {
            webdriver.FindElement(_ForIpTelephone).Click();
            return new ForIPTelephone(webdriver);
        }

        public AtrisPCIA_12 ClickToSystemCallingBox() // кликаю на системные оповещания
        {
            webdriver.FindElement(_SystemCalling).Click();
            return new AtrisPCIA_12(webdriver);
        }

        public AutonomyDeviceRegistration ClickToBoxAutonomyDevice()
        {
            webdriver.FindElement(_AutonomyDeviceRegistraion).Click();
            return new AutonomyDeviceRegistration(webdriver);
        }
       
        public OptionalEquipProducts ClickToOptionalEquipment()
        {
            webdriver.FindElement(_OptionalEquipment).Click();
            return new OptionalEquipProducts(webdriver);
        }

        public bool CheckButtonContact() // проверяю наличие элемента та странице
        {
            try
            {
                webdriver.FindElement(_ContactButton);
                return true;
            }
            catch(NoSuchElementException)
            {
                return false;
            }
        }

        public ListWithDownloadFiles ButtonDownload()
        {
            webdriver.FindElement(_ButtonDownload).Click();
            TypeOfWait.WaitInterval();
            return new ListWithDownloadFiles(webdriver);
        }

        public CheckSertificateImage ClickButtonCertificate()
        {
            TypeOfWait.WaitInterval();
            webdriver.FindElement(_ButtonSertificate).Click();
            return new CheckSertificateImage(webdriver);
        }

        public void ChangeLanguage()
        {
            webdriver.FindElement(_ChangedLanguage).Click();
            TypeOfWait.WaitInterval();
        }
       

        public void CheckAudioregistrationHomePage()
        {
            webdriver.FindElement(_ElementAudioRegistration).Click();
            TypeOfWait.WaitElement(webdriver, _ImagesAudioregistration);
            Assert.IsTrue(webdriver.FindElement(_ImagesAudioregistration).Displayed);
        }

        public void CheckHomePageGPSMon(string html_fragment = "GPS мониторинг")
        {
            webdriver.FindElement(_GPSNetMonitorImage).Click();
            TypeOfWait.WaitInterval();
            Assert.IsTrue(webdriver.FindElement(_ImagesGPSMon).Displayed); // проверяю что отображается картинка
            webdriver.FindElement(_ImagesGPSMon).Click();
            Assert.IsTrue(webdriver.PageSource.Contains(html_fragment));

        }    

        public void HomePageSupport()
        {
            webdriver.FindElement(_ButtonSupport).Click();
            TypeOfWait.WaitInterval();
            Assert.IsTrue(webdriver.FindElement(_WaitImagesSupport).Displayed);
            webdriver.FindElement(_WaitImagesSupport).Click();
        }
 
    }
}
