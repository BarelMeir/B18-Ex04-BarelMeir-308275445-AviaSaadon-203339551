using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Delegates
{
    public class MenuItem : MainMenu
    {
        public event InputNotifierDelegate SelectedLineNumber;

        public MenuItem(string i_Title) : base(i_Title)
        {
            m_GoUpString = "back";
        }

        public void ChosenLine(string i_SubMenuTitle)
        {
            if (SelectedLineNumber != null)
            {
                SelectedLineNumber.Invoke();
            }

            if (m_Menu.Count > 0)
            {
                displayMenu(i_SubMenuTitle);
            }
        }
    }
}
