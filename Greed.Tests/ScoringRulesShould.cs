using System.Collections.Generic;
using Greed.Models;
using Greed.Rules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Greed.Tests
{
    [TestClass]
    public class ScoringRulesShould
    {
        [TestMethod]
        public void Return50GivenSingle5()
        {
            // Arrange
            var rule = new Rule_OfAKind(5, 1, 50);
            var diceRolls = new List<Roll>() { new Roll(1), new Roll(6), new Roll(4), new Roll(5) };

            // Act
            var score = rule.AddScore(diceRolls);

            // Assert
            Assert.IsTrue(score == 50);
        }

        [TestMethod]
        public void Return100GivenSingle1()
        {
            // Arrange
            var rule = new Rule_OfAKind(1, 1, 100);
            var diceRolls = new List<Roll>() { new Roll(1), new Roll(6), new Roll(4), new Roll(5) };

            // Act
            var score = rule.AddScore(diceRolls);

            // Assert
            Assert.IsTrue(score == 100);
        }

        [TestMethod]
        public void Return1000GivenTriple1()
        {
            // Arrange
            var rule = new Rule_OfAKind(1, 3, 1000);
            var diceRolls = new List<Roll>() { new Roll(1), new Roll(1), new Roll(1), new Roll(2) };

            // Act
            var score = rule.AddScore(diceRolls);

            // Assert
            Assert.IsTrue(score == 1000);
        }

        [TestMethod]
        public void Return200GivenTriple2()
        {
            // Arrange
            var rule = new Rule_OfAKind(2, 3, 200);
            var diceRolls = new List<Roll>() { new Roll(2), new Roll(6), new Roll(2), new Roll(2) };

            // Act
            var score = rule.AddScore(diceRolls);

            // Assert
            Assert.IsTrue(score == 200);
        }

        [TestMethod]
        public void Return300GivenTriple3()
        {
            // Arrange
            var rule = new Rule_OfAKind(3, 3, 300);
            var diceRolls = new List<Roll>() { new Roll(2), new Roll(3), new Roll(3), new Roll(3) };

            // Act
            var score = rule.AddScore(diceRolls);

            // Assert
            Assert.IsTrue(score == 300);
        }

        [TestMethod]
        public void Return400GivenTriple4()
        {
            // Arrange
            var rule = new Rule_OfAKind(4, 3, 400);
            var diceRolls = new List<Roll>() { new Roll(4), new Roll(4), new Roll(2), new Roll(4) };

            // Act
            var score = rule.AddScore(diceRolls);

            // Assert
            Assert.IsTrue(score == 400);
        }

        [TestMethod]
        public void Return500GivenTriple5()
        {
            // Arrange
            var rule = new Rule_OfAKind(5, 3, 500);
            var diceRolls = new List<Roll>() { new Roll(5), new Roll(3), new Roll(5), new Roll(5) };

            // Act
            var score = rule.AddScore(diceRolls);

            // Assert
            Assert.IsTrue(score == 500);
        }

        [TestMethod]
        public void Return600GivenTriple6()
        {
            // Arrange
            var rule = new Rule_OfAKind(6, 3, 600);
            var diceRolls = new List<Roll>() { new Roll(2), new Roll(6), new Roll(6), new Roll(6) };

            // Act
            var score = rule.AddScore(diceRolls);

            // Assert
            Assert.IsTrue(score == 600);
        }
    }
}
