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

namespace _29Paskaita
{
    public class Cases29
    {
        static IWebDriver driver;

        [SetUp]
        public static void SETUP()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = "https://pigu.lt/lt/";
            By acceptCookies = By.XPath("//button[@class='c-btn--primary h-btn--small']");
            driver.FindElement(acceptCookies).Click();
        }
        [TearDown]
        public static void TearDown()
        {
            //driver.Quit();

        }
        [Test]
        public static void Test1()
        {
            //(//div[@id='productListLoader']//div[contains(@class,'product-list-item')]//a[@class='cover-link'])[1]

            By click1stCatButton = By.XPath("(//ul[@class='departaments-list-container']/li)[3]");
            driver.FindElement(click1stCatButton).Click();

            Thread.Sleep(1000);

            By click2ndCatButton = By.XPath("(//ul[contains(@class,'link-menu__has-submenu')]//li)[3]");
            driver.FindElement(click2ndCatButton).Click();

            By firstProduct = By.XPath("(//div[@id='productListLoader']//div[contains(@class,'product-list-item')]//a[@widget-attachpoint='imageContainer'])[10]");

            Actions action = new Actions(driver);
            action.MoveToElement(driver.FindElement(firstProduct));
            driver.FindElement(firstProduct).Click();






        }
    }
}
