using EnigmaProject.Helpers;

namespace EnigmaProject.Rotors
{
    public class Rotor1 : IRotor
    {
        private int pinSetting = 0;
        private char dialSetting;
        private char[] rotorMapping;

        private ShiftCipher shiftCipher1;
        private SubstitutionCipher substitutionCipher;
        private ShiftCipher shiftCipher2;

        public Rotor1(int pinSetting, char dialSetting)
        {
            this.pinSetting = pinSetting;
            this.dialSetting = dialSetting;
            this.rotorMapping = new char[]{'E', 'K', 'M', 'F', 'L', 'G', 'D', 'Q', 'V', 'Z', 'N', 'T', 'O', 'W', 'Y', 'H', 'X', 'U', 'S', 'P', 'A', 'I', 'B', 'R', 'C', 'J' };

            InitializeRotor();
        }

        public char Encipher(char input)
        {
            var encodedChar = shiftCipher1.Encipher(input);
            encodedChar = substitutionCipher.Encipher(encodedChar);
            return shiftCipher2.Encipher(encodedChar);
        }

        public char GetDialSetting()
        {
            return dialSetting;
        }

        public void SetDialSetting(char setting)
        {
            dialSetting = setting;
            InitializeRotor();
        }

        public void Step()
        {
            var dialSettingInt = EnigmaHelper.GetInt(dialSetting);
            dialSettingInt++;
            SetDialSetting(EnigmaHelper.GetCharCyclic(dialSettingInt));            
        }

        private void InitializeRotor()
        {
            var dialSettingInt = EnigmaHelper.GetInt(dialSetting);

            shiftCipher1 = new ShiftCipher(dialSettingInt - pinSetting);
            shiftCipher2 = new ShiftCipher(dialSettingInt);
            substitutionCipher = new SubstitutionCipher(this.rotorMapping);
        }
    }
}
