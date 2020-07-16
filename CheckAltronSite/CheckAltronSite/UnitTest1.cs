using CheckAltronSite.PageObjects;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace CheckAltronSite
{
    [TestFixture]
    public class Tests: BaseClass
    {


        [Test]
        public void CallBackCheckField() // чек форма обратной св€зи
        {
            var mainMenu = new MainMenuPageObject(webdriver);
            Assert.IsTrue(mainMenu.CheckButtonContact()); // проверка на присутствие елемента
            mainMenu
                .SignIn()
                .CallBack(RandomDataGenerate.RandomName(), RandomDataGenerate.GeneratePhoneNumber(CountryCode.Ukraine,LengthPhoneNumber.Ukraine));

            TypeOfWait.WaitInterval();
                                 
        }

        [Test]
        public void ProductAmurA18() // чек заказ амура18
        {
            var mainMenu = new MainMenuPageObject(webdriver);
            mainMenu
                .Open()
                .AmurA18();
   
        }

        [Test]
        public void IDSN_BRI_Line() // чек бокс ISDN BRi и продукт в нем
        {
            var mainMenu = new MainMenuPageObject(webdriver);
            var PageBriLine6 = new ISDN_BRI_Line(webdriver);
            mainMenu
                .ISDNBox()
                .AmurNetBri6();
            TypeOfWait.WaitInterval();
            Assert.IsTrue(PageBriLine6.CheckButtonZakaz()); // провер€ю есть ли елемент с именем «аказать на странице продукта 
        }

        [Test]
        public void ISDN_PRi_E1() // чек бокс ISDN BRi и продукт в нем
        {
            var mainMenu = new MainMenuPageObject(webdriver);
            mainMenu
                .ISND_PRI_E1_3();                   
        }

        [Test]
        public void ForIpTelephone() // чек бокс ISDN BRi и продукт в нем
        {
            var mainMenu = new MainMenuPageObject(webdriver);
            mainMenu
                .ClickToBoxIpTelephone()
                .ClickToImage();       
        }

        [Test]

        public void ForSystemCalling()
        {
            var mainMenu = new MainMenuPageObject(webdriver); // чек бокс —истемные оповещзани€ и клик по продукту внутри
            mainMenu
                .ClickToSystemCallingBox()
                .AtrisPcIA12();           
        }

        [Test]

        public void AutonomyDevice()
        {
            var mainMenu = new MainMenuPageObject(webdriver); // чек бокс —истемные оповещзани€ и клик по продукту внутри
            mainMenu
                .ClickToBoxAutonomyDevice()
                .AmurX();            
        }

        [Test]

        public void OptionalEquipBox()
        {
            var mainMenu = new MainMenuPageObject(webdriver); // чек бокс —истемные оповещзани€ и клик по продукту внутри
            var optionalEquip = new OptionalEquipProducts(webdriver);
            mainMenu
                .ClickToOptionalEquipment()
                .AmurUSbAlarm();
            Assert.IsTrue(optionalEquip.CheckAmurusbAlarm());
        }
        [Test]
        public void ButtonDownload()
        {
            var mainMenu = new MainMenuPageObject(webdriver);
            var ListWithDownload = new ListWithDownloadFiles(webdriver);
            mainMenu
                .ButtonDownload()                
                .ClickToAmurCalculator();
                Assert.IsTrue(ListWithDownload.CheckButtonDownload()); // провер€ю наличие кнопки —качать на странице
        }

        [Test]
        public void ButtonSertificate()
        {
            var mainMenu = new MainMenuPageObject(webdriver);
            var PageCertificate = new CheckSertificateImage(webdriver);
            mainMenu
                .ClickButtonCertificate()
                .ClickToImage();
            Assert.IsTrue(PageCertificate.CheckAllImages());
        }

        [Test]
        public void Englishlang()
        {
            var mainMenu = new MainMenuPageObject(webdriver);
            mainMenu
                .ChangeLanguage();
            Assert.IsTrue(mainMenu.CheckLanguage());

        }
        [Test]
        
        public void HomePageAudioregistration()
        {
            var mainMenu = new MainMenuPageObject(webdriver);
            mainMenu
                .CheckAudioregistrationHomePage();
        }
        [Test,Order(2)] // запуск в очереди 2
        public void HomePageGPSNetMon()
        {
            var mainMenu = new MainMenuPageObject(webdriver);
            mainMenu
                .CheckHomePageGPSMon();
            Assert.IsFalse(mainMenu.CheckPageContainsGPSMon());
                
        }
        [Test]
        public void HomePageSupportImages()
        {
            var mainMenu = new MainMenuPageObject(webdriver);
            mainMenu
                .HomePageSupport();
        }

        [Test]
        public void CheckFormOrder() // чек форма обратной св€зи
        {
            var mainMenu = new ClickToButtonOrder(webdriver);
            mainMenu
                .FormOrder(RandomDataGenerate.GenerateRandowNumberWithDiapazon(), RandomDataGenerate.RandomName(),RandomDataGenerate.RandomOrganization(), RandomDataGenerate.GeneratePhoneNumber(CountryCode.Ukraine, LengthPhoneNumber.Ukraine),RandomDataGenerate.GenerateRandomEmail(EmailAdress.Gmail));
            TypeOfWait.WaitInterval();

        }
    }
}