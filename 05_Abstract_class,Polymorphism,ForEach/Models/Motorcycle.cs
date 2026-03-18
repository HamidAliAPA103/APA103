using System;
using _05_Abstract_class_Polymorphism_ForEach.Models;

namespace _05_Abstract_class_Polymorphism_ForEach
{
    public class Motorcycle : Vehicle
    {
        public int EngineCapacity;
        public bool HasSidecar;
        public int MaxSpeed;
        public string Type;

        public Motorcycle(string brand, string model, int year, string plateNumber, int engineCapacity, bool hasSidecar, int maxSpeed, string type)
            : base(brand, model, year, plateNumber)
        {
            this.EngineCapacity = engineCapacity;
            this.HasSidecar = hasSidecar;
            this.MaxSpeed = maxSpeed;
            this.Type = type;
        }

        public void ShowMotorcycleInfo()
        {
            Console.WriteLine("Motosiklet məlumatları:");
            ShowBasicInfo();
            Console.WriteLine("Mühərrik həcmi: " + EngineCapacity + " cc");
            Console.WriteLine("Yan oturacaq var: " + HasSidecar);
            Console.WriteLine("Maksimum sürət: " + MaxSpeed + " km/saat");
            Console.WriteLine("Növ: " + Type);
        }

        public double CalculateFuelCost(double distance)
        {
            return (distance / 100) * 4 * 1.50;
        }
    }
}
