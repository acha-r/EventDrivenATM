namespace EventDrivenATM
{
    internal partial class ATMActivities
    {
        internal static void TakeAction()
        {
            ATMConsoleOutput.TakeActionOutput();
            string userInput = Console.ReadLine();
            Console.Clear();

            switch (userInput)
            {
                case "1":
                    Withdrawal();
                    break;
                case "2":
                    Transfer();
                    break;
                case "0":
                    ATMConsoleOutput.TakeAction2();
                    Environment.Exit(0);
                    break;
                default:
                    ATMConsoleOutput.InvalidInput();
                    break;
            }
        }

        private static void Withdrawal()
        {
            double availableBal = MyATMLogIn.GetBal();
            double amount = GetValidAmount();
            double currentBal = availableBal - amount;

            ATMConsoleOutput.PleaseWait();
            Thread.Sleep(1000);
            ATMConsoleOutput.WithdrawalOutput();

            string nextSteps = Console.ReadLine();
            Console.Clear();

            switch (nextSteps)
            {
                case "0":
                    Console.WriteLine($"\nDebit\nAmt: ${amount}\nAcc: 002******890\nDesc:000GenesysTechHub/ATM/bezao\nTime:{DateTime.Now}" +
                            $"\nAvailBal: ${currentBal}\n");
                    ATMConsoleOutput.Thankyou();
                    break;
                case "1":
                    NextSteps();
                    break;
                default:
                    ATMConsoleOutput.InvalidInput();
                    NextSteps();
                    break;
            }
        }

        private static void Transfer()
        {
            double amount = GetValidAmount();
            double currBal = MyATMLogIn.GetBal() - amount;

            GetAcctDetails();
            ATMConsoleOutput.PleaseWait();
            Thread.Sleep(1000);
            ATMConsoleOutput.WithdrawalOutput();

            string nextSteps = Console.ReadLine();
            Console.Clear();

            switch (nextSteps)
            {
                case "0":
                    Console.WriteLine($"\nDebit\nAmt: ${amount}\nAcc: 002******890\nDesc:000GenesysTechHub/ATM/bezao\nTime:{DateTime.Now}" +
                            $"\nAvailBal: ${currBal}\n");
                    ATMConsoleOutput.Thankyou();
                    break;
                case "1":
                    NextSteps();
                    break;
                default:
                    ATMConsoleOutput.InvalidInput();
                    NextSteps();
                    break;
            }
        }      
    }
}