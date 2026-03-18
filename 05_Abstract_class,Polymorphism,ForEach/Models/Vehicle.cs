using System;

namespace _05_Abstract_class_Polymorphism_ForEach
{
    public class Vehicle
    {
        public string Brand;
        public string Model;
        public int Year;
        public string PlateNumber;
        public double FuelLevel;

        public Vehicle(string brand, string model, int year, string plateNumber)
        {
            this.Brand = brand;
            this.Model = model;
            this.Year = year;
            this.PlateNumber = plateNumber;
            this.FuelLevel = 100;
        }

        public string GetVehicleInfo()
        {
            return "Marka: " + Brand + ", Model: " + Model + ", İl: " + Year + ", Qeydiyyat nömrəsi: " + PlateNumber + ", Yanacaq səviyyəsi: " + FuelLevel;
        }

        public void ShowBasicInfo()
        {
            Console.WriteLine("Marka: " + Brand);
            Console.WriteLine("Model: " + Model);
            Console.WriteLine("İl: " + Year);
            Console.WriteLine("Qeydiyyat nömrəsi: " + PlateNumber);
            Console.WriteLine("Yanacaq səviyyəsi: " + FuelLevel);
        }
    }
}


