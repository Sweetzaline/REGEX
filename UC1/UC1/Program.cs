using System;
using System.Text.RegularExpressions;

namespace UC1to9
{
    class Program
    {
        public static string REGEX_PATTERN = "^[A-Z]{1}[a-zA-Z]{6,}";
        static void Main(string[] args)
        {
            Console.WriteLine("User Registration Problems");
            FirstNameVal();
            LastNameVal();
            EmailValidation();
            MobileValidation();
            PasswordRule();
        }
        public static void FirstNameVal()
        {
            Regex rg = new Regex(REGEX_PATTERN);
            Console.Write("Enter First Name: ");
            string first_name = Console.ReadLine();
            bool validate = rg.IsMatch(first_name);
            if (validate)
                Console.WriteLine("Name is Valid : " + first_name);
            else
                Console.WriteLine("Invalid FirstName");
        }
        public static void LastNameVal()
        {
            Regex rg = new Regex(REGEX_PATTERN);
            Console.Write("Enter Last Name: ");
            string last_name = Console.ReadLine();
            bool validate = rg.IsMatch(last_name);
            if (validate)
                Console.WriteLine("Name is Valid : " + last_name);
            else
                Console.WriteLine("Invalid LastName");
        }
        public static void EmailValidation()
        {
            string EMAIL_PATTERN = "^[a-zA-Z0-9]+[.(a-zA-Z0-9)]*(\\@)[a-zA-Z0-9]+(\\.)[a-z]{2,3}[.(a-z)]*$";
            Regex rg = new Regex(EMAIL_PATTERN);
            Console.Write("Enter E-mail: ");
            string email = Console.ReadLine();
            bool validate = rg.IsMatch(email);
            if (validate)
                Console.WriteLine("Email is valid : " + email);
            else
                Console.WriteLine("Invalid E-mail.");
        }
        public static void MobileValidation()
        {
            string MobilePattern = "^(91){1}[ ]+[0-9]{10}$";
            Regex rg = new Regex(MobilePattern);
            Console.Write("Enter Mobile_NO: ");
            string mobile = Console.ReadLine();
            bool validate = rg.IsMatch(mobile);
            if (validate)
                Console.WriteLine("Mobile is valid : " + mobile);
            else
                Console.WriteLine("Invalid Mobile..");
        }
        public static void PasswordRule()
        {
            string PasswordPattern = "^(?=.*[A-Z])(?=.*[0-9])(?=.*[~!@#$%^&*.-])[a-zA-Z0-9].{8,}$";
            Regex rg = new Regex(PasswordPattern);
            Console.Write("Enter Password: ");
            string password = Console.ReadLine();
            bool validate = rg.IsMatch(password);
            Console.WriteLine(validate);
        }

    }
}
//User Registration Problems
//Name is Valid : Isweety
//Enter Last Name: Isweety
//Name is Valid : Isweety
//Enter E-mail: abc.g @gmail.com
//Email is valid : abc.g @gmail.com
//Enter Mobile_NO: 91 1111111111
//Mobile is valid : 91 1111111111
//Enter Password: A0$sssssss1
//True