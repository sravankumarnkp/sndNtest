using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace sndNunitest.Pages
{
    class TMPage
    {
        public void createTM(IWebDriver driver)
        {
			//click on create new  button
			IWebElement createButton = driver.FindElement(By.XPath("//*[@id='container']/p/a"));
			createButton.Click();
			Thread.Sleep(2000);
			//select the time from type code droplist
			IWebElement typecodedropdown = driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[1]/div/span[1]/span/span[2]/span"));
			typecodedropdown.Click();
			Thread.Sleep(5000);
			IWebElement timeselect = driver.FindElement(By.XPath("//*[@id='TypeCode_listbox']/li[2]"));
			timeselect.Click();


			//identify "code" textbox and input code
			IWebElement codeTBX = driver.FindElement(By.Id("Code"));
			codeTBX.SendKeys("sep2021");

			// identify the "descrtion" textbox and input description
			IWebElement desTextbox = driver.FindElement(By.Id("Description"));
			desTextbox.SendKeys("sept2021");
			//identify the "price" textbox and input the price
			driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();
			IWebElement priceText = driver.FindElement(By.Id("Price"));
			priceText.SendKeys("25");
			//click on save button
			IWebElement saveBttn = driver.FindElement(By.Id("SaveButton"));
			saveBttn.Click();
			//check time and meterial cereated 
			Thread.Sleep(5000);
			IWebElement lastpagebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
			lastpagebutton.Click();
			//Assert.That(chckelement.Text == "sep2021", "Actual code expexted code diff test failed");
			//Console.WriteLine(chckelement.Text);
			
			/*IWebElement chckcode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
			//IWebElement chckTypecode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
			//IWebElement chckDesc = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
			//IWebElement chckPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
			Assert.That(chckelement.Text == "sep2021", "Actual code and expected code do not match");
			Assert.That(chckTypecode.Text == "T", "Actual code and expected code do not match");
			Assert.That(chckDesc.Text == "sept2021", "Actual Desc and expected code do not match");
			Assert.That(chckPrice.Text == "$25.00", "Actual Price and expected code do not match"); 
			
			
			if (chckelement.Text == "sep2021")
			{
				Console.WriteLine("data saved sucessfully test passed");


			}
			else { Console.WriteLine("data saved not sucessfully test failed"); }*/
			

		}
		public string getCode(IWebDriver driver)
        {
			IWebElement chckelement = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
			return chckelement.Text;

		}
		public string getTypecode(IWebDriver driver)
		{
			IWebElement chckTypecode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
			return chckTypecode.Text;

		}
		public string getDesc(IWebDriver driver)
		{
			IWebElement chckDesc = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
			return chckDesc.Text;

		}
		public string getPrice(IWebDriver driver)
		{
			IWebElement chckPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
			return chckPrice.Text;

		}
		public void editTM(IWebDriver driver)
        {
			Thread.Sleep(2000);
			IWebElement lastpagebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
			lastpagebutton.Click();
			IWebElement chckcode1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
			if (chckcode1.Text == "sep2021")
			{
				IWebElement editbutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
				editbutton.Click();
				//edit description

				IWebElement nDs = driver.FindElement(By.Id("Description"));
				nDs.Clear();
				nDs.SendKeys("1newsept2023");
				//edit price
				driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();
				//*[@id="TimeMaterialEditForm"]/div/div[4]/div/span[1]/span/input[1]
				//*[@id="TimeMaterialEditForm"]/div/div[4]/div/span[1]/span/input[1]
				IWebElement nPs = driver.FindElement(By.XPath("//*[@id='Price']"));
				nPs.Clear();
				driver.FindElement(By.XPath("//*[@id='TimeMaterialEditForm']/div/div[4]/div/span[1]/span/input[1]")).Click();

				nPs.SendKeys("54");
				//save
				driver.FindElement(By.Id("SaveButton")).Click();
				Console.WriteLine("data updated  sucessfully test passed");

				Thread.Sleep(2000);
				IWebElement lastpagebutton1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
				lastpagebutton1.Click();

				IWebElement chckcode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
				IWebElement chckTypecode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
				IWebElement chckDesc = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
				IWebElement chckPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
				Assert.That(chckcode.Text == "sep2021", "Actual code and expected code do not match");
				Assert.That(chckTypecode.Text == "T", "Actual code and expected code do not match");
				Assert.That(chckDesc.Text == "1newsept2023", "Actual Desc and expected code do not match");
				Assert.That(chckPrice.Text == "$54.00", "Actual Price and expected code do not match");
			}

			else
			{
				Assert.Fail("cannot find edited data, delete test case failed");

			}


		}

		public void deleteTM(IWebDriver driver)
        {
			//delete the data what is saved 


			Console.WriteLine("data deleted stated test ");


			Thread.Sleep(2000);
			//delete
			driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span")).Click();
			IWebElement chckcode1 = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
			if (chckcode1.Text == "sep2021")
			{
				IWebElement deletebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
				Thread.Sleep(2000);
				//*[@id="tmsGrid"]/div[3]/table/tbody/tr/td[5]/a[2]
				deletebutton.Click();
				driver.SwitchTo().Alert().Accept();
				Console.WriteLine("data deleted sucessfully ..... ");

				Thread.Sleep(2000);
				IWebElement lastpagebutton = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[4]/a[4]/span"));
				lastpagebutton.Click();
				Thread.Sleep(2000);

				IWebElement chckcode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[1]"));
				IWebElement chckTypecode = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[2]"));
				IWebElement chckDesc = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[3]"));
				IWebElement chckPrice = driver.FindElement(By.XPath("//*[@id='tmsGrid']/div[3]/table/tbody/tr[last()]/td[4]"));
				Assert.That(chckcode.Text != "sep2021", "Actual code and expected code same data not deleted test failed");
				//Assert.That(chckTypecode.Text != "M", "Actual code and expected code do not match");
				Assert.That(chckDesc.Text != "1newsept2023", "Actual Desc and expected code do not match");
				Assert.That(chckPrice.Text != "$54.00", "Actual Price and expected code do not match");
			}
			else
            {
				Assert.Fail("cannot find edited data, delete test case failed");
            }

		}
	}
}
