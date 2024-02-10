using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_07_OrangeHrm_Talha
{
    public class MyInfo : MyInfoData
    {
        #region
        By InfoBtn = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-navigation > aside > nav > div.oxd-sidepanel-body > ul > li:nth-child(6) > a > span");
        By username_emp = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > div > div.orangehrm-edit-employee-content > div.orangehrm-horizontal-padding.orangehrm-vertical-padding > form > div:nth-child(1) > div.oxd-grid-1.orangehrm-full-width-grid > div > div > div.--name-grouped-field > div:nth-child(1) > div:nth-child(2) > input");
        By middlename_emp = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > div > div.orangehrm-edit-employee-content > div.orangehrm-horizontal-padding.orangehrm-vertical-padding > form > div:nth-child(1) > div.oxd-grid-1.orangehrm-full-width-grid > div > div > div.--name-grouped-field > div:nth-child(2) > div:nth-child(2) > input");
        By lastname_emp = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > div > div.orangehrm-edit-employee-content > div.orangehrm-horizontal-padding.orangehrm-vertical-padding > form > div:nth-child(1) > div.oxd-grid-1.orangehrm-full-width-grid > div > div > div.--name-grouped-field > div:nth-child(3) > div:nth-child(2) > input");
        By radioBtn = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > div > div.orangehrm-edit-employee-content > div.orangehrm-horizontal-padding.orangehrm-vertical-padding > form > div:nth-child(5) > div:nth-child(2) > div:nth-child(2) > div > div.--gender-grouped-field > div:nth-child(1) > div:nth-child(2) > div > label");
        By saveBtn = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > div > div.orangehrm-edit-employee-content > div.orangehrm-horizontal-padding.orangehrm-vertical-padding > form > div.oxd-form-actions > button");
        By EmpId = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > div > div.orangehrm-edit-employee-content > div.orangehrm-horizontal-padding.orangehrm-vertical-padding > form > div:nth-child(3) > div:nth-child(1) > div:nth-child(1) > div > div:nth-child(2) > input");
        #endregion
        public void Info()
        {
            Reports.ChildNode("Info Page");
            Click("extentreport",InfoBtn,"MyInfoBtn", "MyInfoBtn.png");
            ImplicitWait(2);
            Write("extentreport",username_emp,EmpFirst,"UsernameEmp", "UsernameEmp.png");
            ImplicitWait(2);
            Write("extentreport",middlename_emp,EmpMiddle,"MiddlenameEmp", "MiddlenameEmp.png");
            ImplicitWait(2);
            Write("extentreport",lastname_emp,EmpLast,"LastnameEmp", "LastnameEmp.png");
            ImplicitWait(2);
            Key(lastname_emp, "tab");
            Key(lastname_emp, "tab");
            Click("extentreport",EmpId,"EmployeeId", "EmployeeId.png");
            Thread.Sleep(2000);
            Click("extentreport",radioBtn,"RadioBtn","RadioBtn.png");
            ImplicitWait(2);
            Click("extentreport", saveBtn, "SaveBtn", "SaveBtn.png");
            Thread.Sleep(3000);
        }
    }
}
