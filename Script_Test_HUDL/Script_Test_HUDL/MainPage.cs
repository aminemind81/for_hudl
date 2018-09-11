using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;


namespace Script_Test_HUDL
{
    public class MainPage
    {
        public MainPage()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.Name, Using ="username")]
        public IWebElement Username { get; set; }

        [FindsBy(How = How.Name, Using = "password")]
        public IWebElement Password { get; set; }

        [FindsBy(How = How.Id, Using = "logIn")]
        public IWebElement Login { get; set; }




    }
}