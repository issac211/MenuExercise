namespace Ex04.Menus.Test
{
    internal class Program
    {
        public static void Main()
        {
            MenuTesterInterfaces interfacesMenuTester = new MenuTesterInterfaces();
            MenuTesterDelegates delegatesMenuTester = new MenuTesterDelegates();

            interfacesMenuTester.RunTest();
            delegatesMenuTester.RunTest();
        }
    }
}
