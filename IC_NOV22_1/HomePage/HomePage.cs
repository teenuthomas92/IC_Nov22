using OpenQA.Selenium;


namespace IC_NOV22_1.HomePage
{
    public class HomePage{
        public void GotoTmPage(IWebDriver driver)
        {
            //click on the admistration menu

            IWebElement admistrationMenu = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            admistrationMenu.Click();

            //click on Time&Material module from dropdown
            IWebElement timeMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timeMaterial.Click();

        }

    }
}
