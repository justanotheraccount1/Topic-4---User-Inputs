﻿namespace Topic_4___User_Inputs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Sam Ahrens 09/12/24
            string userName, name, pizzaTopping;
            int age;
            double price;

            Console.ForegroundColor = ConsoleColor.Green;

            //Console.WriteLine("Enter Username:");
            //userName = Console.ReadLine();

            //Console.WriteLine("Your username is: " + userName);
            //Console.WriteLine();

            //Console.WriteLine("Enter your age:");
            //Console.WriteLine(Int32.TryParse(Console.ReadLine(), out age));
            //Console.WriteLine("You are " + age + " years old");
            //Console.WriteLine();

            //Console.WriteLine("What is the price?");
            //Console.Write("$");
            //Double.TryParse(Console.ReadLine(), out price);
            //Console.WriteLine("The item is on sale for 20% off");
            //Console.WriteLine("You saved " + (price / 5).ToString("C"));
            //Console.WriteLine("Your total comes to " + ((price / 5) * 4).ToString("C"));
            //Console.WriteLine();

            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Hey " + name + "! What is your favorite pizza topping?");
            pizzaTopping = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("I gotta admit " + name + ", " + pizzaTopping + " is a fire pizza topping!");


        }
    }
}
