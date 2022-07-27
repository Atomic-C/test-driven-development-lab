using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atlab
{
    [TestFixture]
    public class GradingCalculatorNUnitTests
    {
        public GradingCalculator gradingCalculator;
        [SetUp]
        public void Setup() // This works like a constructor and exists to replace Arrange object instantiation.
        {
            gradingCalculator = new GradingCalculator();
        }

        [Test]
        public void GetGrade_Score95_Attendance90_ReturnGradeA()
        {
            {
                // Arrange
                //GradingCalculator Calculator = new GradingCalculator(); // Because we instantiate on Setup()
                // Act
                gradingCalculator.Score = 95;
                gradingCalculator.AttendancePercentage = 90;
                string gradeResult = gradingCalculator.GetGrade();
                // Assert
                Assert.That(gradeResult, Is.EqualTo("A"));
            }

        }

        [Test]
        public void GetGrade_Score85_Attendance90_ReturnGradeB()
        {
            // Arrange
            //GradingCalculator Calculator = new GradingCalculator(); // Because we instantiate on Setup()
            // Act
            gradingCalculator.Score = 85;
            gradingCalculator.AttendancePercentage = 90;
            string gradeResult = gradingCalculator.GetGrade();
            // Assert
            Assert.That(gradeResult, Is.EqualTo("B"));
        }

        [Test]
        public void GetGrade_Score65_Attendance90_ReturnGradeC()
        {
            // Arrange
            //GradingCalculator Calculator = new GradingCalculator(); // Because we instantiate on Setup()
            // Act
            gradingCalculator.Score = 65;
            gradingCalculator.AttendancePercentage = 90;
            string gradeResult = gradingCalculator.GetGrade();
            // Assert
            Assert.That(gradeResult, Is.EqualTo("C"));
        }

        [Test]
        public void GetGrade_Score95_Attendance65_ReturnGradeB()
        {
            // Arrange
            //GradingCalculator Calculator = new GradingCalculator(); // Because we instantiate on Setup()
            // Act
            gradingCalculator.Score = 95;
            gradingCalculator.AttendancePercentage = 65;
            string gradeResult = gradingCalculator.GetGrade();
            // Assert
            Assert.That(gradeResult, Is.EqualTo("B"));
        }

        [Test]
        [TestCase(95,55)]
        [TestCase(65,55)]
        [TestCase(50,90)]
        public void GetGrade_Score95_65_50_Attendance55_55_90_ReturnGradeF(int score, int attendanceScore)
        {
            // Arrange
            //GradingCalculator Calculator = new GradingCalculator(); // Because we instantiate on Setup()
            // Act
            int scoreResult = score;
            int attendanceResult = attendanceScore;
            string gradeResult = gradingCalculator.GetGrade();
            // Assert
            Assert.That(gradeResult, Is.EqualTo("F"));
        }
    }
}
