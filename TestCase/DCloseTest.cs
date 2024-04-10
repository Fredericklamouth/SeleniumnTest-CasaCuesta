using NUnit.Framework;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tarea4SELENIUMN.PageObject;
using System.Threading;
using Tarea4SELENIUMN.Handler;
using AventStack.ExtentReports;

namespace Tarea4SELENIUMN.TestCase
{
    [TestFixture]
    public class ACloseTest
    {
        protected IWebDriver Driver;
        protected ExtentTest reporte;

        private HomePage homePage;

        private Close close;

        [SetUp]
        public void BeforeTest()
        {
            Driver = new FirefoxDriver();
            Driver.Navigate().GoToUrl("https://casacuesta.com/customer/account/login/");


            LoginPage loginPage = new LoginPage(Driver);
            homePage = loginPage.LoginAs("frederickitla@gmail.com", "Feliciat3.");
            Assert.That(homePage.ButtonIsPresent());

            close = new Close(Driver);
            reporte = Reporte.ObtenerReporte().CreateTest(TestContext.CurrentContext.Test.Name);



        }

        [Test]
        public void CerrarSeccion()
        {
            Capture.Captura(Driver, "CasoDePrueba-CloSesion", "scrsht1-principal");
            reporte.Log(Status.Info, "Accedio a la pagina principal.");
            close.ButtonIsPresent();
            Thread.Sleep(10000);
            close.click1();
            Capture.Captura(Driver, "CasoDePrueba-CloSesion", "scrsht2-ClickMiCuenta");
            reporte.Log(Status.Info, "Hizo click en el boton mi cuenta.");
            Thread.Sleep(3000);

            close.CloseIsPresent();
            close.click2();
            Capture.Captura(Driver, "CasoDePrueba-CloSesion", "scrsht3-Cerro sesion");
            reporte.Log(Status.Info, "Cerro la sesion.");

        }

        [TearDown]
        public void AfterTest()
        {
            Reporte.ObtenerReporte().Flush();
            if (Driver != null)
            {

                Driver.Quit();

            }
        }
    }
}
