using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Bai 1:");
            List<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8 };
            var newList = list.FindAll(item => item % 2 == 0);

            foreach (var item in newList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("Bai 2:");

        }

    }
}
