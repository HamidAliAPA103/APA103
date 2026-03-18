using System;
using _05_Abstract_class_Polymorphism_ForEach.Models;

namespace _05_Abstract_class_Polymorphism_ForEach
{
    public class Car : Vehicle
    {
        public int DoorsCount;
        public int TrunkCapacity;
        public bool IsAutomatic;
        public int MaxSpeed;

        public Car(string brand, string model, int year, string plateNumber, int doorsCount, int trunkCapacity, bool isAutomatic, int maxSpeed)
            : base(brand, model, year, plateNumber)
        {
            this.DoorsCount = doorsCount;
            this.TrunkCapacity = trunkCapacity;
            this.IsAutomatic = isAutomatic;
            this.MaxSpeed = maxSpeed;
        }

        public void ShowCarInfo()
        {
            Console.WriteLine("Avtomobil məlumatları:");
            ShowBasicInfo();
            Console.WriteLine("Qapı sayı: " + DoorsCount);
            Console.WriteLine("Baqaj tutumu: " + TrunkCapacity + " L");
            Console.WriteLine("Avtomatikdir: " + IsAutomatic);
            Console.WriteLine("Maksimum sürət: " + MaxSpeed + " km/saat");
        }

        public double CalculateFuelCost(double distance)
        {
            return (distance / 100) * 8 * 1.50;
        }
    }
}

