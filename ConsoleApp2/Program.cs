using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Notebook notebook = new Notebook("XPS 13", "Dell", 129999.99m);
            notebook.DisplayInfo();
            Console.ReadLine(); 
        }
    }
}
