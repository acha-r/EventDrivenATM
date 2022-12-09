namespace EventDrivenATM
{
    internal class ATMActivities
    {
        internal static void TakeAction()
        {
            ATMConsoleOutput.TakeActionOutput();
            string userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    //Withdrawal();
                    GetValidAmount();
                    Console.WriteLine("Withdrwa");
                    break;
                case "2":
                    //Transfer();
                    Console.WriteLine("Withdrwa");
                    break;
                case "3":
                    //CheckBalance();
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

        public static double GetValidAmount()
        {
        start:
            double currentBal = MyATMLogIn.GetBal();
            double amount;
            ATMConsoleOutput.EnterAmt();
            try
            {
                string amountString = Console.ReadLine();
                if (!double.TryParse(amountString, out amount) && amount > 100) throw new Exception();
            }
            catch (Exception)
            {
                Console.WriteLine("Amount must be a number greater than 100");
                goto start;
            }
            return amount;
        }
    }
}
