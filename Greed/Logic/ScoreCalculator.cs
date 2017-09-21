using System.Collections.Generic;
using Greed.Models;
using Greed.Rules;

namespace Greed.Logic
{
    /// <summary>
    /// Class to build the ruleset and run them all on a given input
    /// </summary>
    public class ScoreCalculator
    {
        private static List<IRule> _rules;

        public ScoreCalculator()
        {
            // Add all of the defined scoring rules - NOTE: Order is important!
            _rules = new List<IRule>
            {
                // These could also be configurable, dynamic, and take outside configuration
                new Rule_Triple(1, 1000),
                new Rule_Triple(2, 200),
                new Rule_Triple(3, 300),
                new Rule_Triple(4, 400),
                new Rule_Triple(5, 500),
                new Rule_Triple(6, 600),
                new Rule_Single(1, 100),
                new Rule_Single(5, 50)
            };
        }

        /// <summary>
        /// Calculate the score, based on a given input of rolls
        /// </summary>
        /// <param name="rolls">Die rolls to score</param>
        /// <returns>Integer score value from all of the rules</returns>
        public int Calculate(IEnumerable<Roll> rolls)
        {
            var score = 0;

            foreach (var rule in _rules)
                score += rule.AddScore(rolls);

            return score;
        }
    }
}
