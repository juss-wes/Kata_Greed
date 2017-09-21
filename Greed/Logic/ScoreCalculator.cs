using System;
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
        /// <summary>
        /// Calculate the score, based on a given input of rolls
        /// </summary>
        /// <param name="rolls">Die rolls to score</param>
        /// <returns>Integer score value from all of the rules</returns>
        public int Calculate(List<Roll> rolls)
        {
            var score = 0;

            // TODO Calculate the aggregate score
            throw new NotImplementedException();

            return score;
        }
    }
}
