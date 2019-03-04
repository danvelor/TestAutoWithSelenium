using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


namespace ControlTrafico
{
    class Program
    {
        static void Main(string[] args)
        {
            DriverEjecutera();

        }

        private static void DriverEjecutera()
        {

            IWebDriver driver = new ChromeDriver();
            try
            {
                Console.WriteLine("Iniciamos el proceso");

                driver.Url = "http://webcloud.satrack.com/ControlTraficoPausas/login.aspx";
                driver.FindElement(By.Id("Login1_UserName")).SendKeys(Keys.Control + "a");
                driver.FindElement(By.Id("Login1_UserName")).SendKeys(Keys.Delete);
                driver.FindElement(By.Id("Login1_UserName")).SendKeys("logitrans");
                driver.FindElement(By.Id("Login1_Password")).SendKeys("logitrans2020");
                driver.FindElement(By.Id("Login1_LoginButton")).Click();
                Task.Delay(3000).Wait();
                driver.SwitchTo().Frame(driver.FindElement(By.Id("ifControlTrafico"))).FindElement(By.Id("lnkCrearRuta")).Click();
                driver.FindElement(By.Id("rbMTRO")).Click();
                Task.Delay(1000).Wait();
                driver.FindElement(By.Id("Busquedaporciudad1_divRegionesxCiudad")).FindElement(By.Id("Busquedaporciudad1_gvRegionesxCiudad_ctl01_txtRegiones")).SendKeys("ABREGO_ARGOS");
                driver.FindElement(By.Id("Busquedaporciudad1_divRegionesxCiudad")).FindElement(By.Id("Busquedaporciudad1_gvRegionesxCiudad_ctl01_btnFiltrarCodigoRuta")).Click();
                driver.FindElement(By.Id("Busquedaporciudad1_divRegionesxCiudad")).FindElement(By.Id("Busquedaporciudad1_gvRegionesxCiudad_ctl02_rbRegiones")).Click();
                driver.FindElement(By.Id("Busquedaporciudad1_divRegionesxCiudad")).FindElement(By.Id("Busquedaporciudad1_gvRegionesxCiudad_ctl02_rbRegiones")).Click();

                Task.Delay(3000).Wait();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            Console.WriteLine("Fin de accion");
            Console.ReadLine();
            driver.Close();
            driver.Dispose();

        }
    }


}
