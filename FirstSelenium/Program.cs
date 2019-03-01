using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Remote;
using System;

namespace FirstSelenium
{
   public class Program:Selenium_project
    {
        //private static IWebDriver driver;
        //Selenium_project test = new Selenium_project();
        
        static void Main(string[] args)
        {  
        }

        [SetUp]
        public void Init()
        {
            String Url = "https://opensource-demo.orangehrmlive.com/";
           Setup("chrome", Url);
          //((IJavaScriptExecutor)driver).ExecuteScript("window.resizeTo(1024, 768)");

        }
       /* [Test]
        public void LoginWithNegativeinfo()
        {
            test.Signin("Admin", "Gooder");
            Console.WriteLine("-----Login failed----");

        }*/

        [Test] 
        public void Add()
        {
            Signin("Admin", "admin123");
        }

        [TearDown]
        public void Cleanup()
        {
            closeBrowser();
            Console.WriteLine("----browser closed");
        }
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

                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

                

            }
            if (browser.Equals("chrome"))
            {
                Console.WriteLine("----Lunching the Chrome browser----");
                driver = new ChromeDriver();
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.Navigate().GoToUrl(url);
            }

            if (browser.Equals("ie"))
            {
                Console.WriteLine("----Lunching the Internet Explorer browser----");

                driver = new InternetExplorerDriver();
                
                           
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
                driver.Navigate().GoToUrl(url);
            } 

             
        }

        public void Signin(String username, String password)
        {
            //Username Element
            IWebElement usern = driver.FindElement(By.Id("txtUsername"));
            usern.SendKeys(username);

            //password Element
            IWebElement psw = driver.FindElement(By.Id("txtPassword"));
            psw.SendKeys(password);

            //Submit button
            IWebElement btn = driver.FindElement(By.XPath("//*[@id='btnLogin']"));
            btn.Click();

            
        }

        public void SignUp()
        {
            driver.FindElement(By.XPath("")).Click();
        }

        public void closeBrowser()
        {
            driver.Close();
        }

    }
   
}
