using System;

namespace Operators
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Operators");
            /*
             * 
             *  +
             *  -
             *  *
             *  /
             *  %
             *  ++
             *  --
             */

            /*
             * ==
             * !=
             * >=
             * >
             * 
             * &&
             * ||
             * !
             * 
             */

            int x = 123 + 34;
            Console.WriteLine("X is : " + x);

            string firstName = "Hamdi";
            string lastName = "Tug";

            string user = firstName + " " + lastName;
            Console.WriteLine(user);

            int number = 101;
            number++;
            ++number;
            Console.WriteLine("Number is :" + number);




        }
    }
}
