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

        
       
        [Test, Order(1001), Description("Check if user is able to create Material record")]
        public void createTMTest()
        {
            //tm page
            TMPage tmobj = new TMPage();
            tmobj.createTM(driver);

        }
        [Test, Order(1002), Description("Check if user is able to edit  Material record")]
        public void editTMTest()
        {
            //tm page
            TMPage tmobj = new TMPage();
            tmobj.editTM(driver);


        }

        [Test, Order(1003), Description("Check if user is able to delete Material record")]
        public void deleteTMTest()
        {
            //tm page
            TMPage tmobj = new TMPage();
            tmobj.deleteTM(driver);

        }
        
    }
}
