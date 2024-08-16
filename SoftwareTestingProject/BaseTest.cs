using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SoftwareTestingProject;

namespace SoftwareTestingProject
{
    public class BaseTest
    {
        public static IWebDriver driver;
        public void OpenBrowser()
        {
            var myDriver = new ChromeDriver();
            driver = myDriver;
            //IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Url = ("https://stores.laam.pk/");
        }
    }
}