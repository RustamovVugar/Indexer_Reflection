using indexer_Reflection.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer_Reflection.Services.Interfaces
{
    internal interface IPersonService
    {
        List<string> GetFullDate(Predicate<Person> predicate);    

        int GetFilteredDatasCount(Predicate<Person> predicate);
    }
}
