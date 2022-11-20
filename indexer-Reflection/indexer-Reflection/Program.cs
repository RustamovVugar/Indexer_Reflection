
using indexer_Reflection.Controllers;
using indexer_Reflection.Models;
using indexer_Reflection.Services;
using indexer_Reflection.Services.Interfaces;
using System.Net;


//PersonController.GetPersonDatas();
//BookController.GetCount();
//EmployeeController.GetEmployeeSalaryAverage();

//Console.WriteLine(GetBook());

//static Book GetBook()
//{
//    Book book = new Book { Name = "Xosrov", Author = "Nizami" };
//    return book;
//}

//PersonController.GetFilteredPersonsPowCount();

//Person person1 = new();
//person1.Age = 28;

//Person person2 = new();
//person2.Age = 28;

//Console.WriteLine(person1>person2);

//List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };
//Console.WriteLine(nums[1]);

Book book = new Book { Name = "Xosrov", Author = "Nizami" };

Library library = new();

library[0] = book;



Console.WriteLine(library[0].Name);


