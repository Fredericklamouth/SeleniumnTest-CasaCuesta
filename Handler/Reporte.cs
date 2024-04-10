using AventStack.ExtentReports.Reporter;
using AventStack.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea4SELENIUMN.Handler
{
    public class Reporte
    {
        private static ExtentReports reporte;
        private static ExtentSparkReporter ReporteHTML;
        public static ExtentReports ObtenerReporte()
        {
            if (reporte == null)
            {
                string Ruta = @"C:\Users\frede\source\repos\Tarea4SELENIUMN\Reporte\Reporte.html";
                ReporteHTML = new ExtentSparkReporter(Ruta);
                reporte = new ExtentReports();
                reporte.AttachReporter(ReporteHTML);
            }
            return reporte;
        }
    }
}
