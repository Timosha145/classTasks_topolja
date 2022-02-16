using System;
using System.Collections.Generic;
using System.Text;

namespace classTasks_topolja
{
    class Class1
    {
        public static List<string> suggestFood(double BOO, List<string> food, List<int> calories)
        {
            Random rnd = new Random();
            int nCalories = 0;
            List<string> foodList = new List<string>();
            do
            {
                int randN = rnd.Next(1, calories.Count);
                int a=calories[randN];
                nCalories += a;
                foodList.Add(food[randN]);
            } while (nCalories+100<BOO);

            return foodList;
        }
    }
}
