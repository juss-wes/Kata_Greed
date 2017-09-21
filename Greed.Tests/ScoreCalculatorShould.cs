using System.Collections.Generic;
using Greed.Logic;
using Greed.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Greed.Tests
{
    [TestClass]
    public class ScoreCalculatorShould
    {
        [TestMethod]
        public void Return2100Given111515()
        {
            // Arrange
            var calculator = new ScoreCalculator();
            var diceRolls = new List<Roll>() { new Roll(1), new Roll(1), new Roll(1), new Roll(5), new Roll(1), new Roll(5) };

            // Act
            var score = calculator.Calculate(diceRolls);

            // Assert
            Assert.IsTrue(score == 2100);
        }

        [TestMethod]
        public void Return0Given23462()
        {
            // Arrange
            var calculator = new ScoreCalculator();
            var diceRolls = new List<Roll>() { new Roll(2), new Roll(3), new Roll(4), new Roll(6), new Roll(2) };

            // Act
            var score = calculator.Calculate(diceRolls);

            // Assert
            Assert.IsTrue(score == 0);
        }

        [TestMethod]
        public void Return350Given34533()
        {
            // Arrange
            var calculator = new ScoreCalculator();
            var diceRolls = new List<Roll>() { new Roll(3), new Roll(4), new Roll(5), new Roll(3), new Roll(3) };

            // Act
            var score = calculator.Calculate(diceRolls);

            // Assert
            Assert.IsTrue(score == 350);
        }

        [TestMethod]
        public void Return800Given333131()
        {
            // Arrange
            var calculator = new ScoreCalculator();
            var diceRolls = new List<Roll>() { new Roll(3), new Roll(3), new Roll(3), new Roll(1), new Roll(3), new Roll(1) };

            // Act
            var score = calculator.Calculate(diceRolls);

            // Assert
            Assert.IsTrue(score == 800);
        }

        [TestMethod]
        public void Return500Given333222()
        {
            // Arrange
            var calculator = new ScoreCalculator();
            var diceRolls = new List<Roll>() { new Roll(3), new Roll(3), new Roll(3), new Roll(2), new Roll(2), new Roll(2) };

            // Act
            var score = calculator.Calculate(diceRolls);

            // Assert
            Assert.IsTrue(score == 500);
        }
    }
}
