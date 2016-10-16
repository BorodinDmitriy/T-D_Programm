﻿using System.ComponentModel;
using NUnit.Framework;
using SOFTWARE_TESTING_AND_DEBUGGING_C_SHARP;

namespace SOFTWARE_TESTING_AND_DEBUGGING_C_SHARP.UnitTests
{
    [TestFixture]
    public class ProgrammImage_NUnitTests
    {
        [Test]
        public void SquareCalculate_CorrectCalculate()
        {
            int correctanswer = 99;
            ProgramImage item = new ProgramImage();
            int x = 2;
            int y = 2;
            int num = 1;
            int h = 10;
            int w = 10;
            int[,] matrix = new int[w, h];
            for (int I = 0; I < w; I++)
                for (int J = 0; J < h; J++)
                    if (I == 5 && J == 5)
                        matrix[I, J] = 1;
                    else
                        matrix[I, J] = 0;
            Assert.AreEqual(item.SquareCalculate(x, y, num, matrix, h, w), correctanswer);
        }

        [Test]
        public void SquareCalculate_AnCorrectNumFromArguments()
        {
            int correctanswer = 1;
            ProgramImage item = new ProgramImage();
        }
    }
}
