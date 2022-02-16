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

            //List<int> numbers = new List<int>();
            //List<int> numbersReady = new List<int>();
            //int a;

            //for (int i = 0; i < 6; i++)
            //{
            //    numbers.Add(rnd.Next(1, 20));
            //}
            //foreach (int item in numbers)
            //{
            //    Console.Write(item + ", ");
            //}
            //int nFirst = numbers[0];
            //int nLast = numbers[numbers.Count - 1];
            //numbers.Insert(0, nLast);
            //numbers.Add(nFirst);
            //Console.WriteLine();

            //for (int i = 0; i < numbers.Count-2; i++)
            //{
            //    a = numbers[i]+numbers[i+2];
            //    //Console.WriteLine($"{numbers[i]}+{numbers[i+2]}");
            //    numbersReady.Add(a);
            //}
            //foreach (int item in numbersReady)
            //{
            //    Console.Write(item + ", ");
            //}

            //List<string> food = new List<string> { "Bread", "Rice", "Burger", "Noodles", "Soup" };
            //List<int> calories = new List<int> { 264, 400, 700, 1500, 1100 };
            //double BOO = 0;

            //Console.WriteLine("Your height: ");
            //double height = int.Parse(Console.ReadLine());
            //Console.WriteLine("Your weight: ");
            //double weight = int.Parse(Console.ReadLine());
            //Console.WriteLine("Your age: ");
            //int age = int.Parse(Console.ReadLine());
            //Console.WriteLine("Your gender (man/woman): ");
            //string gender = Console.ReadLine();
            //Console.WriteLine("Your lifeStyle (lazy - 1, low - 2, average - 3, high - 4, very high - 5): ");
            //int lifeStyle = int.Parse(Console.ReadLine());

            //if (gender == "man")
            //{
            //    BOO = 66 + (13.7 * weight) + (5 * height) - (6.8 * age);
            //}
            //else if (gender == "woman")
            //{
            //    BOO = 655 + (9.6 * weight) + (1.8 * height) - (4.7 * age);
            //}

            //if (lifeStyle == 1)
            //{
            //    Console.WriteLine($"Your BOO = {BOO * 1.2}");
            //    //Class1.suggestFood(BOO * 1.2,food,calories);
            //    Console.Write("You have to eat: ");
            //    foreach (string item in Class1.suggestFood(BOO * 1.2, food, calories))
            //    {
            //        Console.Write(item + ", ");
            //    }
            //}
            //else if (lifeStyle == 2)
            //{
            //    Console.WriteLine($"Your BOO = {BOO * 1.375}");
            //    Console.Write("You have to eat: ");
            //    foreach (string item in Class1.suggestFood(BOO * 1.375, food, calories))
            //    {
            //        Console.Write(item + ", ");
            //    }
            //}
            //else if (lifeStyle == 3)
            //{
            //    Console.WriteLine($"Your BOO = {BOO * 1.55}");
            //    Console.Write("You have to eat: ");
            //    foreach (string item in Class1.suggestFood(BOO * 1.55, food, calories))
            //    {
            //        Console.Write(item + ", ");
            //    }
            //}
            //else if (lifeStyle == 4)
            //{
            //    Console.WriteLine($"Your BOO = {BOO * 1.725}");
            //    Console.Write("You have to eat: ");
            //    foreach (string item in Class1.suggestFood(BOO * 1.725, food, calories))
            //    {
            //        Console.Write(item + ", ");
            //    }
            //}
            //else if (lifeStyle == 5)
            //{
            //    Console.WriteLine($"Your BOO = {BOO * 1.9}");
            //    Console.Write("You have to eat: ");
            //    foreach (string item in Class1.suggestFood(BOO * 1.9, food, calories))
            //    {
            //        Console.Write(item + ", ");
            //    }
            //}

            Dictionary<string, string> dict = new Dictionary<string, string> ();

            List<string> country = new List<string> { "Estonia", "Russia", "England", "Germany", "Finland" };
            List<string> capital = new List<string> { "Tallinn", "Moscow", "London", "Berlin", "Helsinki" };
            bool wantTo = true;
            int randInt = 0;
            double score = 0;

            for (int i = 0; i < country.Count; i++)
            {
                dict.Add(country[i], capital[i]);
                dict.Add(capital[i], country[i]);
            }
            while (wantTo == true)
            {

                Console.WriteLine("What do you want? Search capital/country - 1, play game - 2");
                int answer = int.Parse(Console.ReadLine());
                if (answer == 1)
                {
                    Console.Write("Entry capital/country: ");
                    string input = Console.ReadLine();
                    if (dict.ContainsKey(input))
                    {
                        Console.WriteLine("Pair of " + input + " is " + dict[input]);
                    }
                    else if (!dict.ContainsKey(input))
                    {
                        Console.WriteLine("Unfortunately there is no such word in this dictionary, do you want to add new words? yes - 1, no - 2");
                        answer = int.Parse(Console.ReadLine());
                        if (answer == 1)
                        {
                            Console.WriteLine("Enter new country please");
                            string new1 = Console.ReadLine();

                            Console.WriteLine("Enter new capital please");
                            string new2 = Console.ReadLine();
                            dict.Add(new1, new2);
                            dict.Add(new2, new1);
                        }
                    }
                }
                else if (answer == 2)
                {
                    score = 0;
                    for (int i = 0; i < country.Count; i++)
                    {
                        randInt = rnd.Next(1, 3);
                        int b = rnd.Next(1, country.Count);
                        if (randInt == 1)
                        {
                            Console.WriteLine("Pair of - " + country[b]);
                            string userInput = Console.ReadLine();
                            if (capital.IndexOf(userInput) == country.IndexOf(country[b]))
                            {
                                Console.WriteLine("Good!");
                                score++;
                            }
                        }
                        else if (randInt == 2)
                        {
                            Console.WriteLine("Pair of - " + capital[b]);
                            string userInput = Console.ReadLine();
                            if (country.IndexOf(userInput) == capital.IndexOf(capital[b]))
                            {
                                Console.WriteLine("Good!");
                                score++;
                            }
                        }
                    }
                    Console.WriteLine(score / country.Count * 100 + "%");
                }
            }
        }
    }
}
