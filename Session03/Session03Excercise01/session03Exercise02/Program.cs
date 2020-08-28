using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace session03Exercise02
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ange ett antal siffror, separerat med kommatecken.");
            var input = Console.ReadLine();
            var inputArray = input.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries);
            double[] numberArray = new double[inputArray.Length];


            for (int i = 0; i < inputArray.Length; i++)
            {
                try
                {
                    numberArray[i] = Convert.ToDouble(inputArray[i]);

                    //        //samma som ett stopp = Debug.Assert(i < inputArray.Length - 1);
                }
                catch (Exception)
                {
                    numberArray[i] = 0;
                }
                //         //Även om logiken har gått bort ifrån try-sattsen så kommer finally ALLTID att köras. så fort de
                //        // ! innan parsed == False/not medan bara Parsed == True. Detta gäller vid if
                finally
                {

                }

            }

            foreach (var number in numberArray)
            {
                Console.WriteLine("Varde: " + number.ToString());
            }

        }
    }
}
