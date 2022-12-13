
using IC_NOV22_2.Utilities;

namespace IC_NOV22_2.Tests
{
    [TestFixture]
    [Parallelizable]
    public class TM_Tests : CommonDriver
    {

        [Test, Order(1), Description("Check if user is able to create a new record with valid data")]
        public void CreateTM_Test()
        {
            Homepage HomePageobj = new Homepage();
            HomePageobj.GotoTmPage(driver);
            TMpage Tmpageobj = new TMpage();
            Tmpageobj.CreateTM(driver);
        }
        [Test, Order(2), Description("Check if user is able to edit a new record with valid data")]
        public void EditTM_Test()
        {
            Homepage HomePageobj = new Homepage();
            HomePageobj.GotoTmPage(driver);
            TMpage Tmpageobj = new TMpage();
          //  Tmpageobj.EditTM(driver, Description);
        }
        [Test, Order(3), Description("Check if user is able to delete a new record with valid data")]
        public void DeleteTM_Test()
        {
            Homepage HomePageobj = new Homepage();
            HomePageobj.GotoTmPage(driver);
            TMpage Tmpageobj = new TMpage();
            Tmpageobj.DeleteTM(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            driver.Quit();
        }


    }
}
