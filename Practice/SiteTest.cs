using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Practice
{
    internal class SiteTest
    {
        public static bool UserLogin(IWebDriver driver)
        {
            try
            {
                driver.Url = "http://10.157.123.12/login2024/";
                Thread.Sleep(1000);

                IWebElement btnClick = SiteWebElements.btnLoginClick(driver);
                
                btnClick.Click();
                Thread.Sleep(1000);

                return true;
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }//end UserLogin

        public static bool EnterUser(string username, string password, IWebDriver driver) 
        {
            try
            {
                bool btnLoginSuccess;
                btnLoginSuccess = UserLogin(driver); 
                
                IWebElement txtUsername = SiteWebElements.txtUsername(driver);
                IWebElement txtPassword = SiteWebElements.txtPassword(driver);
                IWebElement loginUserButton = SiteWebElements.loginUserbutton(driver);

                txtUsername.SendKeys(username);
                Thread.Sleep(500);
                txtPassword.SendKeys(password);
                Thread.Sleep(500);
                loginUserButton.Click();
                Thread.Sleep(500);

                IWebElement lblLoginMessage = SiteWebElements.loginSuccess(driver);

                if (lblLoginMessage.Text.Contains("You have successfully logged in!"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        public static bool EnterUser2(string username, string password, IWebDriver driver)
        {
            try
            {
                bool btnLoginSuccess;
                btnLoginSuccess = UserLogin(driver);

                IWebElement txtUsername = SiteWebElements.txtUsername(driver);
                IWebElement txtPassword = SiteWebElements.txtPassword(driver);
                IWebElement loginUserButton = SiteWebElements.loginUserbutton(driver);

                txtUsername.SendKeys(username);
                Thread.Sleep(500);
                txtPassword.SendKeys(password);
                Thread.Sleep(500);
                loginUserButton.Click();
                Thread.Sleep(500);

                IWebElement lblLoginMessage = SiteWebElements.loginUnsuccessfull(driver);

                if (lblLoginMessage.Text.Contains("Login was unsuccessful, please check your username and password"))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
        //#######################################################################################################
        //################END OF USER LOGIN######################################################################

        public static bool choiceLogin(IWebDriver driver)
        {
            try
            {
                driver.Url = "http://10.157.123.12/login2024/";
                Thread.Sleep(1000);

                IWebElement btnClick = SiteWebElements.choiceButton(driver);

                btnClick.Click();
                Thread.Sleep(1000);

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }//end UserLogin

        public static bool chooseGreen(IWebDriver driver)
        {
            try
            {
                bool boolChoiceLogin;
                boolChoiceLogin = choiceLogin(driver);

                IWebElement dropDown = SiteWebElements.selectDropDown(driver);
                IWebElement selectGreen = SiteWebElements.selectGreen(driver);
                IWebElement greenSuccess = SiteWebElements.greenSuccess(driver);

                dropDown.Click();
                Thread.Sleep(500);

                selectGreen.Click();
                Thread.Sleep(500);

                if (greenSuccess.Text.Contains("User has chosen: greenpill"))
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }

        public static bool chooseOrange(IWebDriver driver)
        {
            try
            {
                bool boolChoiceLogin;
                boolChoiceLogin = choiceLogin(driver);

                IWebElement dropDown = SiteWebElements.selectDropDown(driver);
                IWebElement selectOrange = SiteWebElements.selectOrange(driver);
                IWebElement orangeSuccess = SiteWebElements.orangeSuccess(driver);

                dropDown.Click();
                Thread.Sleep(500);

                selectOrange.Click();
                Thread.Sleep(500);

                if (orangeSuccess.Text.Contains("User has chosen: blackpill"))
                {
                    return false;
                }
                else
                {
                    return true;
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
        }
    }
}
