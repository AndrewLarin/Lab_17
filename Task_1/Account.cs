using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1
{
    internal class Account <T>
    {
        private T num;
        public T Num { get { return num; } set { num = value; } }

        private double balance;
        public double Balance { get { return balance; } set { balance = value; } }

        private string name;
        public string Name { get { return name; } set { name = value; } }

        public string GetInfo()
        {
            return $"{Num} {Name} {Balance}";
        }


    }
}
