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
    public class BHomePageTest
    {
        protected IWebDriver Driver;

        private HomePage homePage;
        protected ExtentTest reporte;

        [SetUp]
        public void BeforeTest()
        {
            Driver = new FirefoxDriver();
            Driver.Navigate().GoToUrl("https://casacuesta.com/customer/account/login/");
   

            LoginPage loginPage = new LoginPage(Driver);
            homePage = loginPage.LoginAs("frederickitla@gmail.com", "Feliciat3.");
            Assert.That(homePage.ButtonIsPresent());
            reporte = Reporte.ObtenerReporte().CreateTest(TestContext.CurrentContext.Test.Name);



        }

        [Test]
        public void AccederSeccion()
        {
            Assert.That(homePage.ButtonIsPresent());
            Capture.Captura(Driver, "CasoDePrueba-EntrarASeccion", "scrsht1-PaginaInicio");
            reporte.Log(Status.Info, "Entro a la pagina de inicio.");
            homePage.AccessMrktPlace();
            Capture.Captura(Driver, "CasoDePrueba-EntrarASeccion", "scrsht2-Seccion");
            reporte.Log(Status.Info, "Entro a una de las secciones.");


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
