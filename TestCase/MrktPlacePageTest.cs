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
    public class MrktPlacePageTest
    {
        protected IWebDriver Driver;
        protected ExtentTest reporte;

        private HomePage homePage;

        private MrktPlacePage mrktPlace;

        [SetUp]
        public void BeforeTest()
        {
            Driver = new FirefoxDriver();
            Driver.Navigate().GoToUrl("https://casacuesta.com/customer/account/login/");


            LoginPage loginPage = new LoginPage(Driver);
            homePage = loginPage.LoginAs("frederickitla@gmail.com", "Feliciat3.");
            Assert.That(homePage.ButtonIsPresent());

            homePage.AccessMrktPlace();
            mrktPlace = new MrktPlacePage(Driver);
            reporte = Reporte.ObtenerReporte().CreateTest(TestContext.CurrentContext.Test.Name);



        }

        [Test]
        public void InteractuarCarrito()
        {


            Capture.Captura(Driver, "CasoDePrueba-AñadirCarrito", "scrsht1-Seccion");
            reporte.Log(Status.Info, "Se accedio a una seccion de la pagina.");
            mrktPlace.SelectProduct();
            mrktPlace.AddCartIsPresent();
            Capture.Captura(Driver, "CasoDePrueba-AñadirCarrito", "scrsht2-DescripcionProducto");
            reporte.Log(Status.Info, "Entro a la descripcion de un producto.");
            mrktPlace.AddCart();
            Capture.Captura(Driver, "CasoDePrueba-AñadirCarrito", "scrsht3-Añadido");
            reporte.Log(Status.Info, "Añadio un producto al carrito.");
            Thread.Sleep(10000);

            mrktPlace.CartIsPresent();
            mrktPlace.SelectCart();
            Capture.Captura(Driver, "CasoDePrueba-AñadirCarrito", "scrsht4-ClickMicarrito");
            reporte.Log(Status.Info, "Hizo click en el boton de Mi carrito.");
            mrktPlace.CartEnterIsPresent();
            mrktPlace.SelectCartEnter();
            Capture.Captura(Driver, "CasoDePrueba-AñadirCarrito", "scrsht5-Micarrito");
            reporte.Log(Status.Info, "Entro a la seccion de mi carrito.");
            Thread.Sleep(5000);
            mrktPlace.DeleteCart();
            Thread.Sleep(3000);
            Capture.Captura(Driver, "CasoDePrueba-AñadirCarrito", "scrsht6-EliminarProducto");
            reporte.Log(Status.Info, "Elimino un producto del carrito.");




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
