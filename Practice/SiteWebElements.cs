using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Practice
{
    internal class SiteWebElements
    {
        public static IWebElement linkLogin (IWebDriver driver)
        {
            IWebElement txtLoginUsername = driver.FindElement(By.XPath("/html/body/div/a[1]"));
            return txtLoginUsername;
        }
        public static IWebElement linkChoice (IWebDriver driver)
        {
            IWebElement txtLoginPassword = driver.FindElement(By.XPath("/html/body/div/a[2]"));
            return txtLoginPassword;
        }
        public static IWebElement btnLoginClick (IWebDriver driver)
        {
            IWebElement btnClick = driver.FindElement(By.XPath("/html/body/div/a[1]"));
            return btnClick;
        }
        public static IWebElement txtUsername (IWebDriver driver)
        {
            IWebElement txtUser = driver.FindElement(By.XPath("//*[@id=\"usr\"]"));
            return txtUser;
        }
        public static IWebElement txtPassword(IWebDriver driver)
        {
            IWebElement txtPassword = driver.FindElement(By.XPath("//*[@id=\"pword\"]"));
            return txtPassword;
        }
        public static IWebElement loginUserbutton(IWebDriver driver)
        {
            IWebElement loginUserButton = driver.FindElement(By.XPath("//*[@id=\"loginbutton\"]"));
            return loginUserButton;
        }
        public static IWebElement loginSuccess(IWebDriver driver)
        {
            IWebElement loginSuccess = driver.FindElement(By.CssSelector("body > div:nth-child(1)"));
            return loginSuccess;
        }
        public static IWebElement loginUnsuccessfull(IWebDriver driver)
        {
            IWebElement loginUncesseccfull = driver.FindElement(By.Id("errormsg"));
            return loginUncesseccfull;
        }
        public static IWebElement choiceButton(IWebDriver driver)
        {
            IWebElement choiceButton = driver.FindElement(By.XPath("/html/body/div/a[2]"));
            return choiceButton;
        }

        public static IWebElement selectDropDown(IWebDriver driver)
        {
            IWebElement selectDropDown = driver.FindElement(By.XPath("//*[@id=\"choosepill\"]"));
            return selectDropDown;
        }
        public static IWebElement selectGreen(IWebDriver driver)
        {
            IWebElement selectGreen = driver.FindElement(By.XPath("/html/body/div[1]/select/option[3]"));
            return selectGreen;
        }
        public static IWebElement greenSuccess(IWebDriver driver)
        {
            IWebElement greenSuccess = driver.FindElement(By.Id("msg"));
            return greenSuccess;
        }
        public static IWebElement selectOrange(IWebDriver driver)
        {
            IWebElement greenSuccess = driver.FindElement(By.XPath("/html/body/div[1]/select/option[5]"));
            return greenSuccess;
        }
        public static IWebElement orangeSuccess(IWebDriver driver)
        {
            IWebElement orangeSuccess = driver.FindElement(By.XPath("//*[@id=\"msg\"]"));
            return orangeSuccess;
        }

    }
}
