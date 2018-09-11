using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace Script_Test_HUDL
{
    public class EntryPoint
    {
        static void Main()
        {
            MainPage page = new MainPage();

            PageAfterConnexion nextpage = new PageAfterConnexion();

            Driver.driver.Navigate().GoToUrl("https://www.hudl.com/login?");

            page.Username.Click();

            page.Username.SendKeys("mba.amine@gmail.com");

            page.Password.Click();

            page.Password.SendKeys("@44bdbdBD");

            page.Login.Click();

            WebDriverWait wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(10));
           
            WaitUntilElementExists(By.XPath("//*[@id=\"ssr-webnav\"]/div/div[1]/nav[1]/div[2]/a[1]/span"), 15);

            if (nextpage.HOMECheckPoint.Displayed)
            {
                System.Console.WriteLine("The Connexion Is Successful!!!!!!");
            }
            else
            {
                System.Console.WriteLine("The Connexion Is Not Successful!!!!!!");

            }
       
        }

        //this will search for the element until a timeout is reached
        public static IWebElement WaitUntilElementExists(By elementLocator, int timeout = 10)
        {
            try
            {
                var wait = new WebDriverWait(Driver.driver, TimeSpan.FromSeconds(timeout));
                return wait.Until(ExpectedConditions.ElementExists(elementLocator));
            }
            catch (NoSuchElementException)
            {
                Console.WriteLine("Element with locator: '" + elementLocator + "' was not found in current context page.");
                throw;
            }
        }
    }
}
