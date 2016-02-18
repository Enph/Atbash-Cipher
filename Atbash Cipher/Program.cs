using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atbash_Cipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Encrypt:");
            string plainText = Console.ReadLine();
            StringBuilder encryptedMSG = inputToCipher(plainText);
            Console.WriteLine("Encrypted: " + "{0}",encryptedMSG);
            Console.ReadLine();


        }
        public static StringBuilder inputToCipher(string text)
        {
            string cipher = "ZYXWVUTSRQPONMLKJIHGFEDCBA";
            System.Text.StringBuilder encrypted = new System.Text.StringBuilder();
            int PlainTextSize = text.Length;

            for(int i=0;i<PlainTextSize;i++)
            {
                if (char.IsLetter(text[i])) //check if text starts with a symbol or not
                {
                    for (int j = cipher.Length-1; j >=0; j--) // checks which position the text char matches in the cipher
                    {
                        int num = 26 - j;
                        if (text[i] == cipher[num-1])
                        {
                            encrypted.Append(cipher[j]); //adds the cipher char to the encrypted appended msg
                        }
                        else
                        {
                            //do nothing
                        }
                    }
                }
                else
                {
                    encrypted.Append(text[i]);
                }
            }

            return encrypted;
        }           
    }
}
