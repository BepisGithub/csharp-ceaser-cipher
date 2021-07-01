﻿using System;

namespace csharp_ceaser_cipher
{
    class Program
    {

        static int SimplifyShift(int shift)
        {
            //checks if the shift is negative
            bool negative = shift < 0;
            shift = Math.Abs(shift);
            //it doesnt loop back around
            while(shift >= 26)
            {
                shift -= 26;
            }
            if (negative)
            {
                shift = 26 - shift;
            }
            return shift;
        }

        static string CeaserCipher(string input, int shift)
        {
            char[] InputArray = input.ToCharArray();
            shift = SimplifyShift(shift);
            for(int i = 0; i < InputArray.Length; i++)
            {
                //There needs to be a distinction between lowercase and uppercase letters
                char letter = InputArray[i];
                int letterCode = (int)letter;

            }
            return InputArray.ToString();
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CeaserCipher("hello",5));
        }
    }
}
