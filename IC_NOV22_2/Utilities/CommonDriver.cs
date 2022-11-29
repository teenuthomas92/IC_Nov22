

namespace IC_NOV22_2.Utilities
{
    public class CommonDriver
    {
        public static IWebDriver driver;
       
        [OneTimeSetUp]
        public void LoginSteps()
        {
            driver = new ChromeDriver();
            Loginpage Loginpageobj = new Loginpage();
            Loginpageobj.LoginActions(driver);
        }

        [OneTimeTearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }
    }
}
