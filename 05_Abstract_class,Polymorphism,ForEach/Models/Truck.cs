using System;
namespace _05_Abstract_class_Polymorphism_ForEach.Models
{
    public class Truck : Vehicle
    {
        public double CargoCapacity;
        public int AxleCount;
        public double CurrentLoad;
        public int MaxSpeed;

        public Truck(string brand, string model, int year, string plateNumber, double cargoCapacity, int axleCount, double currentLoad, int maxSpeed)
            : base(brand, model, year, plateNumber)
        {
            this.CargoCapacity = cargoCapacity;
            this.AxleCount = axleCount;
            this.CurrentLoad = currentLoad;
            this.MaxSpeed = maxSpeed;
        }

        public void ShowTruckInfo()
        {
            Console.WriteLine("Yük maşını məlumatları:");
            ShowBasicInfo();
            Console.WriteLine("Yük tutumu: " + CargoCapacity + " ton");
            Console.WriteLine("Ox sayı: " + AxleCount);
            Console.WriteLine("Cari yük: " + CurrentLoad + " ton");
            Console.WriteLine("Maksimum sürət: " + MaxSpeed + " km/saat");
        }

        public void LoadCargo(double weight)
        {
            if (CurrentLoad + weight <= CargoCapacity)
            {
                CurrentLoad = CurrentLoad + weight;
                Console.WriteLine(weight + " ton yük əlavə olundu.");
            }
            else
            {
                Console.WriteLine("Yük əlavə edilə bilmədi. Tutum aşılır.");
            }
        }

        public double CalculateFuelCost(double distance)
        {
            return (distance / 100) * (25 + CurrentLoad * 2) * 1.80;
        }
    }
}

