using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class Program
    {
        protected const string k_ShowDateOrTimeString = "Show Date/Time";
        protected const string k_ShowTimeString = "Show Time";
        protected const string k_ShowDateString = "Show Date";
        protected const string k_VersionAndCapitalsString = "Version and Capitals";
        protected const string k_CountCapitalsString = "Count Capitals";
        protected const string k_ShowVersionString = "Show Version";

        public static void Main()
        {
            new InterfaceSystem();
            new DelegatesSystem();
        }

        protected static void ShowTime()
        {
            Console.Clear();
            Console.WriteLine("The current time is: {0}", DateTime.Now.ToShortTimeString());
            Console.WriteLine("Press ENTER to go back to the menu");
            Console.ReadLine();
        }

        protected static void ShowDate()
        {
            Console.Clear();
            Console.WriteLine("The current date is: {0}", DateTime.Now.ToShortDateString());
            Console.WriteLine("Press ENTER to go back to the menu");
            Console.ReadLine();
        }

        protected static void CountCapitals()
        {
            Console.Clear();
            Console.WriteLine("Please enter a sentence");
            string userInput = System.Console.ReadLine();
            int numberOfCapitals = CountNumberOfCapitalsInString(userInput);
            Console.WriteLine("Number of capitals is: {0}", numberOfCapitals);
            Console.WriteLine("Press ENTER to go back to the menu");
            Console.ReadLine();
        }

        protected static int CountNumberOfCapitalsInString(string i_UserStr)
        {
            int counter = 0;

            foreach(char currentChar in i_UserStr)
            {
                if(currentChar >= 'A' && currentChar <= 'Z')
                {
                    counter++;
                }
            }

            return counter;
        }

        protected static void ShowVersion()
        {
            Console.Clear();
            Console.WriteLine("Version: 18.2.4.0");
            Console.WriteLine("Press ENTER to go back to the menu");
            Console.ReadLine();
        }
    }
}
