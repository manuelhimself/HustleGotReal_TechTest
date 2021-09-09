using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Linq;

namespace HustleGotReal
{
    class Program
    {
        public static String loginUrl = "https://app.hustlegotreal.com/Account/Login";
        public static String scrapUrl = "https://app.hustlegotreal.com";
        public static String email = "testing@hustlegotreal.com";
        public static String pass = "HGR2021";
        
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(loginUrl);

            var inputEmail = driver.FindElement(By.Name("Email"));
            var inputPass = driver.FindElement(By.Name("Password"));

            inputEmail.SendKeys(email);
            inputPass.SendKeys(pass);

            inputEmail.Submit();

            driver.Navigate().GoToUrl(scrapUrl);

            var pageContent = driver.FindElement(By.XPath("//div[@class='module_products']//div[@class='col-sm-6 sector']//p[2]"));

            String result = pageContent.Text;


            Console.WriteLine(result);
        }
    }
}
