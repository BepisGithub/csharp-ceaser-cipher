using System;

namespace csharp_ceaser_cipher
{
    class Program
    {

        static string CeaserCipher(string input, int shift)
        {
            char[] InputArray = input.ToCharArray();
            
            return InputArray.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CeaserCipher("hello",5));
        }
    }
}
