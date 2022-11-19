using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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


