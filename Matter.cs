using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Matter
    {
        public static string matter;

        public static void SelectionMatter()
        {
            matter = Console.ReadLine();
            string[] linesMath = File.ReadAllLines(@"\math.txt");
            string[] linesHistory = File.ReadAllLines(@"\history.txt");
            ItemAnswer ex_ItemAnswer = new ItemAnswer();
            switch (matter)
            {
                case "Math":
                case "math":
                    for (int i = 0; i < linesMath.Length; i += 4)
                    {
                        ex_ItemAnswer.item = linesMath[i];
                        ex_ItemAnswer.answer = linesMath[i + 1];
                        ex_ItemAnswer.itemPoint = Convert.ToInt32(linesMath[i + 2]);
                        ex_ItemAnswer.CheckAnswer();
                        Console.WriteLine("");
                    }
                    break;

                case "History":
                case "history":
                    for (int i = 0; i < linesHistory.Length; i += 4)
                    {
                        ex_ItemAnswer.item = linesHistory[i];
                        ex_ItemAnswer.answer = linesHistory[i + 1];
                        ex_ItemAnswer.itemPoint = Convert.ToInt32(linesHistory[i + 2]);
                        ex_ItemAnswer.CheckAnswer();
                        Console.WriteLine("");
                    }
                    break;
            }
        }
    }
}
