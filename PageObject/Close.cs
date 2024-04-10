using AventStack.ExtentReports.Model;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Tarea4SELENIUMN.Handler;
using Tarea4SELENIUMN.PageObject;

namespace Tarea4SELENIUMN.PageObject
{
    public class Close
    {
        protected IWebDriver Driver;


        protected By button = By.XPath("/html/body/div[4]/header/div/div[2]/div/div/div[4]/div[2]/div/a/span/span");
        protected By close = By.XPath("/html/body/div[4]/header/div/div[2]/div/div/div[4]/div[2]/div/div/div/div[2]/ul/li[5]/a");

        public Close(IWebDriver driver)
        {
            Driver = driver;
        }

        public bool ButtonIsPresent()
        {
            return WaitHandler.ElementIsPresent(Driver, button);
        }

        public bool CloseIsPresent()
        {
            return WaitHandler.ElementIsPresent(Driver, close);
        }

        public void click1()
        {
            Driver.FindElement(button).Click();
        }

        public void click2()
        {
            Driver.FindElement(close).Click();
        }




    }
}
