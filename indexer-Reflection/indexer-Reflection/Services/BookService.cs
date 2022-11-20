using indexer_Reflection.Models;
using indexer_Reflection.Services.Interfaces;

namespace indexer_Reflection.Services
{
    public class BookService : IBookService
    {
        public int GetCount(Predicate<Book> predicate)
        {
            var books = GetAll();
            return books.FindAll(predicate).Count();
        }

        private List<Book> GetAll()
        {
            List<Book> books = new();

            Book book1 = new()
            {
                Name = "Isgendername",
                Author = "Nizami"
            };
            Book book2 = new()
            {
                Name = "Shikayetname",
                Author = "Fizuli"
            };
            Book book3 = new()
            {
                Name = "Xosrov ve Shirin",
                Author = "Nizami"
            };
            Book book4 = new()
            {
                Name = "Ferhad ve Shirin",
                Author = "Fizuli"
            };
            Book book5 = new()
            {
                Name = "Sevil",
                Author = "Huseyn Cavid"
            };

            books.Add(book1);
            books.Add(book2);
            books.Add(book3);
            books.Add(book4);
            books.Add(book5);

            return books;
        }
    }
}
