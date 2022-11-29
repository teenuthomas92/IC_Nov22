


namespace IC_NOV22_2.HomePage
{
    public class Homepage
    {
        public void GotoTmPage(IWebDriver driver)
        {
            //click on the admistration menu
            
            IWebElement admistrationMenu = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            admistrationMenu.Click();
            Thread.Sleep(1000);

            //click on Time&Material module from dropdown
            IWebElement timeMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeMaterial.Click();

        }

        public void GotoEmployeePage(IWebDriver driver)
        {
            IWebElement admistrationMenu = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
            admistrationMenu.Click();
            Thread.Sleep(1000);

            //click on Employee module from dropdown
            IWebElement employee = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[2]/a"));
            employee.Click();

        }
    }
}
