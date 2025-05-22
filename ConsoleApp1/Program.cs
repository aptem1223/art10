using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void ClassTaker(MyClass myClass)
        {
            myClass.change = "изменено";
        }
        static void StruktTaker(MyStruct myStruct)
        {
            myStruct.change = "изменено";
        }
        static void Main(string[] args)
        {
            
            MyClass classInstance = new MyClass();
            MyStruct structInstance = new MyStruct();
            classInstance.change = "не изменено";
            structInstance.change = "не изменено";
            ClassTaker(classInstance);
            StruktTaker(structInstance);
            Console.WriteLine("Значение поля change в классе: " + classInstance.change);
            Console.WriteLine("Значение поля change в структуре: " + structInstance.change);
            Console.ReadLine();
        }
    }

}
