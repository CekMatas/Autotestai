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

//namespace _28paskaita
//{
//    public class Tests
//    {
//        static IWebDriver driver;

//        [SetUp]
//        public static void SETUP()
//        {
//            driver = new ChromeDriver();
//            driver.Manage().Window.Maximize();
//            driver.Url = "https://www.saucedemo.com/";
//        }
//        [TearDown]
//        public static void TearDown()
//        {
//            //driver.Quit();
//        }
//        [Test]
//        public static void LoginSuccessTest()
//        {
//            By loginUsername = By.XPath("//input[@name='user-name']");
//            By loginPassword = By.XPath("//input[@name='password']");
//            By loginButton = By.Id("login-button");

//            driver.FindElement(loginUsername).SendKeys("standard_user");
//            driver.FindElement(loginPassword).SendKeys("secret_sauce");
//            driver.FindElement(loginButton).Click();

//            By cart = By.Id("shopping_cart_container");


//            if (!driver.FindElement(cart).Displayed)
//            {
//                Assert.Fail("FAILED");
//            }



//        }
//        [Test]
//        public static void LoginLockedOutTest()
//        {
//            By loginUsername = By.Id("user-name");
//            By loginPassword = By.XPath("//input[@name='password']");
//            By loginButton = By.Id("login-button");

//            driver.FindElement(loginUsername).SendKeys("locked_out_user");
//            driver.FindElement(loginPassword).SendKeys("secret_sauce");
//            driver.FindElement(loginButton).Click();

//            By errorMessage = By.XPath("//h3[@data-test='error']");
//            string errorText = driver.FindElement(errorMessage).Text;


//            if (!errorText.Contains("Epic sadface: Sorry, this user has been locked out."))
//            {
//                Assert.Fail("FAILED");
//            }



//        }
//    }
//}
