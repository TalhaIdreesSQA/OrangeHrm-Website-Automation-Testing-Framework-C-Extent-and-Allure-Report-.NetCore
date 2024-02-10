using OpenQA.Selenium;
using SQA_07_OrangeHrm_Talha;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SQA_07_OrangeHrm_Talha
{
    public class LoginPage : LoginPageData
    {
        #region
        By User = By.Name("username");
        By Pass = By.Name("password");
        By LoginBtn = By.CssSelector("#app > div.orangehrm-login-layout > div > div.orangehrm-login-container > div > div.orangehrm-login-slot > div.orangehrm-login-form > form > div.oxd-form-actions.orangehrm-login-action > button");
        #endregion

        public void LoginWithValidUserAndPaaword()
        {
            Reports.ChildNode("LoginWithValidUserAndPaaword");
            driver.Manage().Window.Maximize();
            driver.Url = Url;
            ImplicitWait(1);
            //Thread.Sleep(1000);
            Write("extentreport", User, Username, "Username", "Username.png");
            ImplicitWait(1);
            //Thread.Sleep(1000);
            Write("extentreport", Pass, Password, "Password", "Password.png");
            ImplicitWait(1);
            //Thread.Sleep(1000);
            Click("extentreport", LoginBtn, "LoginBtn", "LoginBtn.png");
            ImplicitWait(1);
            //Thread.Sleep(5000);
            //Click();
        }

    }
}
