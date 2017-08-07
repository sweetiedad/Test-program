using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class ItemAnswer
    {
        public string item;
        public string answer;
        public float itemPoint;
        static float allPoints;
        static float oneHundredPercent;
        public static float answerPerent;

        public void CheckAnswer()
        {
            Console.WriteLine(item);
            string input_answer = Console.ReadLine();

            if (input_answer == answer)
            {
                allPoints += itemPoint;
            }
            oneHundredPercent += itemPoint;
        }

        public static void Procent()
        {
            answerPerent = 100 * allPoints / oneHundredPercent;
        }
    }
}
