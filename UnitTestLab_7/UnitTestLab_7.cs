using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Lab_7;

namespace UnitTestLab_7
{
    [TestClass]
    public class UnitTestLab_7
    {
        [TestMethod]
        public void SumTestVector()
        {
            //arrange
            Program.Vector v1 = new Program.Vector(10, 20, 30);
            Program.Vector v2 = new Program.Vector(5, 7, 9);

            Program.Vector expected = new Program.Vector(16, 27, 39);
            //act
            Program.Vector actual = v1 + v2;

            //assert

            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
        [TestMethod()]
        public void MultTestVector()
        {
            //arrange
            Program.Vector v1 = new Program.Vector(10, 20, 30);
            Program.Vector v2 = new Program.Vector(5, 7, 9);

            int expected = 460;
            //act
            int actual = v1 * v2;

            //assert

            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void SumTestMultiMember()
        {
            //arrange
            double[] Matrix = { 1, 2, 3 };
            double[] Matrix2 = { 4, 5, 6 };
            Program.MultiMember A = new Program.MultiMember(Matrix, 2);
            Program.MultiMember B = new Program.MultiMember(Matrix2, 2);
            double[] Matrix3 = { 5, 7, 9 };
            Program.MultiMember expected = new Program.MultiMember(Matrix3, 2); ;
            //act
            Program.MultiMember actual = A + B;

            //assert

            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod()]
        public void SubTestMultiMember()
        {
            //arrange
            double[] Matrix = { 1, 2, 3 };
            double[] Matrix2 = { 4, 5, 6 };
            Program.MultiMember A = new Program.MultiMember(Matrix, 2);
            Program.MultiMember B = new Program.MultiMember(Matrix2, 2);
            double[] Matrix3 = { -3, -3, -3 };
            Program.MultiMember expected = new Program.MultiMember(Matrix3, 2); ;
            //act
            Program.MultiMember actual = A - B;

            //assert

            Assert.AreEqual(expected.ToString(), actual.ToString());
        }

        [TestMethod()]
        public void MultTestMultiMember()
        {
            //arrange
            double[] Matrix = { 1, 2, 3 };
            double[] Matrix2 = { 4, 5, 6 };
            Program.MultiMember A = new Program.MultiMember(Matrix, 2);
            Program.MultiMember B = new Program.MultiMember(Matrix2, 2);
            double[] Matrix3 = { 4, 10, 18 };
            Program.MultiMember expected = new Program.MultiMember(Matrix3, 2); ;
            //act
            Program.MultiMember actual = A * B;

            //assert

            Assert.AreEqual(expected.ToString(), actual.ToString());
        }
    }
}
