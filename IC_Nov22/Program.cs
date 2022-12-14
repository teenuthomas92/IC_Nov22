using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System.Xml.Linq;

IWebDriver driver= new ChromeDriver();
driver.Manage().Window.Maximize();
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");

IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

IWebElement loginButton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
loginButton.Click();

IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
String helloHariString = helloHari.Text;

if (helloHariString == "Hello hari!")
{
    Console.WriteLine("Login Successfully");
} else
{
    Console.WriteLine("Login Failed");
}

//click on the admistration menu

IWebElement admistrationMenu = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
admistrationMenu.Click();

//click on Time&Material module from dropdown
IWebElement timeMaterial = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
timeMaterial.Click();

//click on create New Button
IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createNewButton.Click();

//select typecode from the dropdown
IWebElement typeCode = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
typeCode.Click();

Thread.Sleep(1500);//Hold for 1.5 Seconds

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

Thread.Sleep(1500);//Hold for 1.5 Seconds

//click on last page button
IWebElement gotoLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
gotoLastPageButton.Click();
Thread.Sleep(1500);//Hold for 1.5 Seconds


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


//Edit the time and material details
IWebElement editButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[6]/td[5]/a[1]"));
editButton.Click();
IWebElement codeEdit = driver.FindElement(By.Id("Code"));
Console.WriteLine(codeEdit.Text);
codeEdit.Clear();
codeEdit.SendKeys("TETUD");
IWebElement saveButtonEdit = driver.FindElement(By.Id("SaveButton"));
saveButtonEdit.Click();

Thread.Sleep(1000);
//check whether the detail edited or not
IWebElement newCodeEdit = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[6]/td[1]"));

Console.WriteLine(newCodeEdit.Text);


if (newCodeEdit.Text == "TETUD")
{
    Console.WriteLine("Record edited");
}
else
{
    Console.WriteLine("Record not edited");
}
Thread.Sleep(1000);

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


















