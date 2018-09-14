using EnigmaProject.Contracts;
using EnigmaProject.Helpers;
using System;

namespace EnigmaProject
{
    public class SubstitutionCipher : ICipher
    {
        private char[] mapping;

        public SubstitutionCipher(char[] substitutionMap)
        {
            if(substitutionMap == null)
                throw new ArgumentNullException(nameof(substitutionMap));
            if (substitutionMap.Length != 26)
                    throw new ArgumentException("Substitution map must include 26 letters");

            mapping = substitutionMap;
        }

        public char Encipher(char input)
        {
            return mapping[EnigmaHelper.GetInt(input)];            
        }
    }
}
