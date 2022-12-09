using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventDrivenATM
{
    internal partial class ATMActivities
    {
        private static void GetAcctDetails()
        {
        tryagain:
            ATMConsoleOutput.GetAcctDetails1();
            string acctNum = Console.ReadLine();
            Console.Clear();

            try
            {
                if (long.TryParse(acctNum, out long actNumber) && (acctNum.Length == 10))
                {
                    ATMConsoleOutput.GetAcctDetails2();
                    string bank = Console.ReadLine();
                    Console.Clear();

                    if (bank != "1" && bank != "2" && bank != "3" && bank != "4") throw new InvalidDataException();
                }
                else throw new Exception();
            }
            catch (InvalidDataException)
            {
                Console.WriteLine("Invalid bank input. Retry\n");
                goto tryagain;
            }
            catch (Exception)
            {
                Console.WriteLine("Account number must be a 10 digit number");
                goto tryagain;
            }
        }

        private static void NextSteps()
        {
            ATMConsoleOutput.NextStepsOutPut();
            string nextSteps = Console.ReadLine();

            switch (nextSteps)
            {
                case "1":
                    TakeAction();
                    break;
                case "2":
                    ATMConsoleOutput.TakeAction2();
                    break;
                default:
                    ATMConsoleOutput.InvalidInput();
                    break;
            }
        }

        private static double GetValidAmount()
        {
            double amount;
            double availableBal = MyATMLogIn.GetBal();
        start:
            ATMConsoleOutput.EnterAmt();
            try
            {
                string amountString = Console.ReadLine();
                Console.Clear();
                if ((double.TryParse(amountString, out amount) == false) || amount < 100) throw new Exception();
                if (amount > availableBal)
                {
                    ATMConsoleOutput.ValidAmt1();
                    goto start;
                }
            }
            catch (Exception)
            {
                ATMConsoleOutput.ValidAmt2();
                goto start;
            }
            return amount;
        }
    }
}
