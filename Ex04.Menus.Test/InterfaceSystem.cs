using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04.Menus.Test
{
    public class InterfaceSystem : Program, Interfaces.IMenuable
    {
        private Interfaces.MainMenu m_MainMenu;

        public InterfaceSystem()
        {
            interfacesSystemTest();
        }

        public void ReportChosen(string i_Titel)
        {
            switch (i_Titel)
            {
                case k_ShowTimeString:
                    ShowTime();
                    break;
                case k_ShowDateString:
                    ShowDate();
                    break;
                case k_CountCapitalsString:
                    CountCapitals();
                    break;
                case k_ShowVersionString:
                    ShowVersion();
                    break;
                default:
                    break;
            }
        }

        private void interfacesSystemTest()
        {
            Interfaces.MainMenu mainMenu = new Interfaces.MainMenu("Main Menu");
            Interfaces.MenuItem showDateOrTime = new Interfaces.MenuItem(k_ShowDateOrTimeString);
            Interfaces.MenuItem showTime = new Interfaces.MenuItem(k_ShowTimeString);
            Interfaces.MenuItem showDate = new Interfaces.MenuItem(k_ShowDateString);
            Interfaces.MenuItem versionAndCapitals = new Interfaces.MenuItem(k_VersionAndCapitalsString);
            Interfaces.MenuItem countCapitals = new Interfaces.MenuItem(k_CountCapitalsString);
            Interfaces.MenuItem showVersion = new Interfaces.MenuItem(k_ShowVersionString);

            showDateOrTime.AddSubMenu(this);
            showTime.AddSubMenu(this);
            showDate.AddSubMenu(this);
            versionAndCapitals.AddSubMenu(this);
            countCapitals.AddSubMenu(this);
            showVersion.AddSubMenu(this);
            mainMenu.AddItem(showDateOrTime);
            mainMenu.AddItem(versionAndCapitals);
            showDateOrTime.AddItem(showTime);
            showDateOrTime.AddItem(showDate);
            versionAndCapitals.AddItem(countCapitals);
            versionAndCapitals.AddItem(showVersion);
            m_MainMenu = mainMenu;
            m_MainMenu.Show();
        }
    }
}
