using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_07_OrangeHrm_Talha
{
    public class PIM : PIMData
    {
        #region
        By PimBtn = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-navigation > aside > nav > div.oxd-sidepanel-body > ul > li:nth-child(2) > a");
        By AddEmp = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-navigation > header > div.oxd-topbar-body > nav > ul > li:nth-child(3)");
        By Firstname = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div.orangehrm-employee-container > div.orangehrm-employee-form > div:nth-child(1) > div.oxd-grid-1.orangehrm-full-width-grid > div > div > div.--name-grouped-field > div:nth-child(1) > div:nth-child(2) > input");
        By MiddleName = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div.orangehrm-employee-container > div.orangehrm-employee-form > div:nth-child(1) > div.oxd-grid-1.orangehrm-full-width-grid > div > div > div.--name-grouped-field > div:nth-child(2) > div:nth-child(2) > input");
        By Lastname = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div.orangehrm-employee-container > div.orangehrm-employee-form > div:nth-child(1) > div.oxd-grid-1.orangehrm-full-width-grid > div > div > div.--name-grouped-field > div:nth-child(3) > div:nth-child(2) > input");
        By EmpId = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div.orangehrm-employee-container > div.orangehrm-employee-form > div:nth-child(1) > div.oxd-grid-2.orangehrm-full-width-grid > div > div > div:nth-child(2) > input");
        By SaveBtn = By.XPath("/html/body/div/div[1]/div[2]/div[2]/div/div/form/div[2]/button[2]/text()");
        #endregion

        public void PIM_Page()
        {
            Reports.ChildNode("PIM_Page");
            Click("extentreport",PimBtn,"ClickPIMBtn", "ClickPIMBtn.PNG");
            Click("extentreport",AddEmp,"Addemplyee","Addemplyee.png");
            Thread.Sleep(2000);
            Write("extentreport",Firstname,EmpFirstname,"EmpFirstName", "EmpFirstName.png");
            Write("extentreport",MiddleName,EmpMiddlename,"EmpMiddleName", "EmpMiddleName.png");
            Write("extentreport",Lastname,EmpLastname,"EmpLastName", "EmpLastName.png");
            Key(Lastname,"tab");
            Write("extentreport",EmpId,"2012","EmpId", "EmpId.png");
            Key(EmpId,"key");
            Key(EmpId,"key");
            Key(EmpId,"key");
            Key(EmpId,"enter");
            Write("Extentreport",SaveBtn,"","EmplyeeSaveBtn", "EmplyeeSaveBtn.png");


        }
    }
}
