using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQwithoutCast
{
    public class Bookrepository
    { 
        List<Book> Books = new List<Book>();
        public Bookrepository()
        {
            Books.Add(new Book() { Price = 19, Title = "Hobbit" });
            Books.Add(new Book() { Price = 10, Title = "Hob" });
            Books.Add(new Book() { Price = 15, Title = "Hobb" });

        }
        
         public List<Book> GetBooks()
        {
            return Books;
        }
    }

}
    


