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
    public class Search
    {
        protected IWebDriver Driver;

        protected By button = By.XPath("/html/body/div[4]/header/div/div[2]/div/div/div[3]/div/div[2]/form/div[1]/div/input");
        protected By addCart = By.XPath("/html/body/div[4]/header/div/div[2]/div/div/div[3]/div/div[2]/form/div[2]/button");

        public Search(IWebDriver driver)
        {
            Driver = driver;
        }

        public bool ButtonIsPresent()
        {
            return WaitHandler.ElementIsPresent(Driver, button);
        }

        public bool AddCartIsPresent()
        {
            return WaitHandler.ElementIsPresent(Driver, addCart);
        }

        public void Buscar(string user)
        {
            Driver.FindElement(button).SendKeys(user);
        }

        public void click1()
        {
            Driver.FindElement(button).Click();
        }

        public void click2()
        {
            Driver.FindElement(addCart).Click();
        }




    }
}
