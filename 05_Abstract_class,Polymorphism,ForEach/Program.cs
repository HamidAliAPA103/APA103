using System;
using System.Collections.Generic;
using _05_Abstract_class_Polymorphism_ForEach.Models;

namespace _05_Abstract_class_Polymorphism_ForEach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();
            cars.Add(new Car("Mercedes-Benz", "E 200", 2023, "90-AB-245", 4, 500, true, 220));
            cars.Add(new Car("BMW", "320i", 2022, "10-KD-578", 4, 480, true, 235));
            cars.Add(new Car("Toyota", "Camry", 2021, "77-VX-314", 4, 524, true, 210));

            List<Motorcycle> motorcycles = new List<Motorcycle>();
            motorcycles.Add(new Motorcycle("Yamaha", "YZF-R1", 2023, "99-MT-101", 998, false, 299, "Sport"));
            motorcycles.Add(new Motorcycle("Harley-Davidson", "Road King", 2022, "10-HD-222", 1868, true, 180, "Cruiser"));

            List<Truck> trucks = new List<Truck>();
            trucks.Add(new Truck("MAN", "TGX 18.470", 2020, "90-TR-456", 18, 3, 12, 120));
            trucks.Add(new Truck("Volvo", "FH16 750", 2021, "99-VL-808", 25, 4, 18, 110));

            Console.WriteLine("----- AVTOMOBİLLƏR -----");
            foreach (Car car in cars)
            {
                car.ShowCarInfo();
                Console.WriteLine("500 km üçün yanacaq xərci: " + car.CalculateFuelCost(500) + " AZN");
                Console.WriteLine();
            }

            Console.WriteLine("----- MOTOSİKLETLƏR -----");
            foreach (Motorcycle motorcycle in motorcycles)
            {
                motorcycle.ShowMotorcycleInfo();
                Console.WriteLine("300 km üçün yanacaq xərci: " + motorcycle.CalculateFuelCost(300) + " AZN");
                Console.WriteLine();
            }

            Console.WriteLine("----- YÜK MAŞINLARI -----");
            foreach (Truck truck in trucks)
            {
                truck.ShowTruckInfo();
                Console.WriteLine("800 km üçün yanacaq xərci: " + truck.CalculateFuelCost(800) + " AZN");
                Console.WriteLine();
            }

            Console.WriteLine("----- BİRİNCİ YÜK MAŞININA YÜK ƏLAVƏ ET -----");
            trucks[0].LoadCargo(5);
            Console.WriteLine("800 km üçün yeni yanacaq xərci: " + trucks[0].CalculateFuelCost(800) + " AZN");
            Console.WriteLine();

            Console.WriteLine("----- STATİSTİKA -----");

            int totalVehicles = cars.Count + motorcycles.Count + trucks.Count;
            Console.WriteLine("Ümumi nəqliyyat sayı: " + totalVehicles);

            int totalSpeed = 0;
            int count = 0;

            foreach (Car car in cars)
            {
                totalSpeed = totalSpeed + car.MaxSpeed;
                count++;
            }

            foreach (Motorcycle motorcycle in motorcycles)
            {
                totalSpeed = totalSpeed + motorcycle.MaxSpeed;
                count++;
            }

            foreach (Truck truck in trucks)
            {
                totalSpeed = totalSpeed + truck.MaxSpeed;
                count++;
            }

            double averageMaxSpeed = (double)totalSpeed / count;
            Console.WriteLine("Orta maksimum sürət: " + averageMaxSpeed);

            string mostExpensiveVehicle = "";
            double maxFuelCost = 0;

            foreach (Car car in cars)
            {
                double fuelCost = car.CalculateFuelCost(500);
                if (fuelCost > maxFuelCost)
                {
                    maxFuelCost = fuelCost;
                    mostExpensiveVehicle = car.Brand + " " + car.Model;
                }
            }

            foreach (Motorcycle motorcycle in motorcycles)
            {
                double fuelCost = motorcycle.CalculateFuelCost(300);
                if (fuelCost > maxFuelCost)
                {
                    maxFuelCost = fuelCost;
                    mostExpensiveVehicle = motorcycle.Brand + " " + motorcycle.Model;
                }
            }

            foreach (Truck truck in trucks)
            {
                double fuelCost = truck.CalculateFuelCost(800);
                if (fuelCost > maxFuelCost)
                {
                    maxFuelCost = fuelCost;
                    mostExpensiveVehicle = truck.Brand + " " + truck.Model;
                }
            }

            Console.WriteLine("Ən bahalı yanacaq xərci olan nəqliyyat: " + mostExpensiveVehicle);
            Console.WriteLine("Ən yüksək yanacaq xərci: " + maxFuelCost + " AZN");
        }
    }
}