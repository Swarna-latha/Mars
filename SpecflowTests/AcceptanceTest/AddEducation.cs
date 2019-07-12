using OpenQA.Selenium;
using SpecflowPages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
   public class AddEducation 
    {
      

        [Given(@"I clicked on the Education tab under Profile page")]
        public void GivenIClickedOnTheEducationTabUnderProfilePage()
        {
            //Wait
            Thread.Sleep(3000);

            // Click on Profile tab
           Driver.driver.FindElement(By.XPath("//*[@id='account-profile-section']/div/section[1]/div/a[2]")).Click();

            //Click on Education Tab
            Driver.driver.FindElement(By.XPath("//a[@class='item'][text()='Education']")).Click();

        }

        [When(@"I add all details of my college")]
        public void WhenIAddAllDetailsOfMyCollege()
        {
            //Click on AddNew button Under Education tab
            Driver.driver.FindElement(By.XPath("(//DIV[@class='ui teal button '])[2]")).Click();

            //Enter college name
            Driver.driver.FindElement(By.XPath("//input[@type='text'][@name='instituteName']")).SendKeys("Andhra University");

            //Enter country of college
            Driver.driver.FindElement(By.XPath("//option[@value='India']")).Click();

            Thread.Sleep(4000);

            //Enter title 
            Driver.driver.FindElement(By.XPath("//option[@value='M.Tech']")).Click();

            //Enter degree 
            Driver.driver.FindElement(By.XPath("(//INPUT[@type='text'])[5]")).SendKeys("Mechanical");

            //Enter year of graduation
            Driver.driver.FindElement(By.XPath("//option[@value='2014']")).Click();

            //CLick on Add button
            Driver.driver.FindElement(By.XPath("//input[@type='button'][@class='ui teal button ']")).Click();

            Thread.Sleep(4000);
        }



        [Then(@"my education background details should be displayed under description")]
        public void ThenMyEducationBackgroundDetailsShouldBeDisplayedUnderDescription()
        {
           
        }


    }
}
