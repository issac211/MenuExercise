using System.Collections.Generic;

namespace Ex04.Menus.Interfaces
{
    public class MenuActionItem : MenuBaseItem
    {
        private readonly int r_ItemId;
        private readonly List<IMenuListener> r_MenuListeners;

        public MenuActionItem(string i_Title, int i_ItemId) : base(i_Title)
        {
            r_ItemId = i_ItemId;
            r_MenuListeners = new List<IMenuListener>();
        }

        public int ItemId
        {
            get { return r_ItemId; }
        }

        public void AddMenuListener(IMenuListener i_Listener)
        {
            r_MenuListeners.Add(i_Listener);
        }

        public void RemoveMenuListener(IMenuListener i_Listener)
        {
            r_MenuListeners.Remove(i_Listener);
        }

        internal override void ShowItem()
        {
            invokeAllListeners();
            PauseForUserInput();
        }

        private void invokeAllListeners()
        {
            foreach (IMenuListener listener in r_MenuListeners)
            {
                listener.GetSelection(ItemId);
            }
        }
    }
}
