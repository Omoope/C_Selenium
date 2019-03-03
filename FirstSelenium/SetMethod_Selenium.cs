using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstSelenium
{
    class SetMethod_Selenium
    {
        //Custom method for entering value into a textBox
        public static void EnterText(IWebElement driver, String element, String value, String elementType)
        {
            if(elementType == "id")
            {
                driver.FindElement(By.Id(element)).SendKeys(value);
                
            } if(elementType == "name")
            {
                driver.FindElement(By.Name(element)).SendKeys(value);

            }
            if (elementType == "xpath")
            {
                driver.FindElement(By.Name(element)).SendKeys(value);

            }
            if (elementType == "linkText")
            {
                driver.FindElement(By.Name(element)).SendKeys(value);

            }
            if (elementType == "PartialLinkText")
            {
                driver.FindElement(By.Name(element)).SendKeys(value);

            }
            else
            {
                Console.WriteLine("elementType not found " + "Verify element entered from the webPage");

            }

        }

        //Custom Method for clicking any WebElement
        public static void ClickElement(IWebDriver driver, string elementType, string element)
        {

            if(elementType == "Name")
            {
                driver.FindElement(By.Name(element)).Click();
            }
            if (elementType == "Id")
            {
                driver.FindElement(By.Name(element)).Click();
            }
            if (elementType == "Xpath")
            {
                driver.FindElement(By.Name(element)).Click();
            }
            if (elementType == "cssSelector") 
            {
                driver.FindElement(By.Name(element)).Click();
            }
            else
            {
                Console.WriteLine("Either element Type is wrong or you have specified the wrong WebElement address");
            }

        }

        //Custom Method for selection value from a dropDown in Selenium
        public static void DropDownSelectControl(IWebDriver driver, string elementType, string element, String EnterTextvalue)
        {
            if(elementType == "Name")
            {
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(EnterTextvalue);
            }
            if (elementType == "Id")
            {
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(EnterTextvalue);
            }
            if (elementType == "Xpath")
            {
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(EnterTextvalue);
            }

            Console.WriteLine("This method allows you to enter the text Value with the specific WebElement Type");
        }
    }

    }
