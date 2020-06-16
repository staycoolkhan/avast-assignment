using System;

namespace avast_primnuber_assignment
{
    public class Program
    {
        static void Main(string[] args)
        {
            var end = Convert.ToInt32(Console.ReadLine());

            var primerNumber = new PrimNumbers();

            var isExist = primerNumber.DisplayPrimerNumber(end);

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

        }
    }
}
