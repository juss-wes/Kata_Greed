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
                new Rule_Straight(1200),
                new Rule_ThreePair(800),

                new Rule_OfAKind(1, 6, 8000),
                new Rule_OfAKind(2, 6, 1600),
                new Rule_OfAKind(3, 6, 2400),
                new Rule_OfAKind(4, 6, 3200),
                new Rule_OfAKind(5, 6, 4000),
                new Rule_OfAKind(6, 6, 4800),

                new Rule_OfAKind(1, 5, 4000),
                new Rule_OfAKind(2, 5, 800),
                new Rule_OfAKind(3, 5, 1200),
                new Rule_OfAKind(4, 5, 1600),
                new Rule_OfAKind(5, 5, 2000),
                new Rule_OfAKind(6, 5, 2400),

                new Rule_OfAKind(1, 4, 2000),
                new Rule_OfAKind(2, 4, 400),
                new Rule_OfAKind(3, 4, 600),
                new Rule_OfAKind(4, 4, 800),
                new Rule_OfAKind(5, 4, 1000),
                new Rule_OfAKind(6, 4, 1200),

                new Rule_OfAKind(1, 3, 1000),
                new Rule_OfAKind(2, 3, 200),
                new Rule_OfAKind(3, 3, 300),
                new Rule_OfAKind(4, 3, 400),
                new Rule_OfAKind(5, 3, 500),
                new Rule_OfAKind(6, 3, 600),

                new Rule_OfAKind(1, 1, 100),
                new Rule_OfAKind(5, 1, 50)
            };
        }

        /// <summary>
        /// Calculate the score, based on a given input of rolls
        /// </summary>
        /// <param name="rolls">Die rolls to score</param>
        /// <returns>Integer score value from all of the rules</returns>
        public int Calculate(List<Roll> rolls)
        {
            var score = 0;

            foreach (var rule in _rules)
                score += rule.AddScore(rolls);

            return score;
        }
    }
}
