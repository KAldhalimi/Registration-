using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab7practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a valid email");
            string inputEmail = Console.ReadLine();
            if (CheckEmail(inputEmail))
            {
                Array(inputEmail).ToArray();
                Console.WriteLine("Email is valid!");
                Console.WriteLine("Please enter a valid password.");
                string inputPassword = Console.ReadLine();
                if(CheckPassword(inputPassword))
                {
                    Array(inputPassword).ToArray();
                    Console.WriteLine("Password is valid");
                }
                else
                {
                    Console.WriteLine("Password is not valid.");
                }
            }
            else
            {
                Console.WriteLine("Email is not valid!");
            }

        }

        private static bool CheckEmail(string inputEmail)
        {
            return (Regex.IsMatch(inputEmail, "^[a-zA-z0-9]{3,20}[@][[a-zA-z0-9]{3,20}[.][a-zA-z]{2,3}$"));
        }

        private static bool CheckPassword(string inputPassword)
        {
            return (Regex.IsMatch(inputPassword, "^(?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{5,}$"));
        }

        static string[] Array(string input)
        {
            string[] newArray = new string[5];
            return newArray;

        }
    }
}