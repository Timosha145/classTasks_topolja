using System;
using System.Collections.Generic;

namespace classTasks_topolja
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            //List<int> numbers = new List<int>();

            //for (int i = 0; i < 20; i++)
            //{
            //    numbers.Add(rnd.Next(1,20));
            //}
            //foreach (int item in numbers)
            //{
            //    if (item%2==0)
            //    {
            //        Console.Write($"{item}, ");
            //    }
            //}
            //Console.WriteLine();
            //foreach (int item in numbers)
            //{
            //    if (item % 2 != 0)
            //    {
            //        Console.Write($"{item}, ");
            //    }
            //}

            List<int> numbers = new List<int>();
            int a = 1;

            for (int i = 0; i < 6; i++)
            {
                numbers.Add(rnd.Next(1, 20));
            }
            foreach (int item in numbers)
            {
                Console.Write(item + ", ");
            }
            int nFirst = numbers[0];
            int nLast = numbers[numbers.Count - 1];
            numbers.Insert(0, nLast);
            numbers.Add(nFirst);
            Console.WriteLine();
            foreach (int item in numbers)
            {
                Console.Write(item + ", ");
            }

            //List<string> food = new List<string> {"Bread", "Egg", "Milk", "Orange", "Lollipop"};
            //List<int> calories = new List<int> {264, 155, 42, 41, 83};

            //Console.WriteLine("Your height: ");
            //double height = int.Parse(Console.ReadLine());
            //Console.WriteLine("Your weight: ");
            //double weight = int.Parse(Console.ReadLine());
            //Console.WriteLine("Your age: ");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Your sex (man/woman): ");
            //string sex = Console.ReadLine();
            //Console.WriteLine("Your lifeStyle (lazy - 1, low - 2, average - 3, high - 4, very high - 5): ");
            //int lifeStyle = int.Parse(Console.ReadLine());

            //if (sex=="man")
            //{
            //    double BOO = 66 +(13.7 * weight) + (5 * height) - (6.8 * age);
            //    if (lifeStyle==1)
            //    {
            //        Console.WriteLine($"Your BOO = {BOO*1.2}");
            //    }
            //}
        }
    }
}
