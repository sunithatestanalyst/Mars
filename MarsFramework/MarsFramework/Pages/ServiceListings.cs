using AutoItX3Lib;
using MarsFramework.Global;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using RelevantCodes.ExtentReports;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static MarsFramework.Global.GlobalDefinitions;

namespace MarsFramework.Pages
{
    class ServiceListings
    {
        public ServiceListings()
        {
            PageFactory.InitElements(Global.GlobalDefinitions.driver, this);
        }

        //Locate Title 
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Write a title to describe the service you provide.']")]
        private IWebElement Title { get; set; }

        //Locate Description
        [FindsBy(How = How.XPath, Using = "//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']")]
        private IWebElement Description { get; set; }

        //Category
        [FindsBy(How = How.XPath, Using = "//select[@name='categoryId']")]
        private IWebElement Category { get; set; }

        //SubCategory
        [FindsBy(How = How.XPath, Using = "//select[@name='subcategoryId']")]
        private IWebElement Subcategory { get; set; }

        //Tag outer
        [FindsBy(How = How.XPath, Using = "//div[contains(@class,'form-wrapper field error')]")]
        private IWebElement Tagouter { get; set; }

        //Tag to inner text field
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[4]/div[2]/div[1]/div[1]/div[1]/div[1]/input[1]")]
        private IWebElement TagInner { get; set; }

        //Service type One off Service
        [FindsBy(How = How.XPath, Using = "//form[@class='ui form']//div[5]//div[2]//div[1]//div[2]//div[1]//input[1]")]
        private IWebElement ServiceOne { get; set; }

        //Service type Hourly basis service
        [FindsBy(How = How.XPath, Using = "//form[@class='ui form']//div[5]//div[2]//div[1]//div[1]//div[1]//input[1]")]
        private IWebElement ServiceHourly { get; set; }

        //Location type Onsite
        [FindsBy(How = How.XPath, Using = "//form[@class='ui form']//div[6]//div[2]//div[1]//div[1]//div[1]//input[1]")]
        private IWebElement LocationOnsite { get; set; }

        //Start date
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Start date']")]
        private IWebElement StartDate { get; set; }

        //End Date
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='End date']")]
        private IWebElement EndDate { get; set; }

        //Location type Online
        [FindsBy(How = How.XPath, Using = "//form[@class='ui form']//div[6]//div[2]//div[1]//div[2]//div[1]//input[1]")]
        private IWebElement LocationOnline { get; set; }

        //Skill Trade - skill Exchange
        [FindsBy(How = How.XPath, Using = "//form[@class='ui form']//div[8]//div[2]//div[1]//div[1]//div[1]//input[1]")]
        private IWebElement SkillExcha { get; set; }

        //Skill trade - credit
        [FindsBy(How = How.XPath, Using = "//form[@class='ui form']//div[8]//div[2]//div[1]//div[2]//div[1]//input[1]")]
        private IWebElement Skillcredit { get; set; }

        //Skill Exchange
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement SkillExchange { get; set; }

        //credit
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Amount']")]
        private IWebElement Credit { get; set; }

        // Work Samples
        [FindsBy(How = How.XPath, Using = "//i[@class='huge plus circle icon padding-25']")]
        private IWebElement Samples { get; set; }

        //Active
        [FindsBy(How = How.XPath, Using = "//label[contains(text(),'Hidden')]")]
        private IWebElement Active { get; set; }

        //Save
        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        private IWebElement Save { get; set; }

        //cancel
        [FindsBy(How = How.XPath, Using = "//input[@value='Cancel']")]
        private IWebElement Cancel { get; set; }

        //Days selection
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//div[2]//div[1]//div[1]//input[1]")]
        private IWebElement Days { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//div[2]//div[2]//input[1]")]
        private IWebElement time { get; set; }

        //Title validation message
        [FindsBy(How = How.XPath, Using = "//div[@class='ui basic red prompt label transition visible']")]
        private IWebElement TitleValidation { get; set; }

        //Description validation message for invalid
        [FindsBy(How = How.XPath, Using = "//div[@class='ui basic red prompt label transition visible']")]                                             
        private IWebElement DescriptionValidation { get; set; }

        //Description validation for null 
        [FindsBy(How =How.XPath,Using = "//div[contains(text(),'Description is required')]")]
        private IWebElement DescriptionValidationNull { get; set; }

        //Category validation message
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Category is required')]")]
        private IWebElement CategoryValidation { get; set; }

        //subcategory validation message
        [FindsBy(How = How.XPath, Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[3]/div[2]/div[1]/div[2]/div[2]/div[1]")]
        private IWebElement SubcategoryValidation { get; set; }

        //start date validation message
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Start Date cannot be set to a day in the past')]")]                                                                                     
        private IWebElement StartDateValidation { get; set; }

        // Tag validation message
        [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Tags are required')]")]
        private IWebElement TagValidation { get; set; }

        //skill exchange validation
        [FindsBy(How =How.XPath,Using = "/html[1]/body[1]/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[8]/div[4]/div[2]")]
        private IWebElement ExchangeValidation { get; set; }

        #region Adding service with valid values

        internal bool ShareSkill()
        {
            try
            {

                //Populate From Excel
                GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
                Thread.Sleep(2000);

                //Enter Title
                Title.SendKeys(ExcelLib.ReadData(2, "Title"));

                //Enter Description
                Description.SendKeys(ExcelLib.ReadData(2, "Description"));

                Thread.Sleep(2000);
                //Select Category
                SelectElement Categories = new SelectElement(Category);
                Categories.SelectByText(ExcelLib.ReadData(2, "Category"));

                //select Sub category
                SelectElement SubCategories = new SelectElement(Subcategory);
                SubCategories.SelectByText(ExcelLib.ReadData(2, "Subcategory"));

                Thread.Sleep(2000);
                //Enter Tags
                TagInner.SendKeys(ExcelLib.ReadData(2, "Tags"));
                TagInner.SendKeys(Keys.Enter);

                //Service type
                string ServiceToSelect = ExcelLib.ReadData(2, "ServiceType");
                if (ServiceToSelect == "One-off service")
                {
                    ServiceOne.Click();
                }
                else if (ServiceToSelect == "Hourly basis service")
                {
                    ServiceHourly.Click();
                }

                //select Location type
                string Locationtype = ExcelLib.ReadData(2, "LocationType");
                if (Locationtype == "On-site")
                {
                    LocationOnsite.Click();

                }
                else if (Locationtype == "Online")
                {
                    LocationOnline.Click();
                }
                Thread.Sleep(2000);
                string SDate = ExcelLib.ReadData(2, "StartDate");
                string[] SDateForm = SDate.Split(' ');

                StartDate.SendKeys(SDateForm[0]);

                string EDate = ExcelLib.ReadData(2, "EndDate");
                string[] EDateForm = EDate.Split(' ');

                EndDate.SendKeys(EDateForm[0]);

                Thread.Sleep(2000);
                string days = ExcelLib.ReadData(2, "AvailableDays");
                string DaysToLwercase = days.ToLower();

                string[] Dayslist = DaysToLwercase.Split(',');
                int count = Dayslist.Count();

                string StartTimevalue = ExcelLib.ReadData(2, "StartTime");
                string[] Starttimelist = StartTimevalue.Split(',');


                string EndTimeValue = ExcelLib.ReadData(2, "EndTime");
                string[] EndTimelist = EndTimeValue.Split(',');


                for (int i = 0; i <= count - 1; i++)
                {
                    if (Dayslist[i].ToLower() == "sunday")
                    {

                        GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[2]//div[1]//div[1]//input[1]")).Click();
                        IWebElement StartTime = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[2]//div[2]//input[1]"));
                        IWebElement EndTime = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[2]//div[3]//input[1]"));
                        StartTime.SendKeys(Starttimelist[i]);
                        EndTime.SendKeys(EndTimelist[i]);
                    }
                    else if (Dayslist[i].ToLower() == "monday")
                    {
                        GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[3]//div[1]//div[1]//input[1]")).Click();
                        IWebElement StartTime = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[3]//div[2]//input[1]"));
                        IWebElement EndTime = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[3]//div[3]//input[1]"));
                        StartTime.SendKeys(Starttimelist[i]);
                        EndTime.SendKeys(EndTimelist[i]);

                    }
                    else if (Dayslist[i].ToLower() == "tuesday")
                    {
                        GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[4]//div[1]//div[1]//input[1]")).Click();
                        IWebElement StartTime = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[4]//div[2]//input[1]"));
                        IWebElement EndTime = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[4]//div[3]//input[1]"));
                        StartTime.SendKeys(Starttimelist[i]);
                        EndTime.SendKeys(EndTimelist[i]);
                    }

                    else if (Dayslist[i].ToLower() == "wednesday")
                    {
                        GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[5]//div[1]//div[1]//input[1]")).Click();
                        IWebElement StartTime = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[5]//div[2]//input[1]"));
                        IWebElement EndTime = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[5]//div[3]//input[1]"));
                        StartTime.SendKeys(Starttimelist[i]);
                        EndTime.SendKeys(EndTimelist[i]);
                    }

                    else if (Dayslist[i].ToLower() == "thursday")
                    {
                        GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[6]//div[1]//div[1]//input[1]")).Click();
                        IWebElement StartTime = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[6]//div[2]//input[1]"));
                        IWebElement EndTime = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[6]//div[3]//input[1]"));
                        StartTime.SendKeys(Starttimelist[i]);
                        EndTime.SendKeys(EndTimelist[i]);
                    }
                    else if (Dayslist[i].ToLower() == "friday")
                    {
                        GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[7]//div[1]//div[1]//input[1]")).Click();
                        IWebElement StartTime = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[7]//div[2]//input[1]"));
                        IWebElement EndTime = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[7]//div[3]//input[1]"));
                        StartTime.SendKeys(Starttimelist[i]);
                        EndTime.SendKeys(EndTimelist[i]);
                    }

                    else if (Dayslist[i].ToLower() == "saturday")
                    {
                        GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[8]//div[1]//div[1]//input[1]")).Click();
                        IWebElement StartTime = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[8]//div[2]//input[1]"));
                        IWebElement EndTime = GlobalDefinitions.driver.FindElement(By.XPath("//div[@class='form-wrapper']//div[8]//div[3]//input[1]"));
                        StartTime.SendKeys(Starttimelist[i]);
                        EndTime.SendKeys(EndTimelist[i]);
                    }
                }


                //select Skill trade
                string SkillTrade = ExcelLib.ReadData(2, "SkillTrade");
                if (SkillTrade == "Credit")
                {
                    Skillcredit.Click();
                    //Add credit
                    Credit.SendKeys(ExcelLib.ReadData(2, "Credit"));
                }
                else if (SkillTrade == "Skill-exchange")
                {
                    SkillExcha.Click();

                    //Add Skill Exchange
                    SkillExchange.SendKeys(ExcelLib.ReadData(2, "SkillExchange"));
                    SkillExchange.SendKeys(Keys.Enter);
                }

                Samples.Click();
                Thread.Sleep(2000);
                AutoItX3 file = new AutoItX3();
                file.WinActivate("Open");
                file.Send(ExcelLib.ReadData(2, "WorkSamples"));
                Thread.Sleep(1000);
                file.Send("{ENTER}");

                Thread.Sleep(2000);

                Save.Click();

                Thread.Sleep(2000);
                return true;
            }

            catch (Exception e)
            {

                Base.test.Log(LogStatus.Fail, "Error in adding service" + e.Message);
                return false;
            }
        }
        #endregion
        #region Invalid values
        internal bool ShareSkillInvalid()
        {

            try
            {

                //Populate From Excel
                GlobalDefinitions.ExcelLib.PopulateInCollection(Base.ExcelPath, "ShareSkill");
                Thread.Sleep(2000);

                //Enter Title
                Title.SendKeys(ExcelLib.ReadData(3, "Title"));

                //Enter Description
                Description.SendKeys(ExcelLib.ReadData(3, "Description"));

                Thread.Sleep(2000);

                //Enter Tag
                TagInner.SendKeys(ExcelLib.ReadData(3, "Tags"));


                string SInDate = ExcelLib.ReadData(3, "StartDate");
                string[] SInDateForm = SInDate.Split(' ');
                StartDate.SendKeys(SInDateForm[0]);

                string EInDate = ExcelLib.ReadData(2, "EndDate");
                string[] EInDateForm = EInDate.Split(' ');
                EndDate.SendKeys(EInDateForm[0]);
                //Click Save
                Save.Click();
                return true;
            }

            catch (Exception)
            {
                return false;
            }

        }

        internal void InvalidValueValidation()
        {

            try
            {
                Thread.Sleep(3000);
                //Title validation message

                string ActualTitleValidationmsg = TitleValidation.Text;
                if ((ActualTitleValidationmsg == "First character must be an alphabet character or a number.") || (ActualTitleValidationmsg == "Special characters are not allowed."))
                {
                    Base.test.Log(LogStatus.Pass, "Title Validation message is displayed correctly");
                }
                else
                {
                    Base.test.Log(LogStatus.Fail, "Title Validation message is not displayed correctly");
                }
                Thread.Sleep(2000);

                //Description validation message
                string ActualDescriptionValidationmsg = DescriptionValidation.Text;
                if ((ActualDescriptionValidationmsg == "First character must be an alphabet character or a number.") || (ActualDescriptionValidationmsg == "Special characters are not allowed."))
                {
                    Base.test.Log(LogStatus.Pass, "Description Validation message is displayed correctly");
                }
                else
                {
                    Base.test.Log(LogStatus.Fail, "Description Validation message is not displayed correctly");
                }

                //category validation 
                string ActualCategoryValidationmsg = CategoryValidation.Text;
                if (ActualCategoryValidationmsg == "Category is required")
                {
                    Base.test.Log(LogStatus.Pass, "Category Validation message is displayed correctly");
                }
                else
                {
                    Base.test.Log(LogStatus.Fail, "Category Validation message is not displayed correctly");
                }

             
                IJavaScriptExecutor js = (IJavaScriptExecutor)Global.GlobalDefinitions.driver;
                js.ExecuteScript("window.scrollBy(0,1200)");

                //Start date validation
                string ExpectedStartDateValidaion = StartDateValidation.Text;
                if ((ExpectedStartDateValidaion == "Start Date cannot be set to a day in the past") || (ExpectedStartDateValidaion == "Start Date shouldn't be greater than End Date"))
                {
                    Base.test.Log(LogStatus.Pass, "StartDate Validation message is displayed correctly");
                }
                else
                {
                    Base.test.Log(LogStatus.Fail, "StartDate Validation message is not displayed correctly");
                }
            }
            catch(Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Error in validating Invalid values" + e.Message);
            }
        }
        #endregion
        #region Null values
        internal void NullValueValidation()
        {

            try
            {
                Save.Click();

                Thread.Sleep(3000);
                //Title validation message

                string ActualTitleValidationmsg = TitleValidation.Text;
                if (ActualTitleValidationmsg == "Title is required")
                {
                    Base.test.Log(LogStatus.Pass, "Title Validation message is displayed correctly");
                }
                else
                {
                    Base.test.Log(LogStatus.Fail, "Title Validation message is not displayed correctly");
                }
                Thread.Sleep(2000);

                //Description validation message
               
                string ActualDescriptionValidationmsg = DescriptionValidationNull.Text;
                if ((ActualDescriptionValidationmsg == "Description is required"))
                {
                    Base.test.Log(LogStatus.Pass, "Description Validation message is displayed correctly");
                }
                else
                {
                    Base.test.Log(LogStatus.Fail, "Description Validation message is not displayed correctly");
                }

                //category validation 
                string ActualCategoryValidationmsg = CategoryValidation.Text;
                if (ActualCategoryValidationmsg == "Category is required")
                {
                    Base.test.Log(LogStatus.Pass, "Category Validation message is displayed correctly");
                }
                else
                {
                    Base.test.Log(LogStatus.Fail, "Category Validation message is not displayed correctly");
                }

                //Tag validation
                string ExpectedTagValidation = TagValidation.Text;
                if (ExpectedTagValidation == "Tags are required")
                {
                    Base.test.Log(LogStatus.Pass, "Tag Validation message is displayed correctly");
                }

                else
                {
                    Base.test.Log(LogStatus.Fail, "Tag Validation message is not displayed correctly");
                }

             }
            catch (Exception e)
            {
                Base.test.Log(LogStatus.Fail, "Error in validating null values" + e.Message);
            }
        }
        #endregion
    }

}

