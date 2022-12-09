using System;

namespace EventDrivenATM
{
    internal class ATMConsoleOutput
    {
        public static void InvalidInput()
        {
            if (MyATMLogIn.language == "1") Console.WriteLine("\nINVALID INPUT");
            if (MyATMLogIn.language == "2") Console.WriteLine("\nOPTION INVALIDE");
        }

        public static void PleaseWait()
        {
            if (MyATMLogIn.language == "1") Console.WriteLine("\nPlease wait...\n");
            if (MyATMLogIn.language == "2") Console.WriteLine("\nS'il vous plaît, attendez...\n");
        }

        public static void CardInserted()
        {
            if (MyATMLogIn.language == "1") Console.WriteLine("\nCard inserted");
            if (MyATMLogIn.language == "2") Console.WriteLine("\nCarte insérée\n");
        }

        public static void GetUsernameOutput()
        {
            if (MyATMLogIn.language == "1") Console.WriteLine("\nEnter your name\n");
            if (MyATMLogIn.language == "2") Console.WriteLine("\nEntrez votre nom\n");
        }

        public static void InvalidUserName()
        {
            if (MyATMLogIn.language == "1") Console.WriteLine("\nInvalid detail supplied.\n" +
                "Your name is now OKORO\n");
            if (MyATMLogIn.language == "2") Console.WriteLine("Détail non valide fourni.\nTu " +
                "t'appelles maintenant OKORO\n");
        }

        public static void TakeActionOutput()
        {
            if (MyATMLogIn.language == "1") Console.WriteLine("\nWhat would you like to do? Press\n\n" +
                "1. For withdrawal\n\n2. For transfer\n\n3. To check Balance\n\nPress 0 to cancel");
            if (MyATMLogIn.language == "2") Console.WriteLine("\nQu'est-ce que tu aimerais faire? Presse\n\n" +
                "1. Pour le retrait\n\n2. Pour transfert\n\n3. Pour vérifier le solde\n\nAppuyez sur 0 pour annuler\n");
        }

        public static void TakeAction2()
        {
            if (MyATMLogIn.language == "1") Console.WriteLine("\nSee you some other time");
            if (MyATMLogIn.language == "2") Console.WriteLine("\nA une autre fois");
        }

        public static void EnterAmt()
        {
            if (MyATMLogIn.language == "1") Console.WriteLine("\nEnter amount below:\n");
            if (MyATMLogIn.language == "2") Console.WriteLine("\nEntrez le montant ci-dessous:\n");
        }


        public static void GetPinOutput1()
        {
            if (MyATMLogIn.language == "1") Console.WriteLine("\nEnter 4 digit pin\n");
            if (MyATMLogIn.language == "2") Console.WriteLine("\nEntrez le code PIN à 4 chiffres\n");
        }

        public static void GetPinOutput2()
        {
            if (MyATMLogIn.language == "1") Console.WriteLine("\nLog in successful\n");
            if (MyATMLogIn.language == "2") Console.WriteLine("\nConnexion réussie\n");
        }

        public static void GetPinOutput3()
        {
            if (MyATMLogIn.language == "1") Console.WriteLine($"Welcome {MyATMLogIn.GetUserDetails.CardUser}\n");
            if (MyATMLogIn.language == "2") Console.WriteLine($"Bienvenu {MyATMLogIn.GetUserDetails.CardUser}\n");
        }

        public static void GetPinOutput4()
        {
            if (MyATMLogIn.language == "1") Console.WriteLine("\nCard blocked. Visit the bank for further assistance");
            if (MyATMLogIn.language == "2") Console.WriteLine("\nCarte bloquée. Rendez-vous à la banque pour obtenir de l'aide");
        }

        public static void GetPinOutput5()
        {
            if (MyATMLogIn.language == "1") Console.WriteLine($"\nPin must be a 4-digit number.\nYou have " +
                $"{MyATMLogIn.allowedpinTries} tries left\n");
            if (MyATMLogIn.language == "2") Console.WriteLine($"Le code PIN doit être un numéro à 4 " +
                $"chiffres.\nIl vous reste {MyATMLogIn.allowedpinTries} essais\n");
        }


    }
}
