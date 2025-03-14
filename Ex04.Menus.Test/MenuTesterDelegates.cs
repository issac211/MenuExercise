using Ex04.Menus.Delegates;

namespace Ex04.Menus.Test
{
    internal class MenuTesterDelegates
    {
        private const string k_MenuTitle = "Delegates Main Menu";
        private Delegates.MainMenu m_MainMenu;
        private readonly TestingTools r_testTools;

        public MenuTesterDelegates()
        {
            r_testTools = new TestingTools();
            m_MainMenu = new Delegates.MainMenu(k_MenuTitle);

            MenuActionItem showDate = new MenuActionItem("Show Date");
            MenuActionItem showTime = new MenuActionItem("Show Time");
            MenuActionItem countCapitals = new MenuActionItem("Count Capitals");
            MenuActionItem showVersion = new MenuActionItem("Show Version");
            MenuItem showDateOrTime = new MenuItem("Show Date/Time");
            MenuItem versionAndCapitals = new MenuItem("Version and Capitals");

            showDate.MethodSelected += showDate_MethodSelected;
            showTime.MethodSelected += showTime_MethodSelected;
            countCapitals.MethodSelected += countCapitals_MethodSelected;
            showVersion.MethodSelected += showVersion_MethodSelected;
            showDateOrTime.AddMenuItem(showDate);
            showDateOrTime.AddMenuItem(showTime);
            versionAndCapitals.AddMenuItem(countCapitals);
            versionAndCapitals.AddMenuItem(showVersion);
            m_MainMenu.AddMenuItem(showDateOrTime);
            m_MainMenu.AddMenuItem(versionAndCapitals);
        }

        internal void RunTest()
        {
            m_MainMenu.Show();
        }

        private void showDate_MethodSelected()
        {
            r_testTools.ShowDate();
        }

        private void showTime_MethodSelected()
        {
            r_testTools.ShowTime();
        }
        private void countCapitals_MethodSelected()
        {
            r_testTools.CountCapitals();
        }
        private void showVersion_MethodSelected()
        {
            r_testTools.ShowVersion();
        }
    }
}