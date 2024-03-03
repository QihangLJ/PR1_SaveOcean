using System.Collections.Generic;
using ObjectClasses;

namespace TestProject
{
    [TestClass]
    public class ObjectTests
    {

        //RESCUE OBJECT TESTS

        [TestMethod]
        public void RescueConstructor_WithAllTheAttributes_UserValues()
        {
            //Arrange
            string code = "RES001";
            string date = "01/01/2024";
            AAnimal family = new SeaTurtle();
            int affectationGrade = 50;
            string location = "Barcelona";

            //Act
            Rescue rescue = new Rescue(code, date, family, affectationGrade, location);

            //Assert
            Assert.AreEqual(code, rescue.Code);
            Assert.AreEqual(date, rescue.Date);
            Assert.AreEqual(family, rescue.Family);
            Assert.AreEqual(affectationGrade, rescue.AffectationGrade);
            Assert.AreEqual(location, rescue.Location);
        }

        [TestMethod]
        public void RescueConstructor_WithOnlyFamily_DefaultValues()
        {
            //Arrange
            AAnimal family = new SeaTurtle();

            //Act
            Rescue rescue = new Rescue(family);

            //Assert
            Assert.AreEqual("", rescue.Code);
            Assert.AreEqual("", rescue.Date);
            Assert.AreEqual(family, rescue.Family);
            Assert.AreEqual(0, rescue.AffectationGrade);
            Assert.AreEqual("", rescue.Location);
        }

        [TestMethod]
        public void GenerateCode_NumberInRange_ResultTrue()
        {
            //Arrange

            //Act
            string result = Rescue.GenerateCode();
            string numberString = result.Substring(3);
            int numbers = Convert.ToInt32(numberString);

            //Assert
            Assert.IsTrue(numbers >= 1 && numbers <= 999);
        }

        [TestMethod]
        public void GenerateCode_StartWithRES_ResultTrue()
        {
            //Arrange

            //Act
            string result = Rescue.GenerateCode();

            //Assert
            Assert.IsTrue(result.StartsWith("RES"));
        }

        [TestMethod]
        public void ToString_ReturnsCorrectly()
        {
            //Arrange
            AAnimal family = new SeaTurtle("Turtle", "Sea Turtle", "Caretta", 10);
            Rescue rescue = new Rescue("RES001", "01/01/2024", family, 50, "Barcelona");

            //Act
            string result = rescue.ToString();

            //Assert
            Assert.AreEqual("+-------------------------------------------------------------+\r\n" +
                            "|                           RESCUE                            |\r\n" +
                            "+-------------------------------------------------------------+\r\n" +
                            "| # Rescue | Rescue Date | Super Family      | AG | Location  |\r\n" +
                            "+-------------------------------------------------------------+\r\n" +
                            "| RES001   | 01/01/2024  | Sea Turtle        | 50 | Barcelona |\r\n" +
                            "+-------------------------------------------------------------+", result);
        }


        //SEA TURTLE OBJECT TESTS

        [TestMethod]
        public void SeaTurtleConstructor_WithAllTheAttributes_UserValues()
        {
            //Arrange
            string name = "Turtle";
            string superFamily = "Sea Turtle";
            string species = "Caretta";
            float weight = 10;

            //Act
            SeaTurtle seaTurtle = new SeaTurtle(name, superFamily, species, weight);

            //Assert
            Assert.AreEqual(name, seaTurtle.Name);
            Assert.AreEqual(superFamily, seaTurtle.SuperFamily);
            Assert.AreEqual(species, seaTurtle.Species);
            Assert.AreEqual(weight, seaTurtle.Weight);
        }

        [TestMethod]
        public void SeaTurtleConstructor_WithNothing_DefaultValues()
        {
            //Arrange

            //Act
            SeaTurtle seaTurtle = new SeaTurtle();

            //Assert
            Assert.AreEqual("", seaTurtle.Name);
            Assert.AreEqual("", seaTurtle.SuperFamily);
            Assert.AreEqual("", seaTurtle.Species);
            Assert.AreEqual(0, seaTurtle.Weight);
        }

        [TestMethod]
        public void SeaTurtleTreatment_HealOption1_ResultEqual()
        {
            //Arrange
            SeaTurtle seaTurtle = new SeaTurtle();
            int affectation = 10;
            int option = 1;

            //Act
            int result = seaTurtle.Treatment(affectation, option);

            //Assert
            Assert.AreEqual(-179, result);
        }

        [TestMethod]
        public void SeaTurtleTreatment_HealOption2_ResultEqual()
        {
            //Arrange
            SeaTurtle seaTurtle = new SeaTurtle();
            int affectation = 10;
            int option = 2;

            //Act
            int result = seaTurtle.Treatment(affectation, option);

            //Assert
            Assert.AreEqual(-179, result);
        }

        [TestMethod]
        public void SeaTurtleToString_ReturnsCorrectly()
        {
            //Arrange
            SeaTurtle seaTurtle = new SeaTurtle("Turtle", "Sea Turtle", "Caretta", 10);

            //Act
            string result = seaTurtle.ToString();

            //Assert
            Assert.AreEqual("Sea Turtle", result);
        }

        [TestMethod]
        public void SeaTurtleGetDocument_ReturnsCorrectly()
        {
            //Arrange
            SeaTurtle seaTurtle = new SeaTurtle("Turtle", "Sea Turtle", "Caretta", 10);

            //Act
            string result = seaTurtle.GetDocument();

            //Assert
            Assert.AreEqual("+-------------------------------------------------------------+\r\n" +
                            "|                           DOCUMENT                          |\r\n" +
                            "+-------------------------------------------------------------+\r\n" +
                            "| # Name | Super Family       | Species        | Weigth       |\r\n" +
                            "+-------------------------------------------------------------+\r\n" +
                            "| Turtle  | Sea Turtle         | Caretta | 10kg        |\r\n" +
                            "+-------------------------------------------------------------+", result);
        }


        //SEA BIRD OBJECT TESTS

        [TestMethod]
        public void SeaBirdConstructor_WithAllTheAttributes_UserValues()
        {
            //Arrange
            string name = "Bird";
            string superFamily = "Sea Bird";
            string species = "Emperor Penguin";
            float weight = 10;

            //Act
            SeaBird seaBird = new SeaBird(name, superFamily, species, weight);

            //Assert
            Assert.AreEqual(name, seaBird.Name);
            Assert.AreEqual(superFamily, seaBird.SuperFamily);
            Assert.AreEqual(species, seaBird.Species);
            Assert.AreEqual(weight, seaBird.Weight);
        }

        [TestMethod]
        public void SeaBirdConstructor_WithNothing_DefaultValues()
        {
            //Arrange

            //Act
            SeaBird seaBird = new SeaBird();

            //Assert
            Assert.AreEqual("", seaBird.Name);
            Assert.AreEqual("", seaBird.SuperFamily);
            Assert.AreEqual("", seaBird.Species);
            Assert.AreEqual(0, seaBird.Weight);
        }

        [TestMethod]
        public void SeaBirdTreatment_HealOption1_ResultEqual()
        {
            //Arrange
            SeaBird seaBird = new SeaBird();
            int affectation = 10;
            int option = 1;

            //Act
            int result = seaBird.Treatment(affectation, option);

            //Assert
            Assert.AreEqual(-95, result);
        }

        [TestMethod]
        public void SeaBirdTreatment_HealOption2_ResultEqual()
        {
            //Arrange
            SeaBird seaBird = new SeaBird();
            int affectation = 10;
            int option = 2;

            //Act
            int result = seaBird.Treatment(affectation, option);

            //Assert
            Assert.AreEqual(-90, result);
        }

        [TestMethod]
        public void SeaBirdToString_ReturnsCorrectly()
        {
            //Arrange
            SeaBird seaBird = new SeaBird("Bird", "Sea Bird", "Emperor Penguin", 10);

            //Act
            string result = seaBird.ToString();

            //Assert
            Assert.AreEqual("Sea Bird", result);
        }

        [TestMethod]
        public void SeaBirdGetDocument_ReturnsCorrectly()
        {
            //Arrange
            SeaBird seaBird = new SeaBird("Bird", "Sea Bird", "Emperor Penguin", 10);

            //Act
            string result = seaBird.GetDocument();

            //Assert
            Assert.AreEqual("+-------------------------------------------------------------+\r\n" +
                            "|                           DOCUMENT                          |\r\n" +
                            "+-------------------------------------------------------------+\r\n" +
                            "| # Name | Super Family      | Species         | Weigth       |\r\n" +
                            "+-------------------------------------------------------------+\r\n" +
                            "| Bird  | Sea Bird        | Emperor Penguin | 10kg       |\r\n" +
                            "+-------------------------------------------------------------+", result);
        }

        //CETACEAN OBJECT TESTS

        [TestMethod]
        public void CetaceanConstructor_WithAllTheAttributes_UserValues()
        {
            //Arrange
            string name = "Dolphin";
            string superFamily = "Cetacean";
            string species = "Listed Dolphin";
            float weight = 50;

            //Act
            Cetacean cetacean = new Cetacean(name, superFamily, species, weight);

            //Assert
            Assert.AreEqual(name, cetacean.Name);
            Assert.AreEqual(superFamily, cetacean.SuperFamily);
            Assert.AreEqual(species, cetacean.Species);
            Assert.AreEqual(weight, cetacean.Weight);
        }

        [TestMethod]
        public void CetaceanConstructor_WithNothing_DefaultValues()
        {
            //Arrange

            //Act
            Cetacean cetacean = new Cetacean();

            //Assert
            Assert.AreEqual("", cetacean.Name);
            Assert.AreEqual("", cetacean.SuperFamily);
            Assert.AreEqual("", cetacean.Species);
            Assert.AreEqual(0, cetacean.Weight);
        }

        [TestMethod]
        public void CetaceanTreatment_HealOption1_ResultEqual()
        {
            //Arrange
            Cetacean cetacean = new Cetacean();
            int affectation = 10;
            int option = 1;

            //Act
            int result = cetacean.Treatment(affectation, option);

            //Assert
            Assert.AreEqual(-16, result);
        }

        [TestMethod]
        public void CetaceanTreatment_HealOption2_ResultEqual()
        {
            //Arrange
            Cetacean cetacean = new Cetacean();
            int affectation = 10;
            int option = 2;

            //Act
            int result = cetacean.Treatment(affectation, option);

            //Assert
            Assert.AreEqual(9, result);
        }

        [TestMethod]
        public void CetaceanToString_ReturnsCorrectly()
        {
            //Arrange
            Cetacean cetacean = new Cetacean("Dolphin", "Cetacean", "Listed Dolphin", 50);

            //Act
            string result = cetacean.ToString();

            //Assert
            Assert.AreEqual("Cetacean", result);
        }

        [TestMethod]
        public void CetaceanGetDocument_ReturnsCorrectly()
        {
            //Arrange
            Cetacean cetacean = new Cetacean("Dolphin", "Cetacean", "Listed Dolphin", 50);

            //Act
            string result = cetacean.GetDocument();

            //Assert
            Assert.AreEqual("+-------------------------------------------------------------+\r\n" +
                            "|                           DOCUMENT                          |\r\n" +
                            "+-------------------------------------------------------------+\r\n" +
                            "| # Name | Super Family      | Species         | Weigth       |\r\n" +
                            "+-------------------------------------------------------------+\r\n" +
                            "| Dolphin  | Cetacean        | Listed Dolphin  | 50kg       |\r\n" +
                            "+-------------------------------------------------------------+", result);
        }
    }
}
