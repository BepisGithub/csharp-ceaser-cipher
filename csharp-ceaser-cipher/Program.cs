using System;

namespace csharp_ceaser_cipher
{
    class Program
    {

        static string CeaserCipher(string input, int shift)
        {
            char[] InputArray = input.ToCharArray();
            for(int i = 0; i < InputArray.Length; i++)
            {

            }
            return InputArray.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CeaserCipher("hello",5));
        }
    }
}
