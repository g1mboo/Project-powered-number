using System;
using System.Threading.Tasks;

namespace Project_powered_number
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Power numbers: \r\n");
            while (true)
            {
                double x;
                double y;

                Console.Write("Number: ");
                double.TryParse(Console.ReadLine(), out x);
                Console.Write("Power: ");
                double.TryParse(Console.ReadLine(), out y);

                //Result
                Console.WriteLine("Result: " + 
                    await Task.Run(() => Math.Pow(x, y)));
                Console.WriteLine("----------------");
            }
        }        
    }
}
