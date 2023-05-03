using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

namespace GintarineBAIGIAMASIS
{
    public class LoginTest
    {
        static IWebDriver driver;


        [SetUp]
        public static void SETUP()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.gintarine.lt/";
            By acceptCookies = By.XPath("//div//a[@id='CybotCookiebotDialogBodyLevelButtonLevelOptinAllowAll']");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
            driver.FindElement(acceptCookies).Click();


        }
        [TearDown]
        public static void TearDown()
        {
            driver.Quit();

        }
        [Test]
        public static void UnSuccessfulTestLogin()
        {
            Thread.Sleep(2000);
            By clickLoginButton01 = By.XPath("//header//div//nav/a[@class='user-controls__link user-controls__login']");
            driver.FindElement(clickLoginButton01).Click();

            Thread.Sleep(2000);

            By inputUsername = By.XPath("(//form//div//input[@id='Email'])[1]");
            driver.FindElement(inputUsername).Click();
            driver.FindElement(inputUsername).SendKeys("random@text02.com");

            By inputPassword = By.XPath("(//form//div//input[@id='Password'])[1]");
            driver.FindElement(inputPassword).Click();
            driver.FindElement(inputPassword).SendKeys("random@text02.com");

            By clickLoginButton02 = By.XPath("//button[@class='account-controls__btn btn btn__primary btn--large account-controls__bottom-url-login']");
            driver.FindElement(clickLoginButton02).Click();

            Thread.Sleep(2000);

            By errorMessage01 = By.XPath("(//div/form/div[@class='message-error validation-summary-errors'])[1]");

            string errorText01 = driver.FindElement(errorMessage01).Text;

            if (!errorText01.Contains("Prisijungti nepavyko. Ištaisykite klaidas ir bandykite dar kartą."))
            {
                Assert.Fail("Wrong Text" + " " + "Error01 message was incorrect");
            }

            Thread.Sleep(2000);

            By errorMessage02 = By.XPath("(//ul//li[text()='Pateikti prisijungimo duomenys neteisingi'])[1]");

            string errorText02 = driver.FindElement(errorMessage02).Text;

            if (!errorText02.Contains("Pateikti prisijungimo duomenys neteisingi"))
            {
                Assert.Fail("Wrong Text" + " " + "Error02 message was incorrect");
            }

        }
        [Test]
        public static void SuccessfulTestLogin()
        {
            Thread.Sleep(2000);
            By clickLoginButton01 = By.XPath("//header//div//nav/a[@class='user-controls__link user-controls__login']");
            driver.FindElement(clickLoginButton01).Click();

            Thread.Sleep(2000);

            By inputUsername = By.XPath("(//form//div//input[@id='Email'])[1]");
            driver.FindElement(inputUsername).Click();
            driver.FindElement(inputUsername).SendKeys("Autotestmatasc@gmail.com");

            By inputPassword = By.XPath("(//form//div//input[@id='Password'])[1]");
            driver.FindElement(inputPassword).Click();
            driver.FindElement(inputPassword).SendKeys("Matasc2023");

            By clickLoginButton02 = By.XPath("//button[@class='account-controls__btn btn btn__primary btn--large account-controls__bottom-url-login']");
            driver.FindElement(clickLoginButton02).Click();

            Thread.Sleep(3000);

            By clickProfileButton = By.XPath("(//div//a[@href='/customer/info'])[2]");
            driver.FindElement(clickProfileButton).Click();

            Thread.Sleep(2000);

            By errorMessage03 = By.XPath("//div/h1");

            string errorText03 = driver.FindElement(errorMessage03).Text;

            if (!errorText03.Contains("Mano paskyra"))
            {
                Assert.Fail("Wrong Text" + " " + "incorrect MyProfile text");
            }

        }
    }
}
