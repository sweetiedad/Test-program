using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello the entrant, pass the test and you will be enlisted!");
            Console.WriteLine("Enter the subject!");
            Console.WriteLine("-Math");
            Console.WriteLine("-History");

            Matter.SelectionMatter();
            ItemAnswer.Procent();
            Console.WriteLine("Test Result = " + ItemAnswer.answerPerent + "%");
            Result.ResultTest();
            Console.WriteLine(Result.resultTest);
            /*-------------------*/
            Console.ReadLine();
        }
    }
}
