using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tarea4SELENIUMN.Handler;

namespace Tarea4SELENIUMN.PageObject
{
    public class HomePage
    {
        protected IWebDriver Driver;

        protected By button = By.XPath("/html/body/div[4]/header/div/div[3]/div[2]/div[1]/nav/ul/li[1]");



        public HomePage (IWebDriver driver)
        {
            Driver = driver;

        }

        public bool ButtonIsPresent()
        {
            return WaitHandler.ElementIsPresent(Driver, button);
        }



        public void AccessMrktPlace()
        {
            Driver.FindElement(button).Click();
        }
    }
}
