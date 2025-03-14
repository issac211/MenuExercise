using Ex04.Menus.Interfaces;
using System;

namespace Ex04.Menus.Test
{
    internal class MenuTesterInterfaces : IMenuListener
    {
        private const string k_MenuTitle = "Interfaces Main Menu";
        private Interfaces.MainMenu m_MainMenu;
        private readonly TestingTools r_testTools;

        internal enum eMenuSelection
        {
            ShowDate,
            ShowTime,
            CountCapitals,
            ShowVersion
        }

        public MenuTesterInterfaces()
        {
            r_testTools = new TestingTools();
            m_MainMenu = new Interfaces.MainMenu(k_MenuTitle);

            MenuActionItem showDate = new MenuActionItem("Show Date", (int)eMenuSelection.ShowDate);
            MenuActionItem showTime = new MenuActionItem("Show Time", (int)eMenuSelection.ShowTime);
            MenuActionItem countCapitals = new MenuActionItem("Count Capitals", (int)eMenuSelection.CountCapitals);
            MenuActionItem showVersion = new MenuActionItem("Show Version", (int)eMenuSelection.ShowVersion);
            MenuItem showDateOrTime = new MenuItem("Show Date/Time");
            MenuItem versionAndCapitals = new MenuItem("Version and Capitals");

            showDate.AddMenuListener(this);
            showTime.AddMenuListener(this);
            countCapitals.AddMenuListener(this);
            showVersion.AddMenuListener(this);
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

        void IMenuListener.GetSelection(int i_MenuItemId)
        {
            eMenuSelection selection = (eMenuSelection)i_MenuItemId;

            switch (selection)
            {
                case (eMenuSelection.ShowDate):
                    r_testTools.ShowDate();
                    break;
                case (eMenuSelection.ShowTime):
                    r_testTools.ShowTime();
                    break;
                case (eMenuSelection.CountCapitals):
                    r_testTools.CountCapitals();
                    break;
                case (eMenuSelection.ShowVersion):
                    r_testTools.ShowVersion();
                    break;
                default:
                    throw new Exception("selection not found");
            }
        }
    }
}