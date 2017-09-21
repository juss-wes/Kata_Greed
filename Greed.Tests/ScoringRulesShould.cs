using System;
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
            var rule = new Rule_Single();
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
            var rule = new Rule_Single();
            var diceRolls = new List<Roll>() { new Roll(1), new Roll(6), new Roll(4), new Roll(5) };

            // Act
            var score = rule.AddScore(diceRolls);

            // Assert
            Assert.IsTrue(score == 50);
        }

        [TestMethod]
        public void Return1000GivenTriple1()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Return200GivenTriple2()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Return300GivenTriple3()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Return400GivenTriple4()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Return500GivenTriple5()
        {
            throw new NotImplementedException();
        }

        [TestMethod]
        public void Return600GivenTriple6()
        {
            throw new NotImplementedException();
        }
    }
}
