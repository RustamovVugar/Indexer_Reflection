using indexer_Reflection.Services;
using indexer_Reflection.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer_Reflection.Controllers
{
    public class EmployeeController
    {
        public static void GetEmployeeSalaryAverage()
        {
            IEmployeeService employeeService = new EmployeeService();
            Console.WriteLine(employeeService.GetAllByAverageSalary(m => m.Age > 20 && m.Age < 40));
        }
    }
}
