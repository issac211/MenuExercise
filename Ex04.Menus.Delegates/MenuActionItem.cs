using System;

namespace Ex04.Menus.Delegates
{
    public class MenuActionItem : MenuBaseItem
    {
        public event Action MethodSelected;

        public MenuActionItem(string i_Title) : base(i_Title)
        {
        }

        internal override void ShowItem()
        {
            OnMethodSelected();
            PauseForUserInput();
        }

        private void OnMethodSelected()
        {
            if(MethodSelected != null)
            {
                MethodSelected.Invoke();
            }
        }
    }
}
