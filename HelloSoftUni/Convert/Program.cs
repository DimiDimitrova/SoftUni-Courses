using System;

namespace Convert
{
    class Program
    {
        static void Main()
        {
            var leva = int.Parse(Console.ReadLine());
            var euro = leva / 1.9543;
            Console.WriteLine(euro);

            var yena = int.Parse(Console.ReadLine());
            var dolar = yena / 2.321;
            Console.WriteLine(dolar);
            
        }
    }
}
