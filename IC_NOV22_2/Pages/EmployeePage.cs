

namespace IC_NOV22_2.Pages
{
    public class EmployeePage
    {
        public void CreateEmployee(IWebDriver driver)
        
        {
            //click create button
            IWebElement createButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
            createButton.Click();

            //Enter name in the text box
            
                IWebElement name = driver.FindElement(By.Name("Name"));
                name.SendKeys("Teenz");
            
            //Enter username in the textbox
            
                IWebElement username = driver.FindElement(By.Name("Username"));
                username.SendKeys("Teenz");
            
            //Enter contact in the textbox
            
                IWebElement contact = driver.FindElement(By.Id("ContactDisplay"));
                contact.SendKeys("9453262156");
            
            //Enter password in the textbox
            
                IWebElement password = driver.FindElement(By.Name("Password"));
                password.SendKeys("Nov@love2022");
            

            //Enter retypepassword in the textbox
            
                IWebElement retypePassword = driver.FindElement(By.Name("RetypePassword"));
                retypePassword.SendKeys("Nov@love2022");
            
            //Enter Vehicle in the textbox
            
               // IWebElement vehicle = driver.FindElement(By.Name("VehicleId_input"));
                //vehicle.SendKeys("car");
            
            //Enter group in the textbox
            
               // IWebElement group = driver.FindElement(By.XPath("//*[@id=\"UserEditForm\"]/div/div[8]/div/div/div[1]"));
               // group.SendKeys("whatsapp");
            
            //click on save button
            
                IWebElement employeeSaveButton = driver.FindElement(By.Id("SaveButton"));
                employeeSaveButton.Click();
                Thread.Sleep(3000);

            //click on List Button
                IWebElement backtolistButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
                backtolistButton.Click();
                Thread.Sleep(500);

             //goto lastpage
                IWebElement gotoemployeelastpage = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
                gotoemployeelastpage.Click();

            //check if Employee record create successfully
                IWebElement newnameTextbox = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
                Assert.That(newnameTextbox.Text == "Teenz");
            

        }


        public void EditEmployee(IWebDriver driver)
        {
            //goto lastpage
            IWebElement gotoemployeelastpage = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            gotoemployeelastpage.Click();
            Thread.Sleep(1000);
            IWebElement employeeEditButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[1]"));
            employeeEditButton.Click();
            IWebElement usernameEdit = driver.FindElement(By.Id("Username"));
            usernameEdit.Clear();
            usernameEdit.SendKeys("TETUD");
            IWebElement employeeSaveButtonEdit = driver.FindElement(By.Id("SaveButton"));
            employeeSaveButtonEdit.Click();

            //click on List Button
            IWebElement backtolistButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/div/a"));
            backtolistButton.Click();
            Thread.Sleep(500);
            
            // click on last button
            IWebElement gotolastpage = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            gotolastpage.Click();
            Thread.Sleep(500);

            //Record is edited or not
            IWebElement username = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[2]"));
            Assert.That(username.Text == "TETUD", "Employee is not edited");

        }



        public void DeleteEmployee(IWebDriver driver)
        {
            //goto lastpage
            IWebElement gotoemployeelastpage = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[4]/a[4]/span"));
            gotoemployeelastpage.Click();
            //click on deletebutton
            IWebElement employeeeDeleteButton = driver.FindElement(By.XPath("//*[@id=\"usersGrid\"]/div[3]/table/tbody/tr[last()]/td[3]/a[2]"));
            employeeeDeleteButton.Click();
            driver.SwitchTo().Alert().Accept();


        }

    } 
}
