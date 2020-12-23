using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    public class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Console.WriteLine("Введите количество книг: ");
            int a = int.Parse(Console.ReadLine());

            Book[] arrBook = new Book[a];
            
            for (int i = 0; i < arrBook.Length; i++)
            {
                Book book = new Book();
                string author = $"Автор первоначальный индекс {i}";
                string title = $"Наименование первоначальный индекс {i}"; 
                int pages = rnd.Next(10, 555); 
                int year = rnd.Next(1960, 2020); 

                arrBook[i] = book;
                book.SetBook(author, title, pages, year);
            }

            Array.Sort(arrBook);

            foreach (Book b in arrBook)
            {
                b.Show();
            }












        }



    }
}
