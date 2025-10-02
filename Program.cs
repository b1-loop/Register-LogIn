using Register;

namespace Register_LogIn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Välj mellan alternativ 1-3");


            //Övning – Registrering & Inloggning med Lösenordskontroll


            //Steg 1 – Rita diagram

            //Rita ett flödesdiagram som visar hela processen:
            //Användaren möts av en meny: Registrera eller Logga in.
            //Om registrering: mata in användarnamn + lösenord → kontrollera lösenordets styrka(minst 6 tecken, minst 1 siffra, minst 1 stor bokstav, minst 1 specialtecken).
            //Om lösenordet ej godkänt → visa felmeddelande, registrering misslyckas.
            //Annars → spara användarnamn och lösenord i ett objekt.

            //Om inloggning: jämför inmatat användarnamn och lösenord med det sparade.
            //Om match → “Inloggning lyckades!”.
            //Annars → “Felaktiga uppgifter.”

            //Steg 2 – Klassdesign
            //Account
            //Attribut: Username, Password
            //Metoder:
            //Register(string username, string password) – returnerar true / false om registreringen lyckas.
            //Login(string username, string password) – returnerar true / false om inloggningen lyckas.
            //CheckPasswordStrength(string password) – returnerar true / false(innehåller logik för styrkekrav).

            //MenuHelper(statisk klass)
            //Metod: ShowMenu() – skriver ut huvudmenyn.

            //Steg 3 – Main - flöde
            //Visa meny(Registrera eller Logga in).
            //Om “Registrera”: be om användarnamn och lösenord → använd Account.Register().
            //Om “Logga in”: be om användarnamn och lösenord → använd Account.Login().
            //Programmet fortsätter tills användaren väljer att avsluta.

            //var account = new Account();
            var fortsatt = true;
            var account = new Account();

            while (fortsatt)
            {
                Account.MenuHelper.ShowMenu();
                var alternativ = Console.ReadLine();

                switch (alternativ)
                {
                    case "1":
                        Console.WriteLine("Välj anvädare namn");
                        var userName = Console.ReadLine();
                        Console.WriteLine("Välj Lösenord");
                        var passWord = Console.ReadLine();
                        
                        if (account.Register(userName, passWord))
                        {
                            Console.WriteLine($"Du har registerats");
                        }
                        else
                        {
                            Console.WriteLine("Fail testa igen");
                        }
                        break;

                    case "2":
                        Console.WriteLine("Skriv anvädanamn");
                        var redanuserName = Console.ReadLine();
                        Console.WriteLine("Skriv in ditt lösenord");
                        var redanpassWord = Console.ReadLine();
                        if (account.Login(redanuserName, redanpassWord))
                        {
                            Console.WriteLine($"Welcome {redanuserName}");
                        }
                        else
                        {
                            Console.WriteLine("Fail to log in");
                        }
                        break;

                    case "3":
                        fortsatt = false;
                        break;





                }
            }



        }
    }
}
