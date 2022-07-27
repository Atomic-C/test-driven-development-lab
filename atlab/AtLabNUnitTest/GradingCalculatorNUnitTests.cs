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
        public void Score95AndAttendance90_ReturnA()
        {
            {
                // Arrange
                //GradingCalculator Calculator = new GradingCalculator(); // Because we instantiate on Setup()
                // Act
                int scoreResult = gradingCalculator.Score = 95;
                int attendanceResult = gradingCalculator.AttendancePercentage = 90;
                string gradeResult = gradingCalculator.GetGrade();
                // Assert
                Assert.That(gradeResult, Is.EqualTo("A"));
            }

        }

        [Test]
        public void Score85AndAttendance90_ReturbB()
        {
            // Arrange
            //GradingCalculator Calculator = new GradingCalculator(); // Because we instantiate on Setup()
            // Act
            int scoreResult = gradingCalculator.Score = 85;
            int attendanceResult = gradingCalculator.AttendancePercentage = 90;
            string gradeResult = gradingCalculator.GetGrade();
            // Assert
            Assert.That(gradeResult, Is.EqualTo("B"));
        }

        [Test]
        public void Score65AndAttendance90_ReturnC()
        {
            // Arrange
            //GradingCalculator Calculator = new GradingCalculator(); // Because we instantiate on Setup()
            // Act
            int scoreResult = gradingCalculator.Score = 65;
            int attendanceResult = gradingCalculator.AttendancePercentage = 90;
            string gradeResult = gradingCalculator.GetGrade();
            // Assert
            Assert.That(gradeResult, Is.EqualTo("C"));
        }

        [Test]
        public void Score95AndAttendance65_ReturnB()
        {
            // Arrange
            //GradingCalculator Calculator = new GradingCalculator(); // Because we instantiate on Setup()
            // Act
            int scoreResult = gradingCalculator.Score = 95;
            int attendanceResult = gradingCalculator.AttendancePercentage = 65;
            string gradeResult = gradingCalculator.GetGrade();
            // Assert
            Assert.That(gradeResult, Is.EqualTo("B"));
        }

        [Test]
        [TestCase(95,55)]
        [TestCase(65,55)]
        [TestCase(50,90)]
        public void Score95_65_50_Attendance55_55_90_ReturnF(int score, int attendanceScore)
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
