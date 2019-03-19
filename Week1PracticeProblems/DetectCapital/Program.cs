using System;

namespace DetectCapital
{
    class Program
    {
        //Detect Capital
        //==============
        //Given a word, you need to judge whether the usage of capitals in it is right or
        //not.

        //We define the usage of capitals in a word to be right when one of the following
        //cases holds:

        //  1. All letters in this word are capitals, like "USA".
        //  2. All letters in this word are not capitals, like "leetcode".
        //  3. Only the first letter in this word is capital if it has more than one
        //     letter, like "Google".

        //Otherwise, we define that this word doesn't use capitals in a right way.

        //Example 1:

        //```
        //Input: "USA"
        //Output: True
        //```

        //Example 2:
        //```
        //Input: "FlaG"
        //Output: False
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word to check if it is has correct capitalization.");
            string userEntry = Console.ReadLine();
            while (userEntry != "exit")
            {
                Console.WriteLine(CheckCapitalization(userEntry));
                Console.WriteLine("Enter another word to check or type \"exit\" to quit.");
                userEntry = Console.ReadLine();
            }
        }

        static Boolean CheckCapitalization(string word)
        {
            if (word.ToUpper() == word || word.ToLower() == word)
            {
                return true;
            }
            if (char.IsUpper(word[0]) && char.IsLower(word[1]))
            {
                for (int i = word.Length - 1; i > 0; i--)
                {
                    if (char.IsUpper(word[i]) == true)
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }
    }
}