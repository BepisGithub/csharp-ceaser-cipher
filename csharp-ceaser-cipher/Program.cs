using System;

namespace csharp_ceaser_cipher
{
    class Program
    {

        static int SimplifyShift(int shift)
        {
            //it doesnt loop back around
            while(shift >= 26)
            {
                shift -= 26;
            }
            return shift;
        }

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
