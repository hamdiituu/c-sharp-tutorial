using System;

namespace Variables
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            // type variableName = value;

            /*
             * 
             * int 1245
             * double 1234.4225D
             * char 'd'
             * string "hamdi"
             * bool true or false or 0 or 1
             * 
             */

            string name = "Hamdi";
            Console.WriteLine(name);

            int myNumber = 154;
            Console.WriteLine(myNumber);

            int age;
            age = 12;
            Console.WriteLine(age);

            double money = 1234.445475D;
            Console.WriteLine(money);

            const float pi = 3.14465F;

            //pi = 3;

            Console.WriteLine(pi);

            char myLetter = 'H';
            bool myBool = true;

            Console.WriteLine("myLetter " + myLetter);


            string firstName = "Hamdi";
            string lastName = "Tug";
            string user = firstName + lastName;
            Console.WriteLine(user);

            int x = 123;
            int y = 56;
            int z = x + y;
            Console.WriteLine("X+Y=" + z);

            int num1 = 34,
                num2 = 54;

            Console.WriteLine("num1 + num2 =" + (num1 + num2));


            //dogru isimlendirme

            int minutesPerHour = 60; //camelCase

            int minutes_per_hour = 60; //snake_case

            int MinutesPerHour = 60; // PascalCase


            int myNum = 5;               // Integer (whole number)
            double myDoubleNum = 5.99D;  // Floating point number
            char myLetter2 = 'D';         // Character
            bool myBool2 = true;          // Boolean
            string myText = "Hello";     // String

            //type casting

            double colorCode = 1243.455D;
            Console.WriteLine("Color Code Double is :" + colorCode);

            //way 1 manuel casting

            int intColorCode = (int)colorCode;
            Console.WriteLine("Color Code Int is : " + intColorCode);

            //way 2 method casting

            int int2ColorCode = Convert.ToInt32(colorCode);
            Console.WriteLine("Color Code Int 2 is  :" + int2ColorCode);


            bool trueBool = true;
            string trueString = Convert.ToString(trueBool);
            Console.WriteLine("True Bool is :" + trueBool);
            Console.WriteLine("True String is :" + trueString);

            //User Input

            Console.WriteLine("Birseyler Yaz : ");
            string input = Console.ReadLine();
            Console.WriteLine("User input is : " + input);

            Console.WriteLine("YASINIZ : ");
            int inputAge = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("YAS : " + inputAge);


        }
    }
}
