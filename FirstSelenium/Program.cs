using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;

namespace FirstSelenium
{
   public class Program
    {

        static IWebDriver driver = new ChromeDriver();

        
        static void Main(string[] args)
        {  
        }

        [SetUp]
        public void Init()
        {
           
            driver.Navigate().GoToUrl("https://testautomationpractice.blogspot.com/");
        }

        [Test]
        public void Add()
        {
            driver.SwitchTo().Frame(0);
            driver.FindElement(By.XPath("//*[@id='RESULT_TextField-5']")).SendKeys("Adedoyin");
        }

        [TearDown]
        public void Cleanup() => driver.Close();
    }



    public class Selenium_project
    {
        IWebDriver driver;
        
        public void Setup(String browser, String url)
        {
            if (browser.Equals("firefox"))
            {
                Console.WriteLine("----Lunching the Firefox browser----");
                driver = new FirefoxDriver();
                driver.Navigate().GoToUrl(url);

                ((IJavaScriptExecutor)driver).ExecuteScript("window.resizeTo(1024, 768)");

            }
            if (browser.Equals("chrome"))
            {
                Console.WriteLine("----Lunching the Chrome browser----");
                driver = new ChromeDriver();
                driver.Navigate().GoToUrl(url);
            }

            if (browser.Equals("ie"))
            {
                Console.WriteLine("----Lunching the Internet Explorer browser----");
                driver = new InternetExplorerDriver();
                driver.Navigate().GoToUrl(url);
            } 

             
        }

        public void Signin(String username, String password)
        {
            //Username Element
            IWebElement usern = driver.FindElement(By.XPath(""));
            usern.SendKeys(username);

            //password Element
            IWebElement psw = driver.FindElement(By.XPath(""));
            psw.SendKeys(password);

            //Submit button
            IWebElement btn = driver.FindElement(By.XPath(""));
            btn.Click();
        }

        public void SignUp()
        {
            driver.FindElement(By.XPath("")).Click();
        }

    }
   
}
