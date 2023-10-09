using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.Getting_user_input
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Use write not writeline
            Console.Write("ENTER YOUR NAME");
            string NAME = Console.ReadLine();
            Console.WriteLine("HI" + NAME);
            Console.Write("How old are you?");
            // the values from a user are always string
            string age = Console.ReadLine();
            Console.WriteLine("You are" + age);
            Console.ReadLine();
        }

    }
}
