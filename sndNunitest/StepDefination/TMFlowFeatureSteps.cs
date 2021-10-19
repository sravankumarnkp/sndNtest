using System;
using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using sndNunitest.Pages;
using sndNunitest.Utilities;
using TechTalk.SpecFlow;

namespace sndNunitest.StepDefination
{
    [Binding]
    public class TMFlowFeatureSteps : Commondriver
    {
        [Given(@"I Logged into turnup portal sucessfully")]
        public void GivenILoggedIntoTurnupPortalSucessfully()
        {
            driver = new ChromeDriver();

            //create login page
            LoginPage lpobj = new LoginPage();
            lpobj.gotoLoginPage(driver);

        }

        [Given(@"I nagivate to Time and material page")]
        public void GivenINagivateToTimeAndMaterialPage()
        {
            //create home page
            HomePage Hpobj = new HomePage();
            Hpobj.gotoHomePage(driver);
            
        }

        [When(@"I create time and material record\.")]
        public void WhenICreateTimeAndMaterialRecord_()
        {
           //creating time meaterial record
           TMPage tmobj = new TMPage();
            tmobj.createTM(driver);

        }

        [Then(@"Thre record should be created sucessfully")]
        public void ThenThreRecordShouldBeCreatedSucessfully()
        {
            TMPage tmobj = new TMPage();
          string chckelement=  tmobj.getCode(driver);
           string chckTypecode= tmobj.getDesc(driver);
            string chckDesc= tmobj.getPrice(driver);
            string chckPrice= tmobj.getTypecode(driver);

            Assert.That(chckelement == "sep2021", "Actual code and expected code do not match");
            Assert.That(chckTypecode == "T", "Actual code and expected code do not match");
            Assert.That(chckDesc == "sept2021", "Actual Desc and expected code do not match");
            Assert.That(chckPrice == "$25.00", "Actual Price and expected code do not match");


            // ScenarioContext.Current.Pending();
        }

        [When(@"I Edit the time and material record")]
        public void WhenIEditTheTimeAndMaterialRecord()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"There record should be edited sucessfully")]
        public void ThenThereRecordShouldBeEditedSucessfully()
        {
            ScenarioContext.Current.Pending();
        }

        [When(@"I delete the time and marerial record")]
        public void WhenIDeleteTheTimeAndMarerialRecord()
        {
            ScenarioContext.Current.Pending();
        }

        [Then(@"there record should be deleted sucessfully\.")]
        public void ThenThereRecordShouldBeDeletedSucessfully_()
        {
            ScenarioContext.Current.Pending();
        }

    }
}
