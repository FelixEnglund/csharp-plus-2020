using System;

namespace session03excercise03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ange ett antal siffror, separerat med kommatecken.");
            var input = Console.ReadLine();
            var inputArray = input.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            double?[] numberArray = new double[inputArray.Length];

            
        }
    }
}
