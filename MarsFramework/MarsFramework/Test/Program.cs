using MarsFramework.Pages;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsFramework
{
    public class Program
    {
        [TestFixture]
        [Category("Sprint1")]
        class Tenant : Global.Base
        {

            [Test,Description("To Check if user is able to save service with all valid data")]
            public void AddShareSkill()
            {
                // Creates a toggle for the given test, adds all log events under it    
                test = extent.StartTest("Share Skill");

                // Create an class and object to call the method
                Profile profileObj = new Profile();
                profileObj.ClickShareSkill();

                ServiceListings listingsobj = new ServiceListings();
                bool status = listingsobj.ShareSkill();

                if (status==true)
                {
                    ManageListings obj = new ManageListings();
                    obj.ListingVerification();
                }
                
                             
            }
            [Test,Description("To Check if user is able to save service with invalid data")]
            public void AddServiceWithInvalidValues()
            {
                test = extent.StartTest("Add Service with Invalid Data");

                // Create an class and object to call the method
                Profile profileObj = new Profile();
                profileObj.ClickShareSkill();

                ServiceListings listingsobj = new ServiceListings();
               bool result = listingsobj.ShareSkillInvalid();
                if(result)
                {
                    listingsobj.InvalidValueValidation();
                }


            }
            [Test,Description("To check  mandatory fields are validated for null values")]
            public void AddServiceWithNullValues()
            {
                test = extent.StartTest("Add Service with Null Values");

                // Create an class and object to call the method
                Profile profileObj = new Profile();
                profileObj.ClickShareSkill();

                ServiceListings listingsobj = new ServiceListings();
                listingsobj.NullValueValidation();
            }
        }
    }
}