using OpenQA.Selenium;
using SQA_07_OrangeHrm_Talha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_07_OrangeHrm_Talha
{
    public class Admin : AdminData
    {
        #region
        By admin_Btn = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-navigation > aside > nav > div.oxd-sidepanel-body > ul > li:nth-child(1) > a");
        By add_Btn = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.orangehrm-paper-container > div.orangehrm-header-container > button > i");
        By user_Role = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(1) > div > div:nth-child(2) > div > div > div.oxd-select-text-input");
        By emp_Name = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(2) > div > div:nth-child(2) > div > div > input");
        By status = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(3) > div > div:nth-child(2) > div > div > div.oxd-select-text-input");
        By username = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div:nth-child(1) > div > div:nth-child(4) > div > div:nth-child(2) > input");
        By password = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div.oxd-form-row.user-password-row > div > div.oxd-grid-item.oxd-grid-item--gutters.user-password-cell > div > div:nth-child(2) > input");
        By confirm_Pass = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div.oxd-form-row.user-password-row > div > div:nth-child(2) > div > div:nth-child(2) > input");
        By save_Btn = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div.oxd-form-actions > button.oxd-button.oxd-button--medium.oxd-button--secondary.orangehrm-left-space");
        By result = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-navigation > header > div.oxd-topbar-header > div.oxd-topbar-header-title > span > h6.oxd-text.oxd-text--h6.oxd-topbar-header-breadcrumb-level");
        #endregion

        public void AdminPage()
        {
            Reports.ChildNode("AdminPage");
            Click("extentreport",admin_Btn,"ClickAdminBtn", "ClickAdminBtn.png");
            
            ImplicitWait(2);
            Click("extentreport", add_Btn, "ClickAddBtn", "ClickAddBtn.png");
            ImplicitWait(2);
            Click("extentreport", user_Role, "UserRoleDropDown", "UserRoleDropDown.png");
            
            ImplicitWait(1);
            Key(user_Role,"arrowdown");
            Key(user_Role,"arrowdown");
            Write("extentreport",user_Role,Keys.Enter,"SelectionUser","SelectionUser.png");
            ImplicitWait(1);
            Key(emp_Name,"enter");
            Write("extentreport", emp_Name, "a", "Employee", "Employee.png");
            Thread.Sleep(3000);
            Key(emp_Name,"arrowdown");
            Key(emp_Name,"arrowdown");
            Key(emp_Name, "enter");
            Key(emp_Name, "tab");
            
            ImplicitWait(1);
            Key(status,"arrowdown");
            Key(status,"arrowdown");
            Write("extentreport",status,Keys.Enter,"Status","Status.png");
           
            ImplicitWait(1);
            Write("extentreport",username,Username,"Username","Username.png");
            ImplicitWait(1);
            Write("extentreport",password,Pass,"Password","Password.png");
            ImplicitWait(1);
            Write("extentreport",confirm_Pass,Pasconfirm,"ConfirmPass", "ConfirmPass.png");
            Thread.Sleep(2000);
            Click("extentreport",save_Btn,"SaveBtn","SaveBtn.png");
            Thread.Sleep(5000);
            Text("extentreport",result, "User Management","Cinfirmation","Confirmation.png");
        }
    }
}