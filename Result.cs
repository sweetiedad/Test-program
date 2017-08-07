using System;
using System.Collections.Generic;
using System.Text;

namespace Test
{
    class Result
    {
        public static string resultTest;

        public static void ResultTest()

        {
               if (ItemAnswer.answerPerent < 20)
            {
                resultTest = "You are expelled";
            }
                else if (ItemAnswer.answerPerent > 40 )
            {
                resultTest = "You are enrolled";
            }
                else
            {
                resultTest = "Retake";
            }
        }
    }
}
