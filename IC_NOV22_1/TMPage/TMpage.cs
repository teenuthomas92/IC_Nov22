using IC_NOV22_1.Utilities;
using OpenQA.Selenium;


namespace IC_NOV22_1.TMPage
{
    public class TMpage
    {
        public void CreateTM(IWebDriver driver)
        {
            //click on create New Button
            IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createNewButton.Click();

            //select typecode from the dropdown
            IWebElement typeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
            typeCode.Click();
            IWebElement time = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
            time.Click();

            //Enter code in textbox
            IWebElement code = driver.FindElement(By.Name("Code"));
            code.SendKeys("CS010");

            //Enter Description
            IWebElement description = driver.FindElement(By.Name("Description"));
            description.SendKeys("Nov2022");

            //Enter Price per Unit
            IWebElement pricePerUnit = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
            pricePerUnit.SendKeys("2500");

            //click on save button
            IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
            saveButton.Click();

            //Thread.Sleep(1500);//Hold for 1.5 Seconds

            Wait.WaitForElementToBeClickable(driver, "XPath", "//*[@id=\"tmsGrid\"]/div[4]/a[4]/span", 2);


            //click on last page button
            IWebElement gotoLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
            gotoLastPageButton.Click();



            //check whether new record created or not
            IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));

            if (newCode.Text == "CS010")
            {
                Console.WriteLine("Record created successfully");
            }
            else
            {
                Console.WriteLine("Record not created successfully");
            }
        }


        public void EditTM(IWebDriver driver)
        {
            // Go to first page
            IWebElement firstPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[1]/span"));
            firstPageButton.Click();
            //Edit the time and material details
            IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[1]/td[5]/a[1]"));
            editButton.Click();
            IWebElement codeEdit = driver.FindElement(By.Id("Code"));
            Console.WriteLine(codeEdit.Text);
            codeEdit.Clear();
            codeEdit.SendKeys("TETUD");
            IWebElement saveButtonEdit = driver.FindElement(By.Id("SaveButton"));
            saveButtonEdit.Click();
            
            Thread.Sleep(1000);
            //check whether the detail edited or not
            IWebElement newCodeEdit = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[1]/td[1]"));
            Console.WriteLine(newCodeEdit.Text);

            if (newCodeEdit.Text == "TETUD")
            {
                Console.WriteLine("Record edited");
            }
            else
            {
                Console.WriteLine("Record not edited");
            }

        }
        public void DeleteTM(IWebDriver driver)
        {
            //Delete the time and material details
            IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[4]/td[5]/a[2]"));
            deleteButton.Click();
            driver.SwitchTo().Alert().Accept();

            Thread.Sleep(1000);

            //check whether the detail deleted or not
            IWebElement numberOfEntries = driver.FindElement(By.XPath("//*[@id=\'tmsGrid\']/div[4]/span[2]"));
            if (numberOfEntries.Text == "10256")
            {
                Console.WriteLine("Record not deleted");
            }
            else
            {
                Console.WriteLine("Record deleted");
            }
        }
    }
}