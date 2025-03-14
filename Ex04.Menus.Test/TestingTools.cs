using System;

namespace Ex04.Menus.Test
{
    internal class TestingTools
    {
        public void ShowDate()
        {
            DateTime today = DateTime.Now;

            Console.WriteLine("The Date is {0}", today.ToString("dd/MM/yyyy"));
        }

        public void ShowTime()
        {
            DateTime today = DateTime.Now;

            Console.WriteLine("The Hour is {0}", today.ToString("HH:mm"));
        }

        public void CountCapitals()
        {
            Console.WriteLine("Pleas enter your sentence:");

            string userSentence = Console.ReadLine();
            int capitalsCount = 0;

            foreach (char letter in userSentence)
            {
                if (char.IsUpper(letter))
                {
                    capitalsCount++;
                }
            }

            Console.WriteLine("There are {0} capitals in your sentence.", capitalsCount);
        }

        public void ShowVersion()
        {
            Console.WriteLine("Version: 24.1.4.9633");
        }
    }
}
