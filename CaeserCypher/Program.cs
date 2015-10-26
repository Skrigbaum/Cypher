using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaeserCypher
{
    class Program
    {
        static void Main(string[] args)
        {
            string cipherText = "";
            const int shift = 2;
            Console.WriteLine("Please input string: ");
            string message = Console.ReadLine();
            message = message.ToLower();
            int position = 0;
            char mychar = message.ElementAt(position);
            while (position < message.Length)
            {
                mychar = message.ElementAt(position);
                if (96 + shift < mychar && mychar <= 122)
                {
                    mychar = Convert.ToChar(mychar - shift);
                    cipherText = cipherText + mychar;
                    position++;
                }
                else if (mychar > 96 && mychar <= 96 + shift)
                {
                    mychar = Convert.ToChar(mychar + 26 - shift);
                    cipherText = cipherText + mychar;
                    position++;
                }
                else
                {
                    position++;
                }
                Console.WriteLine(cipherText);
                
            }
            Console.ReadKey();

        }
    }
}
