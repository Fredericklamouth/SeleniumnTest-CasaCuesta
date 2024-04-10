using AventStack.ExtentReports;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea4SELENIUMN.Handler;
using Tarea4SELENIUMN.PageObject;

namespace Tarea4SELENIUMN.TestCase
{
    [TestFixture]
    public class ALoginTest
    {
        protected IWebDriver Driver;
        protected ExtentTest reporte;


        [SetUp]
        public void BeforeTest()
        {
            Driver = new FirefoxDriver();
            Driver.Navigate().GoToUrl("https://casacuesta.com/customer/account/login/");
            reporte = Reporte.ObtenerReporte().CreateTest(TestContext.CurrentContext.Test.Name);
    }

        [Test]
        public void SuccessfulLoginTest() {

            LoginPage loginPage = new LoginPage(Driver);
            HomePage homepage = loginPage.LoginAs("frederickitla@gmail.com", "Feliciat3.");
            Assert.That(homepage.ButtonIsPresent());
            reporte.Log(Status.Info, "Se accedio a la pagina principal.");

        }

        [TearDown]
        public void AfterTest()
        {
            Reporte.ObtenerReporte().Flush();

            if (Driver != null) {

                Driver.Quit();
            
            }
        }
    }
}
