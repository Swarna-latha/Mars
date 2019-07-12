using OpenQA.Selenium;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static SpecflowPages.CommonMethods;

namespace SpecflowPages.Utils
{
  public class LoginPage
    {
        public static void LoginStep()
        {
            Driver.NavigateUrl();
            Thread.Sleep(1000);

            //Click on Sign-In button
            Driver.driver.FindElement(By.XPath("//a[@class='item'][text()='Sign In']")).Click();
            

            //Enter Username
            Driver.driver.FindElement(By.XPath("//input[@type='text'][@name='email']")).SendKeys("sravanramba7991@gmail.com");

            //Enter password
            Driver.driver.FindElement(By.XPath("//input[@type='password'][@name='password']")).SendKeys("sravan@1991");
            Thread.Sleep(1000);
            //Click on Login Button
            Driver.driver.FindElement(By.XPath("//button[@class='fluid ui teal button'][text()='Login']")).Click();

            Thread.Sleep(7000);
            string msg = "Add New";
            string Actualmsg = Driver.driver.FindElement(By.XPath("//div[@class='ui teal button '][text()='Add New']")).Text;

            if (msg == Actualmsg)
            {
           Console.WriteLine("Test Passed");
          // CommonMethods.ExtentReports();
            Thread.Sleep(500);
           // test = CommonMethods.extent.StartTest("Login with valid data");
             Thread.Sleep(1000);
           //  CommonMethods.test.Log(LogStatus.Pass, "Test Passed");
           //  SaveScreenShotClass.SaveScreenshot(Driver.driver, "HomePage");
             
            }
            else
            {
              Console.WriteLine("Test Failed");
          //  CommonMethods.test.Log(LogStatus.Fail, "Test Failed");


             }

           
        }

    }
}
