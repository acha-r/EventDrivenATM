using System.Text.RegularExpressions;

namespace EventDrivenATM
{
    internal static partial class MyATMLogIn
    {
        public static event Action LoggingIn;
        internal static string language;
        private static double _acctBal;
        internal static int allowedpinTries = 3;
        static Regex rgx = new Regex("[^A-Za-z]");

        public static double GetBal()
        {
            _acctBal = 1000;
            return _acctBal;
        }
        static MyATMLogIn()
        {
        start:
            try
            {
                Console.WriteLine("Choose preferred language. Press\n1. For English\n2. Pour Francais\n");
                language = Console.ReadLine();
                if (language != "1" && language != "2") throw new Exception();
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Invalid input\n\nINVALID OPTION");
                goto start;
            }
        }

        public static void StartProcess()
        {
            StartATM();
            OnProcessCompleted();
        }

        public static void OnProcessCompleted()
        {
            LoggingIn?.Invoke();
        }

        internal static void StartATM()
        {
            GetUserDetails.StartingATM += GetPin;
            GetUserDetails.StartProcess();
        }

        private static void GetPin()
        {

        enterpin:
            ATMConsoleOutput.GetPinOutput1();
            string pin = Console.ReadLine();

            if (pin.Length == 4 && int.TryParse(pin, out int x))
            {
                ATMConsoleOutput.GetPinOutput2();
                Thread.Sleep(1000);
                Console.Clear();
                ATMConsoleOutput.GetPinOutput3();
                return;
            }

            for (int i = 1; i <= allowedpinTries; i++)
            {
                --allowedpinTries;
                if (allowedpinTries == 0)
                {
                    ATMConsoleOutput.GetPinOutput4();
                    Environment.Exit(1);
                }
                Console.Clear();
                ATMConsoleOutput.GetPinOutput5();
                goto enterpin;
            }
        }
    }
}
