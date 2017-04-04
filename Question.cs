using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4Movies2
{
    class Question
    {
        public static string AskForString(string prompt)
        {
            System.Console.Write(prompt.PadRight(40) + " : ");
            return System.Console.ReadLine();
        }

        public static int AskForInt(string prompt)
        {
            return int.Parse(AskForString(prompt));
        }
    }
}