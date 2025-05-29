using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_bai3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo danh sách student
            List<studentLab4> list = new List<studentLab4>();
            list.Add(new studentLab4("1", "Bao Tram", 13));
            list.Add(new studentLab4("2", "Quoc Trung", 12));
            list.Add(new studentLab4("3", "Huyen Trang", 15));
            list.Add(new studentLab4("4", "Gia Lam", 20));
            list.Add(new studentLab4("5", "Van Anh", 16));

            // a) LINQ Query Syntax
            var queryResult = from s in list
                              where s.age > 12 && s.age < 20
                              select s;

            Console.WriteLine("=== Ket qua voi LINQ Query Syntax ===");
            foreach (var student in queryResult)
            {
                Console.WriteLine("ID: " + student.id + " | Name: " + student.name + " | Age: " + student.age);
            }

            // b) LINQ Method Syntax
            var methodResult = list.Where(s => s.age > 12 && s.age < 20);

            Console.WriteLine("\n=== Ket qua voi LINQ Method Syntax ===");
            foreach (var student in methodResult)
            {
                Console.WriteLine("ID: " + student.id + " | Name: " + student.name + " | Age: " + student.age);
            }
        }
    }
}
