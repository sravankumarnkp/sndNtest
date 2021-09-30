﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;

namespace sndNunitest.Pages
{
    class LoginPage
    {
        public void gotoLoginPage(IWebDriver driver)
        {
			driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");
			driver.Manage().Window.Maximize();
			Thread.Sleep(2000);
            try 
			{
				//identify username textbox enter valid user name
				IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
				usernameTextbox.SendKeys("hari");
				//identify password passbox enter valid password
				IWebElement passwordTextnox = driver.FindElement(By.Id("Password"));
				passwordTextnox.SendKeys("123123");
				//identify login box and click one it
				IWebElement LoginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
				LoginButton.Click();

			}
			catch(Exception ex)
            {
				Assert.Fail("Turn portal home page not loaded",ex.Message);            
			}



		}
	}
}
