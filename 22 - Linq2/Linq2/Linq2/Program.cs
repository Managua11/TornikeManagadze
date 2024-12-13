using System.Globalization;

namespace Linq2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenerateData();
            var customers = File.ReadAllLines("customers.txt")
                .Select(line => line.Split('|'))
                .Select(parts => new Customer { CustomerId = int.Parse(parts[0]), CustomerName = parts[1] })
                .ToList();

            var orders = File.ReadAllLines("orders.txt")
                .Select(line => line.Split('|'))
                .Select(parts => new Order
                {
                    OrderId = int.Parse(parts[0]),
                    Date = DateTime.ParseExact(parts[1], "yyyyMMdd", CultureInfo.InvariantCulture),
                    Product = parts[2],
                    Price = decimal.Parse(parts[3], CultureInfo.InvariantCulture),
                    CustomerId = int.Parse(parts[4])
                })
                .ToList();

            var orderCounts = orders
                .GroupBy(o => o.CustomerId)
                .Select(g => new { CustomerId = g.Key, OrderCount = g.Count() })
                .ToList();

            var totalAmounts = orders
                .GroupBy(o => o.CustomerId)
                .Select(g => new { CustomerId = g.Key, SumAmount = g.Sum(o => o.Price) })
                .ToList();

            var minAmounts = orders
                .GroupBy(o => o.CustomerId)
                .Select(g => new { CustomerId = g.Key, MinAmount = g.Min(o => o.Price) })
                .ToList();

            var multipleOrders = orders
                .GroupBy(o => o.CustomerId)
                .Where(g => g.Count() > 1)
                .Select(g => new { CustomerId = g.Key, OrderCount = g.Count() })
                .ToList();

            var avgAboveTen = orders
                .GroupBy(o => o.CustomerId)
                .Select(g => new { CustomerId = g.Key, AvgAmount = g.Average(o => o.Price) })
                .Where(x => x.AvgAmount > 10)
                .ToList();

            Console.WriteLine("Order Counts:");
            foreach (var item in orderCounts)
            {
                Console.WriteLine($"CustomerId: {item.CustomerId}, OrderCount: {item.OrderCount}");
            }

            Console.WriteLine("\nTotal Amounts:");
            foreach (var item in totalAmounts)
            {
                Console.WriteLine($"CustomerId: {item.CustomerId}, SumAmount: {item.SumAmount:C}");
            }

            Console.WriteLine("\nMinimum Order Amounts:");
            foreach (var item in minAmounts)
            {
                Console.WriteLine($"CustomerId: {item.CustomerId}, MinAmount: {item.MinAmount:C}");
            }

            Console.WriteLine("\nCustomers with Multiple Orders:");
            foreach (var item in multipleOrders)
            {
                Console.WriteLine($"CustomerId: {item.CustomerId}, OrderCount: {item.OrderCount}");
            }

            Console.WriteLine("\nCustomers with Average Order Amount Above 10:");
            foreach (var item in avgAboveTen)
            {
                Console.WriteLine($"CustomerId: {item.CustomerId}, AvgAmount: {item.AvgAmount:C}");
            }
        }

        static void GenerateData()
        {
            var customerData = new List<string>
        {
            "1|Lasha",
            "2|Beka",
            "3|Dimitri",
            "4|Nino",
            "5|Mariam"
        };

            File.WriteAllLines("customers.txt", customerData);

            var orderData = new List<string>
        {
            "1|20201212|Coca-cola|3.0|1",
            "2|20201111|Pepsi|3.0|2",
            "3|20200909|Staropramen|4.0|2",
            "4|20200808|Argo|4.0|3",
            "5|20201201|Fanta|2.5|1",
            "6|20210101|Sprite|2.0|4",
            "7|20201115|Beer|5.0|5",
            "8|20200220|Wine|20.0|5",
            "9|20200303|Vodka|15.0|5",
            "10|20201010|Chacha|10.0|4",
            "11|20200707|Whiskey|50.0|3",
            "12|20200909|Bread|1.5|2",
            "13|20200808|Milk|1.2|1",
            "14|20201111|Eggs|3.6|2",
            "15|20200707|Butter|2.8|3",
            "16|20201010|Cheese|4.5|4",
            "17|20201212|Apple|0.5|1",
            "18|20200101|Orange|0.8|2",
            "19|20201115|Pear|0.9|3",
            "20|20201001|Plum|1.1|4"
        };

            File.WriteAllLines("orders.txt", orderData);
        }
    }
}
