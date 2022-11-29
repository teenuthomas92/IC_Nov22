

using IC_NOV22_2.Utilities;

namespace IC_NOV22_2.Tests
{
    public class Employee_Tests: CommonDriver
    {
        [Test, Order(1)]
        public void CreateEmployee_Test()
        {
            Homepage HomePageobj = new Homepage();
            HomePageobj.GotoEmployeePage(driver);
            EmployeePage Employeepageobj = new EmployeePage();
            Employeepageobj.CreateEmployee(driver);

        }
        [Test,Order(2)]
        public void EditEmployee_Test()
        {
            Homepage HomePageobj = new Homepage();
            HomePageobj.GotoEmployeePage(driver);
            EmployeePage Employeepageobj = new EmployeePage();
            Employeepageobj.EditEmployee(driver);

        }
        [Test,Order(3)]
        public void DeleteEmployee_Test()
        {
            Homepage HomePageobj = new Homepage();
            HomePageobj.GotoEmployeePage(driver);
            EmployeePage Employeepageobj = new EmployeePage();
            Employeepageobj.DeleteEmployee(driver);
        }
    }
}
