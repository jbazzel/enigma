using EnigmaProject.Rotors;
using NUnit.Framework;

namespace Tests.Rotors
{
    [TestFixture]
    public class Rotor1Tests
    {
        private Rotor1 sut;

        [SetUp]
        public void SetUp()
        {
            sut = new Rotor1();
        }

        [Test]
        public void Test_Setting_Is_A_By_Default()
        {
            Assert.AreEqual('A', sut.GetSetting());
        }

        [Test]
        public void Test_Setting_Get_And_Set_1()
        {
            sut.SetSetting('Y');
            Assert.AreEqual('Y', sut.GetSetting());
        }

        [Test]
        public void Test_Setting_Get_And_Set_2()
        {
            sut.SetSetting('F');
            Assert.AreEqual('F', sut.GetSetting());
        }

        [Test]
        public void Test_Setting_Get_And_Set_3()
        {
            sut.SetSetting('X');
            Assert.AreEqual('X', sut.GetSetting());
        }

        [Test]
        public void Test_One_Step()
        {
            sut.SetSetting('A');
            sut.Step();
            Assert.AreEqual('B', sut.GetSetting());
        }
        
        [Test]
        public void Test_Multiple_Steps()
        {
            sut.SetSetting('L');
            sut.Step();
            sut.Step();
            sut.Step();
            Assert.AreEqual('O', sut.GetSetting());
        }

        [Test]
        public void Test_Step_Goes_Back_To_A_After_Z()
        {
            sut.SetSetting('Z');
            sut.Step();
            Assert.AreEqual('A', sut.GetSetting());
        }

        [Test]
        public void Test_Cipher_On_A_Setting()
        {
            sut.SetSetting('A');

            Assert.AreEqual('E', sut.Encipher('A'));
            Assert.AreEqual('K', sut.Encipher('B'));
            Assert.AreEqual('M', sut.Encipher('C'));
            Assert.AreEqual('F', sut.Encipher('D'));
            Assert.AreEqual('L', sut.Encipher('E'));
            Assert.AreEqual('G', sut.Encipher('F'));
            Assert.AreEqual('D', sut.Encipher('G'));
            Assert.AreEqual('Q', sut.Encipher('H'));
            Assert.AreEqual('V', sut.Encipher('I'));
            Assert.AreEqual('Z', sut.Encipher('J'));
            Assert.AreEqual('N', sut.Encipher('K'));
            Assert.AreEqual('T', sut.Encipher('L'));
            Assert.AreEqual('O', sut.Encipher('M'));
            Assert.AreEqual('W', sut.Encipher('N'));
            Assert.AreEqual('Y', sut.Encipher('O'));
            Assert.AreEqual('H', sut.Encipher('P'));
            Assert.AreEqual('X', sut.Encipher('Q'));
            Assert.AreEqual('U', sut.Encipher('R'));
            Assert.AreEqual('S', sut.Encipher('S'));
            Assert.AreEqual('P', sut.Encipher('T'));
            Assert.AreEqual('A', sut.Encipher('U'));
            Assert.AreEqual('I', sut.Encipher('V'));
            Assert.AreEqual('B', sut.Encipher('W'));
            Assert.AreEqual('R', sut.Encipher('X'));
            Assert.AreEqual('C', sut.Encipher('Y'));
            Assert.AreEqual('J', sut.Encipher('Z'));
        }

        [Test]
        public void Test_Cipher_Across_Sequence_With_Initial_Setting_Y()
        {
            // Rotor is Set to Y
            // Input is "FARM", dial advances for each letter
            sut.SetSetting('Y');
            //Assert.AreEqual('A', sut.Ci());
            //sut.Step();
            //Assert.AreEqual('A', sut.GetSetting());
        }
    }
}
