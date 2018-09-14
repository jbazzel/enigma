using EnigmaProject;
using NUnit.Framework;
using System;

namespace Tests
{
    [TestFixture]
    public class SubstitutionCipherTests
    {
        SubstitutionCipher sut;

        private char[] testMapping = { 'O', 'R', 'M', 'S', 'F', 'Z', 'B', 'P', 'U', 'E', 'K', 'V', 'Y','A', 'L', 'Q', 'T', 'J', 'I', 'W', 'D', 'N', 'X', 'H', 'C', 'G'};

        [Test]
        public void Test_Constructor_Throws_Exception_When_Mapping_Is_Null()
        {
            char[] nullMapping = null;
            Assert.That(() => sut = new SubstitutionCipher(nullMapping), Throws.TypeOf<ArgumentNullException>());
        }

        [Test]
        public void Test_Constructor_Throws_Exception_When_Mapping_Is_Too_Small()
        {
            char[] mappingOf25Letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y' };
            Assert.That(() => sut = new SubstitutionCipher(mappingOf25Letters), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void Test_Constructor_Throws_Exception_When_Mapping_Is_Too_Large()
        {
            char[] mappingOf27Letters = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z', 'A' };
            Assert.That(() => sut = new SubstitutionCipher(mappingOf27Letters), Throws.TypeOf<ArgumentException>());
        }

        [Test]
        public void Test_Encipher()
        {
            sut = new SubstitutionCipher(testMapping);

            Assert.AreEqual('O', sut.Encipher('A'));
            Assert.AreEqual('R', sut.Encipher('B'));
            Assert.AreEqual('M', sut.Encipher('C'));
            Assert.AreEqual('S', sut.Encipher('D'));
            Assert.AreEqual('F', sut.Encipher('E'));
            Assert.AreEqual('Z', sut.Encipher('F'));
            Assert.AreEqual('B', sut.Encipher('G'));
            Assert.AreEqual('P', sut.Encipher('H'));
            Assert.AreEqual('U', sut.Encipher('I'));
            Assert.AreEqual('E', sut.Encipher('J'));
            Assert.AreEqual('K', sut.Encipher('K'));
            Assert.AreEqual('V', sut.Encipher('L'));
            Assert.AreEqual('Y', sut.Encipher('M'));
            Assert.AreEqual('A', sut.Encipher('N'));
            Assert.AreEqual('L', sut.Encipher('O'));
            Assert.AreEqual('Q', sut.Encipher('P'));
            Assert.AreEqual('T', sut.Encipher('Q'));
            Assert.AreEqual('J', sut.Encipher('R'));
            Assert.AreEqual('I', sut.Encipher('S'));
            Assert.AreEqual('W', sut.Encipher('T'));
            Assert.AreEqual('D', sut.Encipher('U'));
            Assert.AreEqual('N', sut.Encipher('V'));
            Assert.AreEqual('X', sut.Encipher('W'));
            Assert.AreEqual('H', sut.Encipher('X'));
            Assert.AreEqual('C', sut.Encipher('Y'));
            Assert.AreEqual('G', sut.Encipher('Z'));
        }
    }
}
