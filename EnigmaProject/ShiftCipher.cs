using EnigmaProject.Contracts;
using EnigmaProject.Helpers;

namespace EnigmaProject
{
    public class ShiftCipher : ICipher
    {
        private int shift;
        //private char[] alphabet = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

        public ShiftCipher(int cipherShift)
        {
            shift = cipherShift;
        }

        public char Encipher(char input)
        {
            return EnigmaHelper.GetCharCyclic(EnigmaHelper.GetInt(input) + shift);
        }
    }
}
