using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    class Program
    {

        class Book
        {
            string author;
            string nameBook;
            int numPage;
            bool colEdition;

            public Book(string author, string nameBook, int numPage, bool colEdition)
            {
                this.author = author;
                this.nameBook = nameBook;
                this.numPage = numPage;
                this.colEdition = true;
            }
            public Book(string author, string nameBook, int numPage)
            {
                this.author = author;
                this.nameBook = nameBook;
                this.numPage = numPage;
            }
            public void Print()
            {
                Console.WriteLine("Автор -  " + author);
                Console.WriteLine("Название книги -  " + nameBook);
                Console.WriteLine("Количевство страниц -  " + numPage);
                Console.WriteLine("Коллекционное ли издание? - " + colEdition);
            }


            static void Main(string[] args)
            {
                Book book1 = new Book("Фредрик Бакман", "Медвежий угол",420);
                Book book2 = new Book("Джон Кехо", "Подсознание может всё!", 140);
                Book book3 = new Book("Михаил Булгаков", "Мастер и Маргарита",310, true);
                book1.Print();
                Console.WriteLine("");
                book2.Print();
                Console.WriteLine("");
                book3.Print();
                Console.ReadLine();
            }
        }
    }
}
