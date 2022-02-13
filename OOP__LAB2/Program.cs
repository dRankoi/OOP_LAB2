using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__LAB2
{
    internal class Program
    {
      
            private delegate double del(int a, int b, int c);
            static void Main(string[] args)
            {
                Average();
                Calculator();
                arrayDelegates();
            }
            static void Average()
            {
                del del = delegate (int a, int b, int c)
                {
                    double result = (a + b + c) / 3;
                    return result;
                };
                Console.WriteLine(del(300, 80, 578));

            }
            static void Calculator()
            {
                Calculate calculator = new Calculate();

                Console.WriteLine(calculator.Add(1, 6));
                Console.WriteLine(calculator.Sub(77, 10));
                Console.WriteLine(calculator.Multiply(4, 10));
                Console.WriteLine(calculator.Division(30, 3));
            }
            static void arrayDelegates()
            {
                foreach (var del in AD.array)
                {
                    Console.WriteLine(del());
                    Console.ReadKey();
                }
            }
        }
    }
