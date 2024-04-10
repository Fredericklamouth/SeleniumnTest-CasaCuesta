using NUnit.Framework;
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
    public class MrktPlacePage
    {
        protected IWebDriver Driver;

        protected By button = By.XPath("/html/body/div[4]/main/div[4]/div/div[5]/ol/li[1]/div/a/span/span/img");
        protected By addCart = By.Id("product-addtocart-button-3327451");

        protected By Cart = By.XPath("/html/body/div[4]/header/div/div[2]/div/div/div[4]/div[3]/a/span[1]");
        protected By cartEnter = By.XPath("/html/body/div[4]/header/div/div[2]/div/div/div[4]/div[3]/div/div/div/div[2]/div[4]/div/a");
        protected By delete = By.XPath("/ html/body/div[4]/main/div[3]/div/div[3]/form/div[1]/table/tbody/tr[1]/td[6]/a[2]");



        public MrktPlacePage(IWebDriver driver)
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

        public bool CartIsPresent()
        {
            return WaitHandler.ElementIsPresent(Driver, Cart);
        }

        public bool CartEnterIsPresent()
        {
            return WaitHandler.ElementIsPresent(Driver, cartEnter);
        }

        public void SelectCart()
        {
            Driver.FindElement(Cart).Click();

        }

        public void SelectCartEnter()
        {
            Driver.FindElement(cartEnter).Click();

        }
        public void SelectProduct()
        {
            Driver.FindElement(button).Click();

        }

        public void DeleteCart()
        {
            Driver.FindElement(delete).Click();

        }


        public void AddCart()
        {
            Driver.FindElement(addCart).Click();

        }

    }

}

