using _06_InterfaceAbstraction.Interface;

namespace _06_InterfaceAbstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Calculation calculation = new Calculation();
            Console.WriteLine("1ci ededi daxil edin : ");
            double num1=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2ci ededi daxil edin");
            double num2=Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("emeliyati secin + - * /  ");
            char operations=Convert.ToChar(Console.ReadLine());


            double result =calculation.Calculate( num1,num2 ,operations );
            Console.WriteLine($"netice : {result}");




        }
    }
}
