using System;

namespace Conditions
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("C# IF...ELSE IF ...ELSE");

            int number1 = 100;
            int number2 = 234;

            if(number1 > number2)
            {
                Console.WriteLine("Number1 > Number2");
            }
            else if (number2 == number1)
            {
                Console.WriteLine("Number2 > Number1");
            }
            else if (number2 > number1)
            {
                Console.WriteLine("Number2 > Number1");
            }
            
            else
            {
                Console.WriteLine("Number1 = Number2");
            }


            //User AGE
            Console.WriteLine("Yasiniz");
            int age = Convert.ToInt32(Console.ReadLine());

            if(age < 7)
            {
                Console.WriteLine("Cocuk");
            }else if(age >=7 && age < 18)
            {
                Console.WriteLine("Ergen");
            }else if(age >=18 && age < 35)
            {
                Console.WriteLine("Yetiskin");
            }
            else
            {
                Console.WriteLine("Yasli");
            }


            Console.WriteLine(age < 18 ? "Giremez" : "Girebilir"); //single line if

        }
    }
}
