using System;
using System.Text.RegularExpressions;

namespace ConsoleApp1
{
    class Program
    {
        //Validate Palindrome: 
        //====================
        //Given a string, determine if it is a palindrome, considering only alphanumeric
        //characters and ignoring cases.

        //Note: For the purpose of this problem, we define empty string as valid
        //palindrome.

        //Example 1:

        //```
        //Input: "A man, a plan, a canal: Panama"
        //Output: true
        //```

        //Example 2:

        //```
        //Input: "race a car"
        //Output: false
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string to check if it is a palindrome.");
            string userEntry = RemoveNonalphanumericCharsAndConvertToLower(Console.ReadLine());
            while (userEntry != "exit")
            {
                Console.WriteLine(IsPalindrome(userEntry));
                Console.WriteLine("Enter another string to check or type \"exit\" to quit.");
                userEntry = RemoveNonalphanumericCharsAndConvertToLower(Console.ReadLine());
            }

        }

        public static string RemoveNonalphanumericCharsAndConvertToLower(string str)
        {
            Regex rgx = new Regex("[^a-zA-Z0-9]");
            return rgx.Replace(str, "").ToLower();
        }
        public static Boolean IsPalindrome(string str)
        {
            if (ReverseString(str) == str)
            {
                return true;
            }
            return false;
        }

        public static string ReverseString(string str)
        {
            string reversed = "";
            for (int i = str.Length - 1; i >= 0; i--)
            {
                reversed += str[i];
            }
            Console.WriteLine(reversed);
            return reversed;
        }
    }
}