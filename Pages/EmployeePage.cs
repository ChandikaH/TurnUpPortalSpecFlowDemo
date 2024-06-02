using OpenQA.Selenium;

namespace TurnUpPortalSpecFlowDemo.Pages
{
    public class EmployeePage
    {
        public void CreateEmployeeRecord(IWebDriver webDriver)
        {
            Console.WriteLine("Employee Record Created");
        }

        public void EditEmployeeRecord(IWebDriver webDriver)
        {
            Console.WriteLine("Employee Record Edited");
        }

        public void DeleteEmployeeRecord(IWebDriver webDriver)
        {
            Console.WriteLine("Employee Record Deleted");
        }
    }
}
