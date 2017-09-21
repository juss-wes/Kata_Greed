using System.Collections.Generic;
using Greed.Models;
using Greed.Rules;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Greed.Tests
{
    [TestClass]
    public class ScoringRulesShould
    {
        #region OneOfAKind
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
        #endregion

        #region ThreeOfAKind
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
        #endregion

        #region FourOfAKind
        [TestMethod]
        public void Return2000GivenFour1()
        {
            // Arrange
            var rule = new Rule_OfAKind(1, 4, 2000);
            var diceRolls = new List<Roll>() { new Roll(1), new Roll(1), new Roll(1), new Roll(2), new Roll(1), new Roll(5) };

            // Act
            var score = rule.AddScore(diceRolls);

            // Assert
            Assert.IsTrue(score == 2000);
        }

        [TestMethod]
        public void Return400GivenFour2()
        {
            // Arrange
            var rule = new Rule_OfAKind(2, 4, 400);
            var diceRolls = new List<Roll>() { new Roll(2), new Roll(6), new Roll(2), new Roll(2), new Roll(1), new Roll(2) };

            // Act
            var score = rule.AddScore(diceRolls);

            // Assert
            Assert.IsTrue(score == 400);
        }

        [TestMethod]
        public void Return600GivenFour3()
        {
            // Arrange
            var rule = new Rule_OfAKind(3, 4, 600);
            var diceRolls = new List<Roll>() { new Roll(3), new Roll(3), new Roll(3), new Roll(3), new Roll(1), new Roll(5) };

            // Act
            var score = rule.AddScore(diceRolls);

            // Assert
            Assert.IsTrue(score == 600);
        }

        [TestMethod]
        public void Return800GivenFour4()
        {
            // Arrange
            var rule = new Rule_OfAKind(4, 4, 800);
            var diceRolls = new List<Roll>() { new Roll(4), new Roll(4), new Roll(4), new Roll(4), new Roll(1), new Roll(5) };

            // Act
            var score = rule.AddScore(diceRolls);

            // Assert
            Assert.IsTrue(score == 800);
        }

        [TestMethod]
        public void Return1000GivenFour5()
        {
            // Arrange
            var rule = new Rule_OfAKind(5, 4, 1000);
            var diceRolls = new List<Roll>() { new Roll(5), new Roll(3), new Roll(5), new Roll(5), new Roll(1), new Roll(5) };

            // Act
            var score = rule.AddScore(diceRolls);

            // Assert
            Assert.IsTrue(score == 1000);
        }

        [TestMethod]
        public void Return1200GivenFour6()
        {
            // Arrange
            var rule = new Rule_OfAKind(6, 4, 1200);
            var diceRolls = new List<Roll>() { new Roll(2), new Roll(6), new Roll(6), new Roll(6), new Roll(6), new Roll(5) };

            // Act
            var score = rule.AddScore(diceRolls);

            // Assert
            Assert.IsTrue(score == 1200);
        }
        #endregion

        #region FiveOfAKind
        [TestMethod]
        public void Return2000GivenFive1()
        {
            // Arrange
            var rule = new Rule_OfAKind(1, 5, 4000);
            var diceRolls = new List<Roll>() { new Roll(1), new Roll(1), new Roll(1), new Roll(1), new Roll(1), new Roll(5) };

            // Act
            var score = rule.AddScore(diceRolls);

            // Assert
            Assert.IsTrue(score == 4000);
        }

        [TestMethod]
        public void Return400GivenFive2()
        {
            // Arrange
            var rule = new Rule_OfAKind(2, 5, 800);
            var diceRolls = new List<Roll>() { new Roll(2), new Roll(2), new Roll(2), new Roll(2), new Roll(1), new Roll(2) };

            // Act
            var score = rule.AddScore(diceRolls);

            // Assert
            Assert.IsTrue(score == 800);
        }

        [TestMethod]
        public void Return600GivenFive3()
        {
            // Arrange
            var rule = new Rule_OfAKind(3, 5, 1200);
            var diceRolls = new List<Roll>() { new Roll(3), new Roll(3), new Roll(3), new Roll(3), new Roll(1), new Roll(3) };

            // Act
            var score = rule.AddScore(diceRolls);

            // Assert
            Assert.IsTrue(score == 1200);
        }

        [TestMethod]
        public void Return800GivenFive4()
        {
            // Arrange
            var rule = new Rule_OfAKind(4, 5, 1600);
            var diceRolls = new List<Roll>() { new Roll(4), new Roll(4), new Roll(4), new Roll(1), new Roll(4), new Roll(4) };

            // Act
            var score = rule.AddScore(diceRolls);

            // Assert
            Assert.IsTrue(score == 1600);
        }

        [TestMethod]
        public void Return1000GivenFive5()
        {
            // Arrange
            var rule = new Rule_OfAKind(5, 5, 2000);
            var diceRolls = new List<Roll>() { new Roll(5), new Roll(3), new Roll(5), new Roll(5), new Roll(5), new Roll(5) };

            // Act
            var score = rule.AddScore(diceRolls);

            // Assert
            Assert.IsTrue(score == 2000);
        }

        [TestMethod]
        public void Return1200GivenFive6()
        {
            // Arrange
            var rule = new Rule_OfAKind(6, 5, 2400);
            var diceRolls = new List<Roll>() { new Roll(2), new Roll(6), new Roll(6), new Roll(6), new Roll(6), new Roll(6) };

            // Act
            var score = rule.AddScore(diceRolls);

            // Assert
            Assert.IsTrue(score == 2400);
        }
        #endregion

        #region FiveOfAKind
        [TestMethod]
        public void Return2000GivenSix1()
        {
            // Arrange
            var rule = new Rule_OfAKind(1, 6, 8000);
            var diceRolls = new List<Roll>() { new Roll(1), new Roll(1), new Roll(1), new Roll(1), new Roll(1), new Roll(1) };

            // Act
            var score = rule.AddScore(diceRolls);

            // Assert
            Assert.IsTrue(score == 8000);
        }

        [TestMethod]
        public void Return400GivenSix2()
        {
            // Arrange
            var rule = new Rule_OfAKind(2, 6, 1600);
            var diceRolls = new List<Roll>() { new Roll(2), new Roll(2), new Roll(2), new Roll(2), new Roll(2), new Roll(2) };

            // Act
            var score = rule.AddScore(diceRolls);

            // Assert
            Assert.IsTrue(score == 1600);
        }

        [TestMethod]
        public void Return600GivenSix3()
        {
            // Arrange
            var rule = new Rule_OfAKind(3, 6, 2400);
            var diceRolls = new List<Roll>() { new Roll(3), new Roll(3), new Roll(3), new Roll(3), new Roll(3), new Roll(3) };

            // Act
            var score = rule.AddScore(diceRolls);

            // Assert
            Assert.IsTrue(score == 2400);
        }

        [TestMethod]
        public void Return800GivenSix4()
        {
            // Arrange
            var rule = new Rule_OfAKind(4, 6, 3200);
            var diceRolls = new List<Roll>() { new Roll(4), new Roll(4), new Roll(4), new Roll(4), new Roll(4), new Roll(4) };

            // Act
            var score = rule.AddScore(diceRolls);

            // Assert
            Assert.IsTrue(score == 3200);
        }

        [TestMethod]
        public void Return1000GivenSix5()
        {
            // Arrange
            var rule = new Rule_OfAKind(5, 6, 4000);
            var diceRolls = new List<Roll>() { new Roll(5), new Roll(5), new Roll(5), new Roll(5), new Roll(5), new Roll(5) };

            // Act
            var score = rule.AddScore(diceRolls);

            // Assert
            Assert.IsTrue(score == 4000);
        }

        [TestMethod]
        public void Return1200GivenSix6()
        {
            // Arrange
            var rule = new Rule_OfAKind(6, 6, 4800);
            var diceRolls = new List<Roll>() { new Roll(6), new Roll(6), new Roll(6), new Roll(6), new Roll(6), new Roll(6) };

            // Act
            var score = rule.AddScore(diceRolls);

            // Assert
            Assert.IsTrue(score == 4800);
        }
        #endregion

        #region Straight
        [TestMethod]
        public void Return1200GivenStraight()
        {
            // Arrange
            var rule = new Rule_Straight(1200);
            var diceRolls = new List<Roll>() { new Roll(1), new Roll(6), new Roll(4), new Roll(5), new Roll(3), new Roll(2) };

            // Act
            var score = rule.AddScore(diceRolls);

            // Assert
            Assert.IsTrue(score == 1200);
        }
        #endregion

        #region ThreePair
        [TestMethod]
        public void Return800GivenThreePair()
        {
            // Arrange
            var rule = new Rule_ThreePair(800);
            var diceRolls = new List<Roll>() { new Roll(1), new Roll(6), new Roll(4), new Roll(6), new Roll(1), new Roll(4) };

            // Act
            var score = rule.AddScore(diceRolls);

            // Assert
            Assert.IsTrue(score == 800);
        }
        #endregion
    }
}
