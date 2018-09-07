
namespace EnigmaProject.Rotors
{
    interface IRotor : ICipher
    {
        char GetSetting();
        void SetSetting(char setting);
        void Step();
    }
}
