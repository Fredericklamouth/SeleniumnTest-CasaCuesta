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
    public class CSearchTest
    {
        protected IWebDriver Driver;
        protected ExtentTest reporte;


        private Search cartNpay;

        [SetUp]
        public void BeforeTest()
        {
            Driver = new FirefoxDriver();
            Driver.Navigate().GoToUrl("https://casacuesta.com/customer/account/login/");

            cartNpay = new Search(Driver);
            reporte = Reporte.ObtenerReporte().CreateTest(TestContext.CurrentContext.Test.Name);

        }

        [Test]
        public void BuscarProduct()
        {

            Capture.Captura(Driver, "CasoDePrueba-BuscarProducto", "scrsht1-PaginaInicio");
            reporte.Log(Status.Info, "Se accedio a la pagina principal.");
            cartNpay.ButtonIsPresent();
            cartNpay.click1();
            cartNpay.Buscar("Baño");
            Capture.Captura(Driver, "CasoDePrueba-BuscarProducto", "scrsht2-SearchBar");
            reporte.Log(Status.Info, "Escribio \"Baño \" en el buscador.");
            cartNpay.AddCartIsPresent();
            Thread.Sleep(3000);
            cartNpay.click2();
            Capture.Captura(Driver, "CasoDePrueba-BuscarProducto", "scrsht3-Resultado");
            reporte.Log(Status.Info, "Accedio a la pagina de baño.");


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
