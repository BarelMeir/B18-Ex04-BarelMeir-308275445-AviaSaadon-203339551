using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    public class DelegatesSystem : Program
    {
        private MainMenu m_MainMenu;

        public DelegatesSystem()
        {
            delegateSystemTest();
        }

        private void delegateSystemTest()
        {
            MainMenu mainMenu = new MainMenu("Main Menu");
            MenuItem showDateOrTime = new MenuItem(k_ShowDateOrTimeString);
            MenuItem showTime = new MenuItem(k_ShowTimeString);
            MenuItem showDate = new MenuItem(k_ShowDateString);
            MenuItem versionAndCapitals = new MenuItem(k_VersionAndCapitalsString);
            MenuItem countCapitals = new MenuItem(k_CountCapitalsString);
            MenuItem showVersion = new MenuItem(k_ShowVersionString);

            showTime.SelectedLineNumber += ShowTime;
            showDate.SelectedLineNumber += ShowDate;
            countCapitals.SelectedLineNumber += CountCapitals;
            showVersion.SelectedLineNumber += ShowVersion;
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
