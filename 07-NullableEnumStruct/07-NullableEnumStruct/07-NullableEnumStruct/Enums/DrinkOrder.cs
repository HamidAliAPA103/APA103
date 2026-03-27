using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_NullableEnumStruct.Enums
{
    internal class DrinkOrder
    {


        public int OrderNumber { get; set; }
        public string CustomerName { get; set; }
        public DrinkType Drink { get; set; }
        public DrinkSize Size { get; set; }
        public OrderStatus Status { get; set; }
        public decimal Price { get; set; }

        public DrinkOrder(int orderNumber, string customerName, DrinkType drink, DrinkSize size)
        {
            OrderNumber = orderNumber;
            CustomerName = customerName;
            Drink = drink;
            Size = size;
            Status = OrderStatus.New;
            Price = CalculatePrice();
           
        }



        public decimal CalculatePrice()
        {
            switch (Drink)
            {
                case DrinkType.Coffee:
                    switch (Size)
                    {
                        case DrinkSize.Small: return 3;
                        case DrinkSize.Medium: return 4;
                        case DrinkSize.Large: return 5;
                        default: Console.WriteLine("bele olcu yoxdur"); break;

                    }
                    break;
                case DrinkType.Tea:
                    switch (Size)
                    {
                        case DrinkSize.Small: return 2;
                        case DrinkSize.Medium: return 3;
                        case DrinkSize.Large: return 4;
                        default: Console.WriteLine("bele olcu yoxdur"); break;
                    }
                    break;
                case DrinkType.Juice:
                    switch (Size)
                    {
                        case DrinkSize.Small: return 4;
                        case DrinkSize.Medium: return 5;
                        case DrinkSize.Large: return 6;
                        default: Console.WriteLine("bele olcu yoxdur"); break;
                    }
                    break;
                case DrinkType.Water:
                    switch (Size)
                    {
                        case DrinkSize.Small: return 1;
                        case DrinkSize.Medium: return 1.5m;
                        case DrinkSize.Large: return 2;
                        default: Console.WriteLine("bele olcu yoxdur"); break;
                    }
                    break;

            }

            return 0;

        }
        public void UpdateStatus(OrderStatus newStatus)
        {
            Status = newStatus;

            Console.WriteLine($"Sifariş #{OrderNumber} statusu: {newStatus}");

        }

        public void DisplayOrder()
        {

            Console.WriteLine($"Mebleq: {CalculatePrice()} azn");
        }

     
    }
}



