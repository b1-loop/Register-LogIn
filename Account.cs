namespace Register;

public class Account
{
    public string UserName { get; set; }
    public string Password { get; set; }

    public bool Register(string userName, string passWord) // registering som ska spara username och password
    {
        var passwordOk = CheckPassword(passWord);
        var userNameOk = CheckUserName(userName);

        if ((passwordOk && userNameOk) == false)  
        {
            return false;
        }


        Password = passWord;
        UserName = userName;
        return true;
    }

    public bool CheckPassword(string passWord) // (minst 6 tecken, minst 1 siffra, minst 1 stor bokstav, minst 1 specialtecken).
    {
        bool longEnough = passWord.Length >= 6;
        bool hasNumber = passWord.Any(c => char.IsDigit(c));
        bool hasUpper = passWord.Any(c => char.IsUpper(c));
        bool hasLower = passWord.Any(c => char.IsLower(c));
        bool hasSpecial = passWord.Any(c => !char.IsLetterOrDigit(c));

        return (longEnough && hasNumber && hasUpper && hasLower && hasSpecial);
    }

    public bool CheckUserName(string userName)
    {
        return (userName.Length >= 1);
    }

    public bool Login(string userName, string passWord) 
    {
        bool correctUserName = userName == UserName;
        bool correctPassWord = passWord == Password;

        return correctUserName && correctPassWord;

    }

    public static class MenuHelper 
    {
        public static void ShowMenu()
        {
            Console.WriteLine("1) Registerera");
            Console.WriteLine("2) Login");
            Console.WriteLine("3) Avsluta/Logga ut");
        }
    }





}

