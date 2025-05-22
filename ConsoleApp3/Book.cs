using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    struct Book
    {
        public string Title;
        public string AuthorFullName;
        public int Year;
        public int Pages;
        public Book(string title, string authorFullName, int year, int pages)
        {
            Title = title;
            AuthorFullName = authorFullName;
            Year = year;
            Pages = pages;
        }
        public void DisplayInfo()
        {
            Console.WriteLine("Информация о книге:");
            Console.WriteLine($"Название: {Title}");
            Console.WriteLine($"Автор: {AuthorFullName}");
            Console.WriteLine($"Год издания: {Year}");
            Console.WriteLine($"Количество страниц: {Pages}");
            Console.WriteLine();
        }
    }
}
