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

        
       
        [Test, Order(1)]
        public void createTMTest()
        {
            //tm page
            TMPage tmobj = new TMPage();
            tmobj.createTM(driver);

        }
        [Test, Order(2)]
        public void editTMTest()
        {
            //tm page
            TMPage tmobj = new TMPage();
            tmobj.editTM(driver);


        }

        [Test, Order(3)]
        public void deleteTMTest()
        {
            //tm page
            TMPage tmobj = new TMPage();
            tmobj.deleteTM(driver);

        }
        
    }
}
