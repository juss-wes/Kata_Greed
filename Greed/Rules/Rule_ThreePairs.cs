using System;
using System.Collections.Generic;
using System.Linq;
using Greed.Models;

namespace Greed.Rules
{
    /// <summary>
    /// Rule to score a die score from a number of die pairs
    /// </summary>
    public class Rule_ThreePairs : IRule
    {
        public int RuleScore { get; }                       // read-only auto property - C# 6

        public Rule_ThreePairs(int score)
        {
            if (score < 0)
                throw new ArgumentOutOfRangeException(nameof(score), "Score values cannot be negative");                // nameof - C# 6

            RuleScore = score;
        }

        public int AddScore(List<Roll> rolls)
        {
            if (rolls == null || rolls.Count < 6)  // Specification allows rolls of 1-6 dice
                return 0;

            // Check for 3 groupings of pairs (2 rolls each)
            if (rolls.Where(r => !r.Scored).GroupBy(r => r).Count(g => g.Count() == 2) == 3)
            {
                // All 6 dice are used, based on the specification
                rolls.ForEach(r => r.Scored = true);
                return RuleScore;
            }
            else
                return 0;
        }
    }
}
