using EnigmaProject;
using NUnit.Framework;

namespace Tests
{
    [TestFixture]
    public class ShiftCipherTests
    {
        private ShiftCipher sut;

        [Test]
        public void Test_Cipher_With_0_Shift()
        {
            sut = new ShiftCipher(0);
            Assert.AreEqual('A', sut.Encipher('A'));
            Assert.AreEqual('M', sut.Encipher('M'));
            Assert.AreEqual('Z', sut.Encipher('Z'));
        }

        [Test]
        public void Test_Cipher_With_1_Shift()
        {
            sut = new ShiftCipher(1);
            Assert.AreEqual('B', sut.Encipher('A'));
            Assert.AreEqual('K', sut.Encipher('J'));
            Assert.AreEqual('A', sut.Encipher('Z'));
        }


        [Test]
        public void Test_Cipher_With_Negative_1_Shift()
        {
            sut = new ShiftCipher(-1);
            Assert.AreEqual('Z', sut.Encipher('A'));
            Assert.AreEqual('P', sut.Encipher('Q'));
            Assert.AreEqual('Y', sut.Encipher('Z'));
        }

        [Test]
        public void Test_Cipher_With_Negative_26_Shift()
        {
            // Cipher of -26 is a 0 Cipher
            sut = new ShiftCipher(-26);
            Assert.AreEqual('A', sut.Encipher('A'));
            Assert.AreEqual('E', sut.Encipher('E'));
            Assert.AreEqual('T', sut.Encipher('T'));
        }

        [Test]
        public void Test_Cipher_With_Negative_15_Shift()
        {
            // Cipher of -15 is a +11 Cipher
            sut = new ShiftCipher(-15);
            Assert.AreEqual('L', sut.Encipher('A'));
            Assert.AreEqual('P', sut.Encipher('E'));
            Assert.AreEqual('E', sut.Encipher('T'));
        }

        [Test]
        public void Test_Cipher_With_Negative_64_Shift()
        {
            // Cipher of -64 is a -12 Cipher is a +14 Cipher
            sut = new ShiftCipher(-64);
            Assert.AreEqual('O', sut.Encipher('A'));
            Assert.AreEqual('S', sut.Encipher('E'));
            Assert.AreEqual('H', sut.Encipher('T'));
        }

        [Test]
        public void Test_Cipher_With_26_Shift()
        {
            // Cipher of 26 is a 0 Cipher
            sut = new ShiftCipher(26);
            Assert.AreEqual('A', sut.Encipher('A'));
            Assert.AreEqual('E', sut.Encipher('E'));
            Assert.AreEqual('T', sut.Encipher('T'));
        }

        [Test]
        public void Test_Cipher_With_11_Shift()
        {
            sut = new ShiftCipher(11);
            Assert.AreEqual('L', sut.Encipher('A'));
            Assert.AreEqual('A', sut.Encipher('P'));
            Assert.AreEqual('K', sut.Encipher('Z'));
        }

        [Test]
        public void Test_Cipher_With_73_Shift()
        {
            // Cipher of 73 is a +21 Cipher
            sut = new ShiftCipher(73);
            Assert.AreEqual('V', sut.Encipher('A'));
            Assert.AreEqual('B', sut.Encipher('G'));
            Assert.AreEqual('S', sut.Encipher('X'));
        }
    }
}
