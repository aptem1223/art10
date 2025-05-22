using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество книг: ");
            int n = int.Parse(Console.ReadLine());

            Book[] books = new Book[n];
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\nВведите данные для книги #{i + 1}:");

                Console.Write("Название: ");
                string title = Console.ReadLine();

                Console.Write("Ф.И.О. автора: ");
                string author = Console.ReadLine();

                Console.Write("Год издания: ");
                int year = int.Parse(Console.ReadLine());

                Console.Write("Количество страниц: ");
                int pages = int.Parse(Console.ReadLine());

                books[i] = new Book(title, author, year, pages);
            }
            Console.WriteLine("\nСписок всех книг:");
            foreach (Book book in books)
            {
                book.DisplayInfo();
            }

            Console.ReadLine(); 
        }
    }
}
