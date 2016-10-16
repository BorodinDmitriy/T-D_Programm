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
        public void SquareCalculate_InvalidWidthToCalculate_Less()
        {
            int correctanswer = -1;
            int x = 2;
            int y = 5;
            int h = 10;
            int w = 10;
            int invalid_w1 = -1;
            int num = 1;
            int[,] matrix = new int[w, h];
            for (int I = 0; I < w; I++)
                for (int J = 0; J < h; J++)
                    if (I == 5 && J == 5)
                        matrix[I, J] = 1;
                    else
                        matrix[I, J] = 0;
            ProgramImage item = new ProgramImage();
            Assert.AreEqual(item.SquareCalculate(x, y, num, matrix, h, invalid_w1), correctanswer);
        }

        [Test]
        public void SquareCalculate_InvalidWidthToCalculate_Above()
        {
            int correctanswer = -2;
            int x = 2;
            int y = 5;
            int h = 10;
            int w = 10;
            int invalid_w1 = w+2;
            int num = 1;
            int[,] matrix = new int[w, h];
            for (int I = 0; I < w; I++)
                for (int J = 0; J < h; J++)
                    if (I == 5 && J == 5)
                        matrix[I, J] = 1;
                    else
                        matrix[I, J] = 0;
            ProgramImage item = new ProgramImage();
            Assert.AreEqual(item.SquareCalculate(x, y, num, matrix, h, invalid_w1), correctanswer);
        }

        [Test]
        public void SquareCalculate_InvalidHeightToCalculate_Less()
        {
            int correctanswer = -1;
            int x = 2;
            int y = 5;
            int h = 10;
            int w = 10;
            int invalid_h = -1;
            int num = 1;
            int[,] matrix = new int[w, h];
            for (int I = 0; I < w; I++)
                for (int J = 0; J < h; J++)
                    if (I == 5 && J == 5)
                        matrix[I, J] = 1;
                    else
                        matrix[I, J] = 0;
            ProgramImage item = new ProgramImage();
            Assert.AreEqual(item.SquareCalculate(x, y, num, matrix, invalid_h, w), correctanswer);
        }

        [Test]
        public void SquareCalculate_InvalidHeightToCalculate_Above()
        {
            int correctanswer = -2;
            int x = 2;
            int y = 5;
            int h = 10;
            int w = 10;
            int invalid_h = 12;
            int num = 1;
            int[,] matrix = new int[w, h];
            for (int I = 0; I < w; I++)
                for (int J = 0; J < h; J++)
                    if (I == 5 && J == 5)
                        matrix[I, J] = 1;
                    else
                        matrix[I, J] = 0;
            ProgramImage item = new ProgramImage();
            Assert.AreEqual(item.SquareCalculate(x, y, num, matrix, invalid_h, w), correctanswer);
        }

        [Test]
        public void SquareCalculate_InvalidStartPointToCalculate_Less()
        {
            int correctanswer = 0;
            int x1 = -1;
            int y1 = 0;
            int x2 = -1;
            int y2 = -1;
            int x3 = 0;
            int y3 = -1;
            int x4 = -1;
            int y4 = -1;
            int h = 10;
            int w = 10;
            int num = 1;
            int[,] matrix = new int[w, h];
            for (int I = 0; I < w; I++)
                for (int J = 0; J < h; J++)
                    if (I == 5 && J == 5)
                        matrix[I, J] = 1;
                    else
                        matrix[I, J] = 0;
            ProgramImage item = new ProgramImage();
            Assert.AreEqual(item.SquareCalculate(x1, y1, num, matrix, h, w), correctanswer);
            Assert.AreEqual(item.SquareCalculate(x2, y2, num, matrix, h, w), correctanswer);
            Assert.AreEqual(item.SquareCalculate(x3, y3, num, matrix, h, w), correctanswer);
            Assert.AreEqual(item.SquareCalculate(x4, y4, num, matrix, h, w), correctanswer);
        }

    }
}