using System;

namespace Session03Excercise01
{
    class Program
    {
        static void Main(string[] args)
        {
            var integersValues = new[] {1, 2, 3};

            for ( var i = 0; i < integersValues.Length; i++)
            {

                var value = integersValues[i];
                
                Console.WriteLine($"index {i} i arrayen {nameof(integersValues)} har värdet; {integersValues[i]}");
            }

            var doWhileIndex = 0;

            do
            {
                var value = integersValues[doWhileIndex];
                Console.WriteLine($"Do while index {doWhileIndex} i arrayen {integersValues} har värdet");

                doWhileIndex++;
            }
            while (doWhileIndex);


                
        }
    }
}
