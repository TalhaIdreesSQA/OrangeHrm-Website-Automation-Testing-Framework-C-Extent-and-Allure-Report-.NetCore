using Newtonsoft.Json.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.DevTools.V109.DOM;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQA_07_OrangeHrm_Talha
{
    public class AdminSearch : AdminSearchData
    {
        #region
        By username = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.oxd-table-filter > div.oxd-table-filter-area > form > div.oxd-form-row > div > div:nth-child(1) > div > div:nth-child(2) > input");
        By SearchBtn = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.oxd-table-filter > div.oxd-table-filter-area > form > div.oxd-form-actions > button.oxd-button.oxd-button--medium.oxd-button--secondary.orangehrm-left-space");
        By RadioBtn = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.orangehrm-paper-container > div.orangehrm-container > div > div.oxd-table-header > div > div:nth-child(1) > div > label > span");
        By EditBtn = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.orangehrm-paper-container > div.orangehrm-container > div > div.oxd-table-body > div > div > div:nth-child(6) > div > button:nth-child(2) > i");
        By UEdit = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div.oxd-form-row > div > div:nth-child(4) > div > div:nth-child(2) > input");
        By saveBTN = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div > form > div.oxd-form-actions > button.oxd-button.oxd-button--medium.oxd-button--secondary.orangehrm-left-space");
        By DelBtn = By.CssSelector("#app > div.oxd-layout > div.oxd-layout-container > div.oxd-layout-context > div > div.orangehrm-paper-container > div.orangehrm-container > div > div.oxd-table-body > div > div > div:nth-child(6) > div > button:nth-child(1) > i");
        By DelConfi = By.CssSelector("#app > div.oxd-overlay.oxd-overlay--flex.oxd-overlay--flex-centered > div > div > div > div.orangehrm-modal-footer > button.oxd-button.oxd-button--medium.oxd-button--label-danger.orangehrm-button-margin");
        Actions action = new Actions(driver);
        
        #endregion
        public void Admin_Search()
        {
            Reports.ChildNode("AdminSearch");
            Write("extentreport",username,Username,"UsernameSearch","UsernameSearch.png");
            ImplicitWait(3);
            Click("extentreport",SearchBtn,"SearchBtn","SearchBtn.png");
            ImplicitWait(2);
            Thread.Sleep(2000);
            Click("extentreport",EditBtn,"EditBtn","EditBtn.png");
            Thread.Sleep(5000);
            var element = driver.FindElement(UEdit);
            action.DoubleClick(element).Perform();
            Write("extentreport",UEdit,EditUsername,"EditUsername","EditUsername.png");
            Thread.Sleep(3000);
            Click("extentreport",saveBTN,"SaveBtn","Savebtn.png");
            Thread.Sleep(4000);
            Write("extentreport", username, EditUsername, "UsernameSearch", "UsernameSearch.png");
            ImplicitWait(3);
            Click("extentreport", SearchBtn, "SearchBtn", "SearchBtn.png");
            Thread.Sleep(3000);
            Click("extentreport", DelBtn, "DeleteBtn", "DeleteBtn.png");
            Thread.Sleep(2000);
            Click("extentreport", DelConfi, "DeleteConfirmBtn", "DeleteConfirmBtn.png");
            Thread.Sleep(2000);

        }
    }
}
