using indexer_Reflection.Models;
using indexer_Reflection.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer_Reflection.Services
{
    public class EmployeeService : IEmployeeService
    {
        public double GetAllByAverageSalary(Predicate<Employee> predicate)
        {
            var employees = GetAll();
            var result=employees.FindAll(predicate);
            return CalculateAverage(result);
        }

        private double CalculateAverage(List<Employee>employees)
        {
            //employees.Average(m => m.Salary);
            return employees.Sum(m=>m.Salary)/employees.Count();
        }

        private List<Employee> GetAll()
        {
            List<Employee> employees = new();
            employees.Add(new Employee { Age = 16, Salary = 2000 });
            employees.Add(new Employee { Age = 22, Salary = 100 });
            employees.Add(new Employee { Age = 33, Salary = 900 });
            employees.Add(new Employee { Age = 50, Salary = 200 });

            return employees;
        }
    }
}
