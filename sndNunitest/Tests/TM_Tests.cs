using System;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using sndNunitest.Pages;
using sndNunitest.Utilities;

namespace sndNunitest
{
    [TestFixture]
    class TM_Tests : Commondriver
    {

        
        [SetUp]
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
        [Test]
        public void createTMTest()
        {
            //tm page
            TMPage tmobj = new TMPage();
            tmobj.createTM(driver);

        }
        [Test]
        public void editTMTest()
        {
            //tm page
            TMPage tmobj = new TMPage();
            tmobj.editTM(driver);


        }

        [Test]
        public void deleteTMTest()
        {
            //tm page
            TMPage tmobj = new TMPage();
            tmobj.deleteTM(driver);

        }
        [TearDown]
        public void closeTestRun()
        {

        }
    }
}
