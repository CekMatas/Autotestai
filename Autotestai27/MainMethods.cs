using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Autotestai27
{
    internal class MainMethods
    {
        public static void acceptRegion(IWebDriver driver, string xpath)
        {
            By acceptRegionButton = By.XPath(xpath);
            driver.FindElement(acceptRegionButton).Click();
        }
        public static void acceptCookies(IWebDriver driver, string xpath)
        {
            By acceptCookiesButton = By.XPath(xpath);
            driver.FindElement(acceptCookiesButton).Click();
        }
        public static void sendKeys(IWebDriver driver, string xpath, string input)
        {
            By InputField = By.XPath(xpath);
            driver.FindElement(InputField).SendKeys(input);

        }
        public static void checkElementText(IWebDriver driver, string xpath, string expectedText)
        {
            By resaultText = By.XPath(xpath);
            string actualText = driver.FindElement(resaultText).Text;
            Assert.AreEqual(expectedText, actualText);

        }
        public static void clickElementForLogin(IWebDriver driver, string xpath)
        {
            By clickElement = By.XPath(xpath);
            driver.FindElement(clickElement).Click();
        }
        public static void enterUsername(IWebDriver driver, string xpath, string inputName)
        {
            By InputField = By.XPath(xpath);
            driver.FindElement(InputField).SendKeys(inputName);
        }
        public static void enterPassword(IWebDriver driver, string xpath, string inputName)
        {
            By InputField = By.XPath(xpath);
            driver.FindElement(InputField).SendKeys(inputName);
        }
    }
}
