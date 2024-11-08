using System.ComponentModel.DataAnnotations;
using System.Data.Common;
using System.Linq.Expressions;

namespace practice_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Creating cat object");
            Cat myCat = new Cat();
            Console.Write("Enter name: ");
            myCat.Name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter breed: ");
            myCat.Breed = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Enter age: ");
            myCat.Age = byte.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("Enter sex: ");
            string sex = Console.ReadLine();
            if (sex.Equals("Female"))
            {
                myCat.Sex = false;
            }else if (sex.Equals("Male"))
            {
                myCat.Sex = true;
            }
            myCat.Eat(38);
            myCat.Meow(3);
        }
    }
}
