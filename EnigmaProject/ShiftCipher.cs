using EnigmaProject.Contracts;
using EnigmaProject.Helpers;

namespace EnigmaProject
{
    public class ShiftCipher : ICipher
    {
        private int shift;
        private char[] alphabet = new char[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};

        public ShiftCipher(int cipherShift)
        {
            shift = GetSafeShift(cipherShift);
        }

        public char Encipher(char input)
        {
            var totalShift = GetTotalShift(EnigmaHelper.GetInt(input));
            return alphabet[totalShift];            
        }

        private int GetTotalShift(int inputShift)
        {
            return GetSafeShift(inputShift + shift);
        }

        private int GetSafeShift(int suggestedShift)
        {
            while (suggestedShift < 0)
                suggestedShift += 26;

            while (suggestedShift > 25)
                suggestedShift -= 26;

            return suggestedShift;
        }
    }
}
