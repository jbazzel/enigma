using EnigmaProject.Helpers;

namespace EnigmaProject.Rotors
{
    public class Rotor1 : IRotor
    {
        private int offset = 0;
        private char[] mapping;

        public Rotor1()
        {
            this.mapping = new char[] { 'E', 'K', 'M', 'F', 'L', 'G', 'D', 'Q', 'V', 'Z', 'N', 'T', 'O', 'W', 'Y', 'H', 'X', 'U', 'S', 'P', 'A', 'I', 'B', 'R', 'C', 'J' };
        }

        public char Encipher(char input)
        {
            var inputInt = EnigmaHelper.GetInt(input);
            var totalOffset = inputInt + offset;
            totalOffset = totalOffset % 26;
            return this.mapping[totalOffset];
        }

        public char GetSetting()
        {
            return EnigmaHelper.GetChar(offset);
        }

        public void SetSetting(char setting)
        {
            offset = EnigmaHelper.GetInt(setting);
        }

        public void Step()
        {
            offset += 1;

            if (offset > 25)
                offset = 0;
        }

        private char InnerEncipher(char input)
        {
            var inputInt = EnigmaHelper.GetInt(input);
            var totalOffset = inputInt + offset;
            totalOffset = totalOffset % 25;
            return this.mapping[totalOffset];
        }
    }
}
