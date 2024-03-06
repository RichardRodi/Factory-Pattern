namespace FactoryPattern
{
    public class Car : IVehicle
    {
        public void Drive()
        {
            Console.WriteLine("\nYour Car is very Nice!");
        }
    }
}
