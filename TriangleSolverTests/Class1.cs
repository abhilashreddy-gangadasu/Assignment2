using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Legacy;
using TriangleSolver;

namespace TriangleSolverTests
{
    public class Class1
    {

        [TestFixture]
        public class TriangleSolverTests
        {
            [Test]
            public void AnalyzeTriangle_ValidEquilateralTriangle_ReturnsEquilateralTriangle()
            {
                // Arrange
                int side1 = 5;
                int side2 = 5;
                int side3 = 5;
                string expected = "Equilateral triangle";

                // Act
                string result = Triangle.AnalyzeTriangle(side1, side2, side3);

                // Assert
                ClassicAssert.AreEqual(expected, result);
            }

            [Test]
            public void AnalyzeTriangle_ValidIsoscelesTriangle_FirstTwoSidesEqual_ReturnsIsoscelesTriangle()
            {
                // Arrange
                int side1 = 5;
                int side2 = 5;
                int side3 = 7;
                string expected = "Isosceles triangle";

                // Act
                string result = Triangle.AnalyzeTriangle(side1, side2, side3);

                // Assert
                ClassicAssert.AreEqual(expected, result);
            }

            [Test]
            public void AnalyzeTriangle_ValidIsoscelesTriangle_LastTwoSidesEqual_ReturnsIsoscelesTriangle()
            {
                // Arrange
                int side1 = 7;
                int side2 = 5;
                int side3 = 5;
                string expected = "Isosceles triangle";

                // Act
                string result = Triangle.AnalyzeTriangle(side1, side2, side3);

                // Assert
                ClassicAssert.AreEqual(expected, result);
            }

            [Test]
            public void AnalyzeTriangle_ValidIsoscelesTriangle_FirstAndLastSidesEqual_ReturnsIsoscelesTriangle()
            {
                // Arrange
                int side1 = 5;
                int side2 = 7;
                int side3 = 5;
                string expected = "Isosceles triangle";

                // Act
                string result = Triangle.AnalyzeTriangle(side1, side2, side3);

                // Assert
                ClassicAssert.AreEqual(expected, result);
            }
            [Test]
            public void AnalyzeTriangle_ValidScaleneTriangle_AllSidesDifferent_ReturnsScaleneTriangle()
            {
                // Arrange
                int side1 = 3;
                int side2 = 4;
                int side3 = 5;
                string expected = "Scalene triangle";

                // Act
                string result = Triangle.AnalyzeTriangle(side1, side2, side3);

                // Assert
                ClassicAssert.AreEqual(expected, result);
            }

            [Test]
            public void AnalyzeTriangle_ValidScaleneTriangle_LargeSides_ReturnsScaleneTriangle()
            {
                // Arrange
                int side1 = 100;
                int side2 = 101;
                int side3 = 102;
                string expected = "Scalene triangle";

                // Act
                string result = Triangle.AnalyzeTriangle(side1, side2, side3);

                // Assert
                ClassicAssert.AreEqual(expected, result);
            }

            [Test]
            public void AnalyzeTriangle_ValidScaleneTriangle_SmallSides_ReturnsScaleneTriangle()
            {
                // Arrange
                int side1 = 2;
                int side2 = 3;
                int side3 = 4;
                string expected = "Scalene triangle";

                // Act
                string result = Triangle.AnalyzeTriangle(side1, side2, side3);

                // Assert
                ClassicAssert.AreEqual(expected, result);
            }

            [Test]
            public void AnalyzeTriangle_ValidScaleneTriangle_OneSideMuchLarger_ReturnsScaleneTriangle()
            {
                // Arrange
                int side1 = 5;
                int side2 = 6;
                int side3 = 10;
                string expected = "Scalene triangle";

                // Act
                string result = Triangle.AnalyzeTriangle(side1, side2, side3);

                // Assert
                ClassicAssert.AreEqual(expected, result);
            }

            [Test]
            public void AnalyzeTriangle_ValidScaleneTriangle_AllOddSides_ReturnsScaleneTriangle()
            {
                // Arrange
                int side1 = 7;
                int side2 = 9;
                int side3 = 11;
                string expected = "Scalene triangle";

                // Act
                string result = Triangle.AnalyzeTriangle(side1, side2, side3);

                // Assert
                ClassicAssert.AreEqual(expected, result);
            }


        }
    }
}
