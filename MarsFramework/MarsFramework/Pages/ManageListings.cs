using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MarsFramework.Global.GlobalDefinitions;

namespace MarsFramework.Pages
{
    class ManageListings
    {

        public ManageListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

      
        internal void ListingVerification()
        {
            //Populate the Excel Sheet
             GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
             GlobalDefinitions.WaitForElement(GlobalDefinitions.driver, By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]"), 5);

            IWebElement Title = GlobalDefinitions.driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[3]"));

            if (Title.Text == ExcelLib.ReadData(2, "Title"))
            {
                Base.test.Log(LogStatus.Pass, "Service listed properly");

            }
            else
            {
                Base.test.Log(LogStatus.Fail, "Service is not added properly");

            }
        }
    }
}
