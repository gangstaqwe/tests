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
        public void CallBackCheckField() // ��� ����� �������� �����
        {
            var mainMenu = new MainMenuPageObject(webdriver);
            Assert.IsTrue(mainMenu.CheckButtonContact()); // �������� �� ����������� ��������
            mainMenu
                .SignIn()
                .CallBack(RandomDataGenerate.GenerateRandomEmail(EmailAdress.Mail), RandomDataGenerate.GeneratePhoneNumber(CountryCode.Ukraine,LengthPhoneNumber.Ukraine));

            TypeOfWait.WaitInterval();
                                 
        }

        [Test]
        public void ProductAmurA18() // ��� ����� �����18
        {
            var mainMenu = new MainMenuPageObject(webdriver);
            mainMenu
                .Open()
                .AmurA18();
   
        }

        [Test]
        public void IDSN_BRI_Line() // ��� ���� ISDN BRi � ������� � ���
        {
            var mainMenu = new MainMenuPageObject(webdriver);
            var PageBriLine6 = new ISDN_BRI_Line(webdriver);
            mainMenu
                .ISDNBox()
                .AmurNetBri6();
            TypeOfWait.WaitInterval();
            Assert.IsTrue(PageBriLine6.CheckButtonZakaz()); // �������� ���� �� ������� � ������ �������� �� �������� �������� 
        }

        [Test]
        public void ISDN_PRi_E1() // ��� ���� ISDN BRi � ������� � ���
        {
            var mainMenu = new MainMenuPageObject(webdriver);
            mainMenu
                .ISND_PRI_E1_3();                   
        }

        [Test]
        public void ForIpTelephone() // ��� ���� ISDN BRi � ������� � ���
        {
            var mainMenu = new MainMenuPageObject(webdriver);
            mainMenu
                .ClickToBoxIpTelephone()
                .ClickToImage();       
        }

        [Test]

        public void ForSystemCalling()
        {
            var mainMenu = new MainMenuPageObject(webdriver); // ��� ���� ��������� ����������� � ���� �� �������� ������
            mainMenu
                .ClickToSystemCallingBox()
                .AtrisPcIA12();           
        }

        [Test]

        public void AutonomyDevice()
        {
            var mainMenu = new MainMenuPageObject(webdriver); // ��� ���� ��������� ����������� � ���� �� �������� ������
            mainMenu
                .ClickToBoxAutonomyDevice()
                .AmurX();            
        }

        [Test]

        public void OptionalEquipBox()
        {
            var mainMenu = new MainMenuPageObject(webdriver); // ��� ���� ��������� ����������� � ���� �� �������� ������
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
                Assert.IsTrue(ListWithDownload.CheckButtonDownload()); // �������� ������� ������ ������� �� ��������
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
        [Test,Order(2)] // ������ � ������� 2
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
        public void CheckFormOrder() // ��� ����� �������� �����
        {
            var mainMenu = new ClickToButtonOrder(webdriver);
            mainMenu
                .FormOrder(RandomDataGenerate.GenerateRandowNumberWithDiapazon(), RandomDataGenerate.RandomName(),RandomDataGenerate.RandomOrganization(), RandomDataGenerate.GeneratePhoneNumber(CountryCode.Ukraine, LengthPhoneNumber.Ukraine),RandomDataGenerate.GenerateRandomEmail(EmailAdress.Gmail));
            TypeOfWait.WaitInterval();

        }
    }
}