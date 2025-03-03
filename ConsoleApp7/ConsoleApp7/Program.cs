using System;
using System.Text;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.UTF8;
            Console.OutputEncoding = Encoding.UTF8;

            Console.Write("Nhập tên khách hàng: ");
            string name = Console.ReadLine();

            Console.Write("Loại khách hàng (household/admin/production/business): ");
            string type = Console.ReadLine().ToLower();

            Console.Write("Chỉ số nước tháng trước: ");
            double last_month = double.Parse(Console.ReadLine());

            Console.Write("Chỉ số nước tháng này: ");
            double this_month = double.Parse(Console.ReadLine());

            double consum_water = this_month - last_month;
            double bill = 0;

            if (type == "household")
            {
                Console.Write("Nhập số người sử dụng: ");
                double number_person = double.Parse(Console.ReadLine());
                double consum_water_person = consum_water / number_person;

                if (consum_water_person < 10)
                    bill = consum_water_person * (5973 + 597.3);
                else if (consum_water_person < 20)
                    bill = consum_water_person * (7052 + 705.2);
                else if (consum_water_person < 30)
                    bill = consum_water_person * (8699 + 869.9);
                else
                    bill = consum_water_person * (15929 + 1592.9);
            }
            else if (type == "admin")
            {
                bill = consum_water * (9955 + 995.5);
            }
            else if (type == "production")
            {
                bill = consum_water * (11615 + 1161.5);
            }
            else if (type == "business")
            {
                bill = consum_water * (22068 + 2206.8);
            }
            else
            {
                Console.WriteLine("Loại khách hàng không hợp lệ!");
                return;
            }

            Console.WriteLine("\n--------------------------------------------");
            Console.WriteLine($"Tên khách hàng: {name}");
            Console.WriteLine($"Loại khách hàng: {type}");
            Console.WriteLine($"Chỉ số nước tháng trước: {last_month}");
            Console.WriteLine($"Chỉ số nước tháng này: {this_month}");
            Console.WriteLine($"Lượng nước tiêu thụ: {consum_water} m³");
            Console.WriteLine($"Tổng tiền hóa đơn (đã VAT 10%): {bill * 1.1:N0} VND");
            Console.WriteLine("--------------------------------------------");

            Console.ReadLine();
        }
    }
}
