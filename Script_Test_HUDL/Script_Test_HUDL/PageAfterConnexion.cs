using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace Script_Test_HUDL
{
    class PageAfterConnexion
    {
        public PageAfterConnexion()
        {
            PageFactory.InitElements(Driver.driver, this);
        }

        [FindsBy(How = How.XPath, Using = "//*[@id=\"ssr-webnav\"]/div/div[1]/nav[1]/div[2]/a[1]/span")]
        public IWebElement HOMECheckPoint { get; set; }


    }
}
