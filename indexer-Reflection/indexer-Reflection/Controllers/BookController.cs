using indexer_Reflection.Services;
using indexer_Reflection.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexer_Reflection.Controllers
{
    public class BookController
    {
        public static void GetCount()
        {
            IBookService bookService = new BookService();
            Console.WriteLine(bookService.GetCount(m => m.Author == "Fizuli"));
        }
    }
}
