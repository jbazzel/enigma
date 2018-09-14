
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
        
        // TODO: Needs Tests
        public static char GetCharCyclic(int input)
        {
            input = input % 26;
            if (input < 0)
                input += 26;

            return GetChar(input);
        }
    }
}
