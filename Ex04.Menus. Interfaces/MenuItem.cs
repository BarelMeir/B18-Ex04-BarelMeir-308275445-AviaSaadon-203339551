using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem : MainMenu
    {
        private List<IMenuable> m_SubOptions = new List<IMenuable>();

        public MenuItem(string i_Title) : base(i_Title)
        {
            m_GoUpString = "back";
        }

        public void ChosenLine(string i_SubMenuTitle)
        {
            foreach (IMenuable currentMenu in m_SubOptions)
            {
                currentMenu.ReportChosen(m_Title);
            }

            if (m_Menu.Count > 0)
            {
                Show(i_SubMenuTitle);
            }
        }

        public void AddSubMenu(IMenuable i_SubMenu)
        {
            m_SubOptions.Add(i_SubMenu);
        }
    }
}
