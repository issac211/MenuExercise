using System;
using System.Collections.Generic;
using System.Linq;
namespace Ex04.Menus.Delegates
{
    public class MainMenu : MenuItem
    {
        public MainMenu(string i_Title) : base(i_Title)
        {
        }

        protected override string FinishButtonName
        {
            get { return "Exit"; }
        }

        public void Show()
        {
            this.ShowItem();
        }
    }
}
