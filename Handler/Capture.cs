using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4SELENIUMN.Handler
{
    public class Capture
    {
        public static string Captura(IWebDriver driver, string carpeta, string nombre)
        {
            string RutaImagen = "..\\..\\ScrnShot\\" + carpeta + "\\" + nombre + ".png";
            Screenshot imagen = ((ITakesScreenshot)driver).GetScreenshot();
            imagen.SaveAsFile(RutaImagen);

            return RutaImagen;
        }
    }
}
