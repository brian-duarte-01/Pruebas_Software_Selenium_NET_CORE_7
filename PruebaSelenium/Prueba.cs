using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace PruebaSelenium
{
    public class Prueba
    {
        IWebDriver driver = new ChromeDriver();

        // variables para facebook y canvas 
        string user = "losbrotherumg@gmail.com";
        string pass = "12345ABC";

        //pruebas de instagram 
        string user1 = "umg";
        string pass1 = "123456";

        // prueba 3 y 4
        string validationDefaultUsername = "Enviado";
        string status = "";


        //prueba de facebook EStuardo
        public void prueba1()
        {
            driver.Url = "https://www.facebook.com/";

            driver.Manage().Window.Maximize();
            Thread.Sleep(3600);
            WebElement EmailInput = (WebElement)driver.FindElement(By.Id("email"));
            WebElement PassInput = (WebElement)driver.FindElement(By.Id("pass"));
            WebElement LoginBtn = (WebElement)driver.FindElement(By.Name("login"));

            EmailInput.SendKeys(user);
            Thread.Sleep(3600);
            PassInput.SendKeys(pass);
            Thread.Sleep(3600);
            LoginBtn.Click();
        }

        //prueba de canva Omar
        public void prueba2()
        {
            driver.Url = "https://learn.canvas.net/login/canvas";
            driver.Manage().Window.Maximize();

            WebElement EmailInput = (WebElement)driver.FindElement(By.Id("pseudonym_session_unique_id"));
            WebElement PassInput = (WebElement)driver.FindElement(By.Id("pseudonym_session_password"));
            WebElement LoginBtn = (WebElement)driver.FindElement(By.CssSelector("button.Button.Button--login"));
            EmailInput.SendKeys(user);
            Thread.Sleep(3600);
            PassInput.SendKeys(pass);
            Thread.Sleep(3600);
            LoginBtn.Click();
            Thread.Sleep(3600);
            
        }

   
        //prueba de software 
        public void prueba3()
        {

            driver.Url = "http://localhost:4200/estado";
            driver.Manage().Window.Maximize();
            Thread.Sleep(3600);
            WebElement RegistrarBtn = (WebElement)driver.FindElement(By.Id("registrar"));
            WebElement CloseBtn = (WebElement)driver.FindElement(By.Id("btn-close"));
            WebElement Tipo_Status = (WebElement)driver.FindElement(By.Id("validationDefaultUsername"));
            WebElement Enviarbtn = (WebElement)driver.FindElement(By.Id("btn"));

            RegistrarBtn.Click();
            Thread.Sleep(3600);
            Tipo_Status.SendKeys(validationDefaultUsername);
            Thread.Sleep(3600);
            Enviarbtn.Click();
            Thread.Sleep(3600);
            CloseBtn.Click();
            Thread.Sleep(3600);
            


        }

        //Prueba de Youtube de cesar
        public void prueba4()
        {
            driver.Url = "https://www.google.com/?hl=es";
            driver.Manage().Window.Maximize();
            Thread.Sleep(3600);
            var inputSearch = driver.FindElement(By.Name("q"));
            inputSearch.SendKeys("videos rock en YouTube");
            inputSearch.Submit();
            Thread.Sleep(3600);
            driver.Close();
        }
        //prueba de responsive design Geovanni
        public void prueba5()
        {
            driver.Url = "http://localhost:4200/estado";
            Thread.Sleep(3600);
            driver.Manage().Window.Maximize();
            Thread.Sleep(3600);
            driver.Manage().Window.Minimize();
            Thread.Sleep(3600);
            driver.Manage().Window.Maximize();
            Thread.Sleep(3600);
            driver.Close();
        }

        //pruebas en instagram Christian
        public void prueba6()
        {
            driver.Url = "https://www.instagram.com/";
            Thread.Sleep(3600);
            driver.Manage().Window.Maximize();
            Thread.Sleep(3600);
            WebElement emailInput = (WebElement)driver.FindElement(By.Name("username"));
            emailInput.SendKeys(user);
            Thread.Sleep(3600);
            WebElement passInput = (WebElement)driver.FindElement(By.Name("password"));
            passInput.SendKeys(pass);
            Thread.Sleep(3600);
            WebElement LoginPass = (WebElement)driver.FindElement(By.CssSelector("button._acan._acap._acas._aj1-"));
            LoginPass.Click();
        }
        // Brian
        public void prueba7()
        {
            driver.Url = "https://www.instagram.com/";
            Thread.Sleep(3600);
            driver.Manage().Window.Maximize();
            Thread.Sleep(3600);
            WebElement emailInput = (WebElement)driver.FindElement(By.Name("username"));
            emailInput.SendKeys(user1);
            Thread.Sleep(3600);
            WebElement passInput = (WebElement)driver.FindElement(By.Name("password"));
            passInput.SendKeys(pass1);
            Thread.Sleep(3600);
            WebElement LoginPass = (WebElement)driver.FindElement(By.CssSelector("button._acan._acap._acas._aj1-"));
            LoginPass.Click();
        }





    }
}
