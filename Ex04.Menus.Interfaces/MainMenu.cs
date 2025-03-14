namespace Ex04.Menus.Interfaces
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