using System;
using System.Collections.Generic;
using System.Text;

namespace Ex04.Menus.Interfaces
{
    public class MenuItem : MenuBaseItem
    {
        private const int k_FinishButtonIndex = 0;
        private const int k_StartingChildrenIndex = 1;
        private bool m_IsFinishedSelection = false;
        private readonly List<MenuBaseItem> r_Childrens;

        public MenuItem(string i_Title) : base(i_Title)
        {
            r_Childrens = new List<MenuBaseItem>();
        }

        protected virtual string FinishButtonName
        {
            get { return "Back"; }
        }

        public void AddMenuItem(MenuBaseItem i_MenuItem)
        {
            r_Childrens.Add(i_MenuItem);
        }

        public void RemoveMenuItem(MenuBaseItem i_MenuItem)
        {
            r_Childrens.Remove(i_MenuItem);
        }

        internal override void ShowItem()
        {
            showAndGetSelectionsFromUser();
            resetMenuItem();
        }

        private void resetMenuItem()
        {
            m_IsFinishedSelection = false;
            Console.Clear();
        }

        private void showAndGetSelectionsFromUser()
        {
            while (!m_IsFinishedSelection)
            {
                int itemIndex = getItemIndexFromUser();

                if (!m_IsFinishedSelection)
                {
                    r_Childrens[itemIndex].ShowItem();
                }
            }
        }

        private int getItemIndexFromUser()
        {
            int inputIndex = k_FinishButtonIndex;
            int itemsAmount = r_Childrens.Count;
            bool inputIsInt = false;
            bool inputInRange = false;

            while ((!inputIsInt || !inputInRange) && itemsAmount > 0)
            {
                showSelections();
                Console.WriteLine(
                $"Enter your request: {k_StartingChildrenIndex} to {itemsAmount} or press '{k_FinishButtonIndex}' to {FinishButtonName}");

                string userInput = Console.ReadLine();

                inputIsInt = int.TryParse(userInput, out inputIndex);
                if (inputIsInt)
                {
                    inputInRange = (inputIndex >= k_StartingChildrenIndex && inputIndex <= itemsAmount)
                                        || inputIndex == k_FinishButtonIndex;
                }

                Console.Clear();
                if (!inputIsInt)
                {
                    Console.WriteLine($"The input '{userInput}' is not int" + SpaceLine);
                }
                else if (!inputInRange)
                {
                    Console.WriteLine($"The input '{userInput}' is not in range" + SpaceLine);
                }
            }

            if (itemsAmount <= 0)
            {
                Console.WriteLine("The MenuItem is empty...");
                PauseForUserInput();
            }

            if (inputIndex == k_FinishButtonIndex)
            {
                m_IsFinishedSelection = true;
            }

            int itemIndex = inputIndex - k_StartingChildrenIndex;

            return itemIndex;
        }
        
        private void showSelections()
        {
            StringBuilder items = new StringBuilder();
            int itemIndex = k_StartingChildrenIndex;

            Console.WriteLine($"**{Title}**");
            items.Append('-', 30);
            items.AppendLine();
            foreach (MenuBaseItem menuItem in r_Childrens)
            {
                items.AppendLine($"{itemIndex} -> {menuItem.Title}");
                itemIndex++;
            }

            items.AppendLine($"{k_FinishButtonIndex} -> {FinishButtonName}");
            items.Append('-', 30);
            Console.WriteLine(items.ToString());     
        }
    }
}
