using System;


namespace YardGreening
    {
        class Program
        {
            static void Main(string[] args)
            {// Божидара разполага с няколко къщи на Черноморието и желае да озелени дворовете на някои от тях, като
             // по този начин създаде уютна обстановка и комфорт на гостите си, като за целта е наела фирма.
             //Напишете програма, която изчислява необходимите средства, които Божидара ще трябва да заплати на
             //фирмата изпълнител на проекта.Цената на един кв. м.е 7.61лв със ДДС.Тъй като нейният двор е доста
             //голям, фирмата изпълнител предлага 18 % отстъпка от крайната цена.


                //  И двете суми трябва да бъдат форматирани до втората цифра след десетичния знак./
                double greeningSquareMeters = double.Parse(Console.ReadLine());
                double price = greeningSquareMeters * 7.61;
                double finalPrice = price * (1 - 0.18);
                double discount = price * 0.18;
                Console.WriteLine($"The final price is: {finalPrice:F2} lv. ");
                Console.WriteLine($"The discount is: {discount:F2} lv.");
            }
        }
    }

}
    }
}
