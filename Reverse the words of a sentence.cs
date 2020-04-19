using System;
using System.Collections.Generic;
namespace App1
{
    class Program
    {
        static void Main()
        {
            {
                Console.WriteLine("By Denis Rafi");
                Console.WriteLine("-----------------");
                string line = "Thank You Everyone for Your Support ♥.";
                Console.WriteLine("\nOriginal String: " + line);
                Console.WriteLine("--------------------------------------------------------");
                string result = "";
                List<string> wordsList = new List<string>();
                string[] words = line.Split(new[]
                {
                    " "
                }, StringSplitOptions.None);
                for (int i = words.Length - 1; i >= 0; i--)
                {
                    result += words[i] + " ";
                }
                wordsList.Add(result);
                foreach (String s in wordsList)
                {

                    Console.WriteLine("\nReverse String: " + s);
                    Console.WriteLine("--------------------------------------------------------");
                    Console.ReadKey();
                }
            }
        }
    }
}
