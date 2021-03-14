using System;

namespace Strings
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Strings");

            string text = "Lorem ipsum sit amet";

            Console.WriteLine("Text is :" + text);

            int textLenght = text.Length;

            Console.WriteLine("Text Lenght is :" + textLenght);

            string textUpper = text.ToUpper();

            Console.WriteLine("Text Upper is :" + textUpper);

            //interpolation

            string fName = "Hamdi";
            string lName = "Tug";
            string name = "User is :" +fName + " " + lName;
            Console.WriteLine(name);
            string name2 = $"User is : {fName} {lName}";
            Console.WriteLine(name2);
        }
    }
}
