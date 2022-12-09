using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EventDrivenATM
{
    internal partial class MyATMLogIn
    {
        internal static class GetUserDetails
        {
            public static event Action StartingATM;
            public static string CardUser { get; set; }
            static Regex _rgx = new Regex("[^A-Za-z]");
            public static Regex Rgx { get => _rgx; set => _rgx = value; }

            static GetUserDetails()
            {
                CardUser = GetCardUserName();
            }

            public static void StartProcess()
            {
                Console.Clear();
                ATMConsoleOutput.PleaseWait();
                Thread.Sleep(1000);
                OnProcessCompleted();
            }

            public static void OnProcessCompleted()
            {
                ATMConsoleOutput.CardInserted();
                StartingATM?.Invoke();
            }

            private static string GetCardUserName()
            {
                ATMConsoleOutput.GetUsernameOutput();
                string userName = (Console.ReadLine().ToUpper());
                if (Rgx.IsMatch(userName))
                {
                    ATMConsoleOutput.InvalidUserName();
                    userName = "OKORO";
                }
                return userName;
            }
        }
    }
}
