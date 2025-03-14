using System;

namespace Ex04.Menus.Interfaces
{
    public abstract class MenuBaseItem
    {
        private readonly string r_Title;

        public MenuBaseItem(string i_Title)
        {
            r_Title = i_Title;
        }

        public string Title
        {
            get { return r_Title; }
        }

        protected string SpaceLine
        {
            get { return Environment.NewLine; }
        }

        protected void PauseForUserInput()
        {
            Console.WriteLine(SpaceLine);
            Console.WriteLine("To Continue To Menu... (Press any key)");
            Console.ReadLine();
            Console.Clear();
        }

        internal abstract void ShowItem();
    }
}
