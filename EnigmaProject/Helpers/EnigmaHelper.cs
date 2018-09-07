
namespace EnigmaProject.Helpers
{
    public class EnigmaHelper
    {
        public static int GetInt(char input)
        {
            var intValue = (int)input;
            return intValue - 65;
        }

        public static char GetChar(int input)
        {
            input = input + 65;
            return (char)input;
        }
    }
}
