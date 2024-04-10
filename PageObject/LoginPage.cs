using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea4SELENIUMN.Handler;

namespace Tarea4SELENIUMN.PageObject
{
    public class LoginPage
    {
        protected IWebDriver Driver;
        protected By UserInput = By.Id("email");
        protected By Password = By.Id("pass");
        protected By LoginButton = By.Id("send2");


        public LoginPage(IWebDriver driver) {
            Driver = driver;
            if (!Driver.Title.Equals("Acceso del cliente"))
            {
                throw new Exception("Este no es la pagina de login");

            }
        }

        public void TypeUserName(string user)
        {
            Driver.FindElement(UserInput).SendKeys(user);
        }

        public void TypePassword(string password)
        {
            Driver.FindElement(Password).SendKeys(password);
        }
        public void ClickButton()
        {
            Driver.FindElement(LoginButton).Click();
        }

        public HomePage LoginAs(string user, string password) {
            TypeUserName(user);
            TypePassword(password);
            Capture.Captura(Driver, "CasoDePrueba-EntrarLogin", "scrsht1-PaginaLogin(DatosInsert)");
            ClickButton();
            Capture.Captura(Driver, "CasoDePrueba-EntrarLogin", "scrsht2-PaginaInicio");
            return new HomePage(Driver);


        }
    }
}
