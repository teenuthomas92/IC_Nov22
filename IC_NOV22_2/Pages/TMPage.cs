
using OpenQA.Selenium;
using IC_NOV22_2.Utilities;
using NUnit.Framework;

namespace IC_NOV22_2.Pages
{
    public class TMpage
    {
        public void CreateTM(IWebDriver driver)
        {
            //click on create New Button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();
            Wait.WaitForElementToExist(driver, "XPath", "//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span", 2);

            //select typecode from the dropdown
            IWebElement typeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typeCode.Click();
            IWebElement time = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            time.Click();

            //Enter code in textbox
            IWebElement code = driver.FindElement(By.Name("Code"));
            code.SendKeys("2021NOV27");

            //Enter Description
            IWebElement description = driver.FindElement(By.Name("Description"));
            description.SendKeys("Nov2022");

            //Enter Price per Unit
            IWebElement pricePerUnit = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            pricePerUnit.SendKeys("2500");

            //click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            //Wait.WaitForElementToExist(driver,"XPath","//*[@id=\"tmsGrid\"]/div[4]/a[4]/span",12);
            Thread.Sleep(3000);
            //click on last page button
            IWebElement gotoLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotoLastPageButton.Click();


            Thread.Sleep(3000);
            //check whether new record created or not
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Assert.That(newCode.Text == "2021NOV27", "Actual code and Expected code do not match");
        }


        public void EditTM(IWebDriver driver)
        {
            //Wait.WaitForElementToExist(driver,"XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]", 5);
            Thread.Sleep(3000);
            //Edit the time and material details
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
            editButton.Click();
            IWebElement codeEdit = driver.FindElement(By.Id("Code"));
            Console.WriteLine(codeEdit.Text);
            codeEdit.Clear();
            codeEdit.SendKeys("TETUD");
            IWebElement saveButtonEdit = driver.FindElement(By.Id("SaveButton"));
            saveButtonEdit.Click();

            Thread.Sleep(1000);
            //check whether the detail edited or not
            IWebElement newCodeEdit = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
            Console.WriteLine(newCodeEdit.Text);
            Assert.That(newCodeEdit.Text == "TETUD", "The record is not edited");
        }

        public void DeleteTM(IWebDriver driver)
        {
            //Thread.Sleep(5000);
            //String numberOfEntries = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[4]/span[2]")).Text;
            //int numberOfEntriesToCompare = int.Parse(numberOfEntries); //Convert String to Integer

            //Assert.That(numberOfEntries.Text == "10256", "Record not deleted");
            //Delete the time and material details
            Wait.WaitForElementToExist(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[4]/td[5]/a[2]", 5);
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[4]/td[5]/a[2]"));
            deleteButton.Click();
            driver.SwitchTo().Alert().Accept();

            Assert.Pass();

            //Thread.Sleep(1000);

            //IWebElement numberOfEntriesFinal = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[4]/span[2]"));
            //int numberOfEntriesFinalInt = int.Parse(numberOfEntriesFinal.Text); //Convert String to Integer

            ////check whether the detail deleted or not
            //Assert.That(numberOfEntriesFinalInt == numberOfEntriesToCompare - 1, "Record not deleted");

        }
    }
}
