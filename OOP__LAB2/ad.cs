using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP__LAB2
{
    public delegate int delegates();


    public class AD
    {
        public static delegates[] array = new delegates[]
        {
            new delegates(Ran.random),
            new delegates(Ran.random),
            new delegates(Ran.random)
        };

    }

    public static class Ran
    {
        public static int random()
        {
            Random r = new Random();
            return r.Next(100);
        }
    }
}
