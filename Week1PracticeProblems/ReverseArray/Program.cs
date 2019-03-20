using System;

namespace ReverseArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an array, and I will reverse it.");
            string userEntry = Console.ReadLine();
            userEntry = userEntry.Replace("[", "").Replace("]","");
            while (userEntry != "exit")
            {
                string[] userEntryToArray = userEntry.Split(",");
                ReverseArray(userEntryToArray);
                Console.WriteLine("Enter another array or type \"exit\" to quit.");
                userEntry = Console.ReadLine();
            }
        }

        static string[] ReverseArray(string[] arr)
        {
            string[] reverse = new string[arr.Length];
            string printArray = "";
            for (int i=0; i<arr.Length; i++)
            {
                reverse[i] = arr[arr.Length - 1 - i];
                if (i != arr.Length - 1)
                {
                    printArray += reverse[i] + ",";
                } else
                {
                    printArray += reverse[i];
                }
                
            }
            Console.WriteLine(printArray);
            return reverse;
        }
    }
}
