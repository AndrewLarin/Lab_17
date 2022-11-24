using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите числовой номер счета");
            int NumInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите баланс счета");
            double balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО владельца");
            string name = Console.ReadLine();

            Account<int> account1 = new Account<int>() { Num = NumInt, Balance = balance, Name = name};

            Console.WriteLine("Введите буквенный номер счета");
            string NumString = Console.ReadLine();
            Console.WriteLine("Введите баланс счета");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите ФИО владельца");
            name = Console.ReadLine();
            Account<string> account2 = new Account<string>() { Num = NumString, Balance = balance, Name = name };
            Console.WriteLine(account1.GetInfo());
            Console.WriteLine(account2.GetInfo());

            Console.ReadLine();
        }
    }
}
