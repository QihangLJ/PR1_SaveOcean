using UtilityClasses;

namespace TestProject
{
    [TestClass]
    public class UtilityTests
    {
        [TestMethod]
        public void CheckIntInput_ValueInsideRange_ReturnsTrue()
        {
            //Arrange
            int value = 5, min = 0, max = 10;

            //Act
            bool result = Utility.CheckIntInput(value, min, max);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIntInput_ValueBelowMin_ReturnsFalse()
        {
            //Arrange
            int value = -1, min = 0 ,max = 10;

            //Act
            bool result = Utility.CheckIntInput(value, min, max);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIntInput_ValueAboveMax_ReturnsFalse()
        {
            //Arrange
            int value = 15, min = 0, max = 10;

            //Act
            bool result = Utility.CheckIntInput(value, min, max);

            //Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void CheckIntInput_ValueEqualsMin_ReturnsTrue()
        {
            //Arrange
            int value = 0, min = 0, max = 10;

            //Act
            bool result = Utility.CheckIntInput(value, min, max);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckIntInput_ValueEqualsMax_ReturnsTrue()
        {
            //Arrange
            int value = 10, min = 0, max = 10;

            //Act
            bool result = Utility.CheckIntInput(value, min, max);

            //Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void RegisterDate_AnotherDaysDate_ReturnsNotEquals()
        {
            //Arrange
            string today = "31/12/2024";

            //Act
            string result = Utility.RegisterDate();

            //Assert
            Assert.AreNotEqual(today, result);
        }

        [TestMethod]
        public void RegisterDate_DateFormat_ResultTrue()
        {
            //Arrange

            //Act
            string result = Utility.RegisterDate();

            //Assert
            Assert.IsTrue(result.Length == 10);
        }

        [TestMethod]
        public void RandomAffectationGrade_ValueIsInsideTheRange_ReturnsTrue()
        {
            // Act
            int result = Utility.RandomAffectationGrade();

            // Assert
            Assert.IsTrue(result >= 1 && result <= 100);
        }
    }
}