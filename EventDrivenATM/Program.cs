namespace EventDrivenATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            MyATMLogIn.LoggingIn += ATMActivities.TakeAction;

            MyATMLogIn.StartProcess();
        }
    }
}