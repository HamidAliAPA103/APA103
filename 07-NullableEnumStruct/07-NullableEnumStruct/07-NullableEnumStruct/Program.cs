using _07_NullableEnumStruct.Enums;

namespace _07_NullableEnumStruct
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DrinkOrder person1 = new(101, "Ali", DrinkType.Coffee, DrinkSize.Medium);
            DrinkOrder  person2 = new(102, "Leyla", DrinkType.Tea, DrinkSize.Large);
            DrinkOrder person3 = new(103,"Vuqar",DrinkType.Juice ,DrinkSize.Small );

            Console.WriteLine("          Sifaris 1       ");
            Console.WriteLine($"No:{person1.OrderNumber}");
            Console.WriteLine($"Musderi :{person1.CustomerName}");
            Console.WriteLine($"Icgi :{person1.Drink}");
            Console.WriteLine($"Olcu :{person1.Size}");
            person1.DisplayOrder();
            person1.UpdateStatus( OrderStatus.Preparing   ); 
            person1.UpdateStatus( OrderStatus.Ready  ); 
            person1.UpdateStatus( OrderStatus.Delivered  ); 
            Console.WriteLine(" ");



            Console.WriteLine("          Sifaris 2       ");
            Console.WriteLine($"No:{person2.OrderNumber}");
            Console.WriteLine($"Musderi :{person2.CustomerName}");
            Console.WriteLine($"Icgi :{person2.Drink}");
            Console.WriteLine($"Olcu :{person2.Size}");
            person2.DisplayOrder();
            person2.UpdateStatus(OrderStatus.Ready);
            Console.WriteLine( " ");

            Console.WriteLine("          Sifaris 3       ");
            Console.WriteLine($"No:{person3.OrderNumber}");
            Console.WriteLine($"Musderi :{person3.CustomerName}");
            Console.WriteLine($"Icgi :{person3.Drink}");
            Console.WriteLine($"Olcu :{person3.Size}");
            person3.DisplayOrder();

            Console.WriteLine( " ");

            Console.WriteLine("DrinkType deyerleri");

            Array drinks = Enum.GetValues(typeof(DrinkType));
            for (int i = 0; i < drinks.Length; i++)
            {
                Console.WriteLine(drinks.GetValue(i));
            }

            Console.WriteLine(" ");

            Console.WriteLine("DrinkSize deyerleri");

            Array size = Enum.GetValues(typeof(DrinkSize));
            for (int i = 0; i < size.Length; i++)
            {
                Console.WriteLine(size.GetValue(i));
            }

            Console.WriteLine(" ");

            Console.WriteLine("OrderStatus deyerleri");

            Array status = Enum.GetValues(typeof(OrderStatus));
            for (int i = 0; i < status .Length; i++)
            {
                Console.WriteLine(status .GetValue(i));
            }
            Console.WriteLine(" ");

            Console.WriteLine(DrinkType.Coffee.ToString());
            Console.WriteLine(DrinkSize.Large.ToString());
            Console.WriteLine (" ");
            Console.WriteLine(Enum.Parse(typeof(DrinkType), "Tea"));
            Console.WriteLine(Enum.Parse(typeof(DrinkSize), "Medium"));

            Console.WriteLine (" ");

            Console.WriteLine ($"Umumi sifaris:3");
            Console.WriteLine($"Birinci sifarisin qiymeti:{person1.CalculatePrice()}");
            Console.WriteLine($"Ikinci sifarisin qiymeti:{person2.CalculatePrice()}");
            Console.WriteLine($"Ucuncu sifarisin qiymeti:{person3.CalculatePrice()}");
            Console.WriteLine($"Umumi mebleq :{person3.CalculatePrice()+ person2.CalculatePrice()+person1.CalculatePrice() }");
        }
        

    }
}
