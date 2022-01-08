using System;

namespace PetShop
{
    class Program
    {
        static void Main(string[] args)
        {   // Напишете програма, която пресмята нужните разходи за закупуването на храна за кучета.
            //Хранata se пазарува основно за кучета, от зоомагазин,
            //но понякога стопанинът им купува и за животните на съседа му.
            //Една опаковка храна за кучета е на цена 2.50лв., 
            //а всяка останала, която не е за тях струва 4лв.
            int numberOfDogs = int.Parse(Console.ReadLine());
            int numberOfOtherAnimals = int.Parse(Console.ReadLine());

            double foodForDog = 2.50 * numberOfDogs;
            double foodForOtherAnimals = 4 * numberOfOtherAnimals;
            double expense = foodForDog + foodForOtherAnimals;
            Console.WriteLine($"{expense:F2} lv.");
        }
    }
}
