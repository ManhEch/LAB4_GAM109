using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_Bai2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo danh sách userData
            List<userDataLab4> list = new List<userDataLab4>();
            list.Add(new userDataLab4("GTA 5", 10));
            list.Add(new userDataLab4("Genshin Impact", 15));
            list.Add(new userDataLab4("Gunny", 5));
            list.Add(new userDataLab4("Lien minh huyen thoai", 100));

            // a) Xuất thông tin name và level (dùng Select)
            Console.WriteLine("=== Danh sach nguoi dung (name + level) ===");
            var selectedData = list.Select(u => new { u.name, u.level });
            foreach (var item in selectedData)
            {
                Console.WriteLine("Name: " + item.name + " | Level: " + item.level);
            }

            // b) Sắp xếp theo level giảm dần (dùng OrderByDescending)
            Console.WriteLine("\n=== Danh sach sau khi sap xep giam dan theo level ===");
            var sortedList = list.OrderByDescending(u => u.level);
            foreach (var item in sortedList)
            {
                Console.WriteLine("Name: " + item.name + " | Level: " + item.level);
            }
        }
    }
}
