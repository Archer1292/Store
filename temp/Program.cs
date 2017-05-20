using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            Child ch = new Child();
            Console.WriteLine("id - " + ch.id);
            Child ch1 = new Child();
            Console.WriteLine("id - " + ch1.id);
            Console.ReadKey();
        }
    }
}
