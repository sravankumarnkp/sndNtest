using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using sndNunitest.Pages;

namespace sndNunitest.Utilities
{
    class Commondriver
    {
        public static IWebDriver driver;
        [OneTimeSetUp]
        public void loginActions()
        {
            driver = new ChromeDriver();

            //create login page
            LoginPage lpobj = new LoginPage();
            lpobj.gotoLoginPage(driver);
            //create home page
            HomePage Hpobj = new HomePage();
            Hpobj.gotoHomePage(driver);

        }
       
        [OneTimeTearDown]
        public void closeTestRun()
        {
            driver.Close();

        }
    }
}
