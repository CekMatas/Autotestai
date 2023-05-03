using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Net.WebRequestMethods;

//namespace Autotestai27
//{
//    internal class OtherCases
//    {
//        static IWebDriver driver;

//        [SetUp]
//        public static void SetUp()
//        {
//            driver = new ChromeDriver();
//            driver.Manage().Window.Maximize();
//            driver.Url = "https://www.eneba.com/";
//        }

//        [TearDown]
//        public static void TearDown()
//        {
//            //driver.Quit();
//        }

//        [Test]
//        public static void CheckGame()
//        {
//            MainMethods.acceptRegion(driver, "//button[text()='Taip']");
//            MainMethods.acceptCookies(driver, "//button[text()='Priimti visus']");
//            MainMethods.sendKeys(driver, "//input[@type='text']", "Playstation 5 Legacy");

//            Thread.Sleep(3000);

//            By chooseGame = By.XPath("//a[@href='/lt/hogwarts-legacy-playstation-5']");
//            driver.FindElement(chooseGame).Click();

//            Thread.Sleep(3000);

//            string expectedText = "Hogwarts Legacy PlayStation 5";

//            MainMethods.checkElementText(driver, "//h1[text()='Hogwarts Legacy PlayStation 5']", expectedText);

//        }
//        [Test]
//        public static void LoginToWebsite()
//        {
//            MainMethods.acceptRegion(driver, "//button[text()='Taip']");
//            MainMethods.acceptCookies(driver, "//button[text()='Priimti visus']");
//            MainMethods.clickElementForLogin(driver, "//a[@class='M4h6iN']");
//            MainMethods.enterUsername(driver, "//input[@type='email']", "Matas@Cekanas");
//            MainMethods.enterPassword(driver, "//input[@type='password']", "slaptikas");
//            MainMethods.clickElementForLogin(driver, "//button[@type='submit']");

//        }

//    }
//}
