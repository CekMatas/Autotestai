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

//namespace Autotestai
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

//        [Test]
//        public static void PreparePage()
//        {
//            By acceptRegionButton = By.XPath("//button[text()='Taip']");
//            driver.FindElement(acceptRegionButton).Click();

//            By acceptCookiesButton = By.XPath("//button[text()='Priimti visus']");
//            driver.FindElement(acceptCookiesButton).Click();


//        }

//        [Test]
//        public static void CheckBothTitlesAreCorrect()
//        {
//            By acceptRegionButton = By.XPath("//button[text()='Taip']");
//            driver.FindElement(acceptRegionButton).Click();

//            string ActualTitle = driver.Title;
//            string ExpectedTitle = "ENEBA žaidimų";
//            if (!ActualTitle.Contains(ExpectedTitle))
//            {
//                Assert.Fail("Wrong Title");
//            }
//            By TopMenuClick = By.XPath("//a[text()='Mobilieji']");
//            driver.FindElement(TopMenuClick).Click();

//            Thread.Sleep(2000);

//            string ActualTitle2 = driver.Title;
//            string ExpectedTitle2 = "Pigūs išmanieji ir mobilieji";
//            if (!ActualTitle2.Contains(ExpectedTitle2))
//            {
//                Assert.Fail("Wrong Title2");
//            }

//        }
//        [Test]
//        public static void CheckTitleIsCorrect1() 
//        {
//            By acceptRegionButton = By.XPath("//button[text()='Taip']");
//            driver.FindElement(acceptRegionButton).Click();

//            By TopMenuClick = By.XPath("//a[text()='Mobilieji']");
//            driver.FindElement(TopMenuClick).Click();

//            Thread.Sleep(2000);

//            string ActualTitle = driver.Title;
//            string ExpectedTitle = "Pigūs išmanieji ir mobilieji";
//            if (!ActualTitle.Contains(ExpectedTitle))
//            {
//                Assert.Fail("Wrong Title");
//            }

//        }
//        [TearDown] 
//        public static void TearDown() 
//        { 
        
//            driver.Quit();
        
//        }


//    }
//}
