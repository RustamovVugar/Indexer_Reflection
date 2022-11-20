using indexer_Reflection.Models;
using indexer_Reflection.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer_Reflection.Services
{
    public class PersonService : IPersonService
    {
        public int GetFilteredDatasCount(Predicate<Person> predicate)
        {
            var datas = GetAll();

            var filteredDatas= datas.FindAll(predicate);

            var result=Math.Pow(filteredDatas.Count, 2);

            return (int)result;
        }

        public List<string> GetFullDate(Predicate<Person> predicate)
        {
            var people = GetAll();
            
            var result= people.FindAll(predicate);   
            
            return GetPersonDatails(result);   
        }

        private List<Person> GetAll()
        {
            List<Person> people = new List<Person>();
            Person person1 = new()
            {
                Name = "Cesul",
                Surname = "Hesenov",
                Adress = "Xalqlar",
                Salary = 400,
            };
            Person person2 = new()
            {
                Name = "Novreste",
                Surname = "Aslanzade",
                Adress = "Azadliq",
                Salary = 700,
            };
            Person person3 = new()
            {
                Name = "coshqar",
                Surname = "Nerimanli",
                Adress = "Ehmedli",
                Salary = 8000,
            };
            Person person4 = new()
            {
                Name = "Lale",
                Surname = "Quliyeva",
                Adress = "Nesimi",
                Salary = 2000,
            };
            Person person5 = new()
            {
                Name = "Gultac",
                Surname = "Ceferova",
                Adress = "Tiblisi",
                Salary = 10000,
            };
            people.Add(person1);
            people.Add(person2);
            people.Add(person3);
            people.Add(person4);
            people.Add(person5);

            return people;
        }

        private List<string> GetPersonDatails(List<Person>people)
        {
            List<string> fullDatas = new();

            foreach (var item in people)
            {
                string data = $"{item.Name} - {item.Surname} - {item.Adress}";
                fullDatas.Add(data);
            }
            return fullDatas;
        }
    }
}
