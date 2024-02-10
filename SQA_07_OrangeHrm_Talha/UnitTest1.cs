using NUnit.Allure.Attributes;
using NUnit.Allure.Core;

namespace SQA_07_OrangeHrm_Talha
{
    [AllureNUnit]
    [TestFixture]
    public class Tests
    {
        public TestContext instance;

        public TestContext TestContext
        {
            get { return instance; }
            set { instance = value; }
        }
        [OneTimeSetUp]
        public void ClassSetup()
        {
        }
        [OneTimeTearDown]
        public void ClassCleanup()
        {
        }

        [SetUp]

        public void Setup()
        {
            Reports.Report();
            BasePage.SeleniumInt();
        }
        [TearDown]
        public void TextCleaup()
        {
            Reports.flush();
            BasePage.driver.Close();
        }

        [Test]
        [AllureStep]
        public void LoginPage()
        {
            Reports.ParentNode(NUnit.Framework.TestContext.CurrentContext.Test.Name);
            LoginPage loginPage = new LoginPage();
            loginPage.LoginWithValidUserAndPaaword();
        }
        [Test]
        [AllureStep]
        public void Admin()
        {
            Reports.ParentNode(NUnit.Framework.TestContext.CurrentContext.Test.Name);
            Admin admin = new Admin();
            LoginPage loginPage = new LoginPage();
            loginPage.LoginWithValidUserAndPaaword();
            admin.AdminPage();
        }
        [Test]
        [AllureStep]
        public void AdminSearch()
        {
            Reports.ParentNode(NUnit.Framework.TestContext.CurrentContext.Test.Name);
            Admin admin = new Admin();
            LoginPage loginPage = new LoginPage();
            AdminSearch adminSearch = new AdminSearch();
            loginPage.LoginWithValidUserAndPaaword();
            admin.AdminPage();
            adminSearch.Admin_Search();
        }
        [Test]
        [AllureStep]
        public void MyInfo()
        {
            Reports.ParentNode(NUnit.Framework.TestContext.CurrentContext.Test.Name);
            AdminSearch adminSearch = new AdminSearch();
            MyInfo myInfo = new MyInfo();
            adminSearch.Admin_Search();
            myInfo.Info();

        }
        [Test]
        [AllureStep]
        public void PIm()
        {
            Reports.ParentNode(NUnit.Framework.TestContext.CurrentContext.Test.Name);
            LoginPage loginPage = new LoginPage();
            PIM pim = new PIM();
            loginPage.LoginWithValidUserAndPaaword();
            pim.PIM_Page();

        }

    }
    public class Assembly
    {
        [OneTimeSetUp]
        public void AssemblySetup()
        {
        }
        [OneTimeTearDown]
        public void AssemblyCleanup()
        {
        }

    }
}