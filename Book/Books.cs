using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Books
{
    class Book : IComparable
    {
        private string author;
        private string title;
        private int pages;
        private int year;


        public void SetBook(string author, string title, int pages, int year)
        {
            this.author = author;
            this.title = title;
            this.pages = pages;
            this.year = year;
        }
        int IComparable.CompareTo(object obj)
        {
            Book it = (Book)obj;
            if (this.year == it.year) return 0;
            else if (this.year > it.year) return 1;
            else return -1;
        }
        public void Show()
        {
            Console.WriteLine("\n Книга: \n Автор: {0}\n Название: {1}\n Год издания: {2}\n {3} стр.\n", 
                author, title, year, pages);
        }

    }
}
