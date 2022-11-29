using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using IC_NOV22_1.LoginPage;
using IC_NOV22_1.HomePage;
using IC_NOV22_1.TMPage;

IWebDriver driver = new ChromeDriver();

//Intialization and Decalaration of Loginpage
LoginPage LoginPageobj = new LoginPage();
LoginPageobj.LoginActions( driver);

//Intialization and Decalaration of Homenpage
HomePage HomePageobj = new HomePage();
HomePageobj.GotoTmPage(driver);

//Intialization and Decalaration of TMpage
TMpage Tmpageobj = new TMpage();
Tmpageobj.CreateTM(driver);
Tmpageobj.EditTM(driver);
Tmpageobj.DeleteTM(driver); 

