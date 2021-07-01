using System;

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

        static string CeaserCipher(string Input, int Shift)
        {
            char[] InputArray = Input.ToCharArray();
            Shift = SimplifyShift(Shift);
            for(int i = 0; i < InputArray.Length; i++)
            {
                //There needs to be a distinction between lowercase and uppercase letters
                char Letter = InputArray[i];
                int LetterCode = (int)Letter;
                //This if else statement changes the value of the letter code
                if (LetterCode >= 65 && LetterCode <= 90) //It's a capital letter
                {
                    if ((LetterCode + Shift) > 90) {
                        LetterCode = ((LetterCode + Shift) - 90) + 64;
                    }
                    else
                    {
                        LetterCode += Shift;
                    }
                }
                else if (LetterCode >= 97 && LetterCode <= 122) //It's a lowercase letter
                {
                    if ((LetterCode + Shift) > 122)
                    {
                        LetterCode = ((LetterCode + Shift) - 122) + 96;
                    }
                    else
                    {
                        LetterCode += Shift;
                    }
                }
                InputArray[i] = (char)LetterCode;
            }
            return new String(InputArray);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(CeaserCipher("Hello, World!",-1));
        }
    }
}
