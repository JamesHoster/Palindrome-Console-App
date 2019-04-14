using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Palindrome
    {
        public bool IsPalindrome(string userInput)
        {
            
                char[] chArray = userInput.ToCharArray();

                string forward = userInput.Substring(0, userInput.Length / 2);
                // char[] chArray = msg.ToCharArray();

                Array.Reverse(chArray);

                string temp = new string(chArray);
                string backward = temp.Substring(0, temp.Length / 2);

                /*
                     char[] forward = chArray;

                      Array.Reverse(chArray);

                     char[] backward = chArray;
                     */
                if (forward == backward)
                {
                    Console.WriteLine($"{userInput} is a Palindrome");
                    return true;
                }
                else
                {
                    Console.WriteLine($"{userInput} is NOT a Palindrome");
                    return false;
                }

         
            
        }
    }
}
