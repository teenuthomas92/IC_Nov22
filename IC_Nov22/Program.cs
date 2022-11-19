using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

IWebDriver driver= new ChromeDriver();

driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");
driver.Manage().Window.Maximize ();

IWebElement usernametextbox = driver.FindElement(By.Id("UserName"));
usernametextbox.SendKeys("hari");

IWebElement passwordtextbox = driver.FindElement(By.Id("Password"));
passwordtextbox.SendKeys("123123");

IWebElement loginbutton = driver.FindElement(By.XPath("//*[@id='loginForm']/form/div[3]/input[1]"));
loginbutton.Click();

IWebElement hellohari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
String helloharistring = hellohari.Text;

if (helloharistring == "Hello hari!")
{
    Console.WriteLine("Login Successfully");
} else
{
    Console.WriteLine("Login Failed");
}


