// Write a program that encodes and decodes a string using given encryption key (cipher).
// The key consists of a sequence of characters.
// The encoding/decoding is done by performing XOR (exclusive or) operation
// over the first letter of the string with the first of the key, the second – with the second, etc.
// When the last key character is reached, the next is the first.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P7EncodeDecode
{
    class Program
    {
        static void Main()
        {
            Console.Write("Tell us the text we should encode: ");
            string text = Console.ReadLine();
            Console.Write("Tell us the encryption key (cipher): ");
            string cipher = Console.ReadLine();

            StringBuilder output = new StringBuilder();

            for (int i = 0; i < text.Length; i += cipher.Length)
            {
                for (int j = 0; j < cipher.Length && i + j < text.Length; j++)
                {
                    output.Append((char)(text[i + j] ^ cipher[j]));
                }
            }

            string finalOutput = output.ToString();

            StringBuilder decoded = new StringBuilder();

            for (int i = 0; i < finalOutput.Length; i += cipher.Length)
            {
                for (int j = 0; j < cipher.Length && i + j < finalOutput.Length; j++)
                {
                    decoded.Append((char)(finalOutput[i + j] ^ cipher[j]));
                }
            }
            string decodedOutput = decoded.ToString();


            Console.WriteLine("The encoded message is: {0}", finalOutput);
            Console.WriteLine("The decoded message is: {0}", decodedOutput);
        }
    }
}
