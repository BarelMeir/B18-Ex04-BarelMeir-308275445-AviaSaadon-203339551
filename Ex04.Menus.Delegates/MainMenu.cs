using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public delegate void InputNotifierDelegate();

    public class MainMenu
    {
        protected List<MenuItem> m_Menu = new List<MenuItem>();
        protected string m_Title;
        protected string m_GoUpString = "exit";

        public MainMenu(string i_Title)
        {
            m_Title = i_Title;
        }

        public void AddItem(MenuItem i_NewMenuItem)
        {
            m_Menu.Add(i_NewMenuItem);
        }

        public virtual void Show()
        {
            Show(m_Title);
        }

        public virtual void Show(string i_Title)
        {
            displayMenu(i_Title);
        }

        protected virtual void displayMenu(string i_Title)   
        {
            bool stayInMenu = true;
            int userInput;
            string subMenuTitle;

            while (stayInMenu)
            {
                Console.Clear();
                printCurrentMenu(i_Title);
                userInput = readLineNumberFromUser();
                if (userInput != 0)
                {
                    subMenuTitle = m_Menu[userInput - 1].m_Title;
                    m_Menu[userInput - 1].ChosenLine(subMenuTitle);
                }
                else
                {
                    stayInMenu = false;
                }
            }
        }

        protected virtual int readLineNumberFromUser()
        {
            int userInput;
            bool isValidInput;

            isValidInput = int.TryParse(Console.ReadLine(), out userInput);
            while (!isValidInput || userInput < 0 || userInput > m_Menu.Count)
            {
                Console.WriteLine("Invalid line number, please try again:");
                isValidInput = int.TryParse(Console.ReadLine(), out userInput);
            }

            return userInput;
        }

        protected virtual void printCurrentMenu(string i_Title)
        {
            StringBuilder menuBuilder = new StringBuilder();

            menuBuilder.AppendLine(i_Title);
            menuBuilder.AppendLine("-------------------");
            for (int i = 0; i < m_Menu.Count; i++)
            {
                menuBuilder.AppendLine((i + 1) + ". " + m_Menu[i].m_Title);
            }

            menuBuilder.AppendLine("0. " + m_GoUpString);
            menuBuilder.Append("Please enter the wanted line number:  ");
            Console.WriteLine(menuBuilder);
        }
    }
}
