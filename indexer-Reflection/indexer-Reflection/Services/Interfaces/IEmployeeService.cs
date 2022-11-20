using indexer_Reflection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer_Reflection.Services.Interfaces
{
    public interface IEmployeeService
    {
        double GetAllByAverageSalary(Predicate<Employee> predicate);
    }
}
