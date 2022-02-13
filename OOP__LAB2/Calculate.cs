using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__LAB2
{
    public delegate double del(int a, int b);
    public class Calculate
    {
        public del Add = (a, b) => a + b;
        public del Sub = (a, b) => a - b;
        public del Multiply = (a, b) => a * b;
        public del Division = (a, b) =>
        {
            if (b != 0)
            {
                return a / b;
            }
            else
            {
                Console.WriteLine("Error!");
                return 0;
            }
        };
    }
}
