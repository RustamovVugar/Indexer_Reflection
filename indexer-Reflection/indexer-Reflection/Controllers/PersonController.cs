using indexer_Reflection.Services.Interfaces;
using indexer_Reflection.Services;

namespace indexer_Reflection.Controllers
{
    public class PersonController
    {
        public static void GetPersonDatas()
        {
            IPersonService personService = new PersonService();

            var result = personService.GetFullDate(m => m.Salary > 1000);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

        } 
       public static void GetFilteredPersonsPowCount()
        {
            IPersonService personService= new PersonService();
            string word = "C";

            Console.WriteLine(personService.GetFilteredDatasCount(m => m.Name.ToLower().StartsWith(word.ToLower())));
            
        }
    }
}
