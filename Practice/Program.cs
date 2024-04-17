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
    internal class Program
    {
        static void Main(string[] args)
        {

            IWebDriver driver1 = new ChromeDriver(@"C:\Selenium");
            Thread.Sleep(500);
            bool Userlogin1;
            Userlogin1 = SiteTest.EnterUser("nbcc", "donthackmeplz", driver1);
            Console.WriteLine("##############################");
            Console.WriteLine("Good login work: " + Userlogin1);
            Console.WriteLine("##############################");
            driver1.Close();

            IWebDriver driver2 = new ChromeDriver(@"C:\Selenium");
            Thread.Sleep(500);
            bool Userlogin2;
            Userlogin2 = SiteTest.EnterUser2("bad", " ", driver2);
            Console.WriteLine("##############################");
            Console.WriteLine("Does bad login work: " + Userlogin2);
            Console.WriteLine("##############################");
            driver2.Close();

            IWebDriver driver3 = new ChromeDriver(@"C:\Selenium");
            Thread.Sleep(500);
            bool choiceClick1;
            choiceClick1 = SiteTest.chooseGreen(driver3);
            Console.WriteLine("##############################");
            Console.WriteLine("Does selecting green work: " + choiceClick1);
            Console.WriteLine("##############################");
            driver3.Close();

            IWebDriver driver4 = new ChromeDriver(@"C:\Selenium");
            Thread.Sleep(500);
            bool choiceClick2;
            choiceClick2 = SiteTest.chooseOrange(driver4);
            Console.WriteLine("##############################");
            Console.WriteLine("Does selecting orange work: " + choiceClick2);
            Console.WriteLine("##############################");
            driver4.Close();

        }
    }
}
