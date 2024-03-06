using System.Linq.Expressions;

namespace FactoryPattern
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("\nPlease enter Number of Tires to figure out what kind of Vehicle you have\n\n");

            var input = Console.ReadLine();

            if (int.TryParse(input, out int numberOfTires))

            {
                var vehicle = VehicleFactory.GetVehicle(numberOfTires);
                vehicle.Drive();
            }

            else
            {

                Console.WriteLine($"Invalid input. Please enter a valid number.");
                Program.Main(args);
            }



        }
    }
}
