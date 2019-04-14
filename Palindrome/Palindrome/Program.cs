using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        public static void Main(string[] args)
        {
            string msg = "";
            try
            {
                do
                {
                    Console.Write("Is it a Palindrome? Enter your text to find out now! ");
                    msg = Console.ReadLine();
                    if(msg.Length >= 50)
                    {
                        throw new OverflowException();
                    }
                    //char[] chArray = msg.ToCharArray();

                    Palindrome myPal = new Palindrome();
                    myPal.IsPalindrome(msg);

                    Console.WriteLine("");
                    Console.ReadLine();
                } while (msg.ToUpper() != "EXIT");
            }
            catch (OverflowException)
            {
                Console.WriteLine("There is a maximum character length of 50.");
            }
        }
    }
 }   

