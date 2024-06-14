using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeOrNot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a String: ");
            string str = Console.ReadLine();

            bool isPalindrome = true;
            int length = str.Length;

            for (int i = 0; i < length / 2; i++)
            {
                if (str[i] != str[length - 1 - i])
                {
                    isPalindrome = false;
                    break;
                }
            }

            if (isPalindrome)
            {
                Console.WriteLine(str + " is a palindrome");
            }
            else
            {
                Console.WriteLine(str + " is not a palindrome");
            }
            Console.ReadLine();
        }
    }
}