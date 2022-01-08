using System;

namespace CleverLili
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            double priceWashM = double.Parse(Console.ReadLine());
            int priceToy = int.Parse(Console.ReadLine());
            int numberOfToys = 0;
            int savedMoney = 0;
            int moneyForBirth = 10;
            for (int i = 1; i <= age; i++)
            {
                if (i % 2 == 0)
                {
                    savedMoney += (moneyForBirth - 1);
                    moneyForBirth += 10;
                }
                else
                {
                    numberOfToys++;
                }
            }
            savedMoney += priceToy * numberOfToys;
            //С парите искала да си купи пералня за X лева. 
            //Напишете програма, която да пресмята, колко пари е събрала и дали ѝ стигат да си купи пералня.
            if (savedMoney >= priceWashM)
            {
                Console.WriteLine($"Yes! {(savedMoney-priceWashM):F2}");
            }
            else
            {
                Console.WriteLine($"No! {(priceWashM-savedMoney):F2}");
            }



        }
    }
}
