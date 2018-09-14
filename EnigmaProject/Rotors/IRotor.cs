
using EnigmaProject.Contracts;

namespace EnigmaProject.Rotors
{
    interface IRotor : ICipher
    {
        char GetDialSetting();
        void SetDialSetting(char setting);
        void Step();
    }
}
