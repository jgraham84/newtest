using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQwithoutCast
{
    class Program
    {
        static void Main(string[] args)
        {
            var setz = new Bookrepository().GetBooks();
            //Now I need to display all the books that are less than 15 without linq or lambda

            var cheapbookswithoutlink = new List<Book>();

            foreach (var listofbooks in setz)
            {
                if (listofbooks.Price < 15)
                {
                    cheapbookswithoutlink.Add(listofbooks);
                }


                cheapbookswithoutlink.Add(listofbooks);
            }

            var withlamda = setz.FindAll(b => b.Price < 15);
            foreach (var bookswithlamda in withlamda)
            {
                Console.WriteLine(bookswithlamda.Title + ":", bookswithlamda.Price);
            }
            Console.ReadLine();

            {
                var withlinq = setz.Where(b => b.Price < 15).OrderBy(b => b.Title).Select(b => b.Title);
                foreach (var books in withlinq) ;
            }

        }

    } }


