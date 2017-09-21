using System;
using System.Collections.Generic;
using System.Linq;
using Greed.Models;

namespace Greed.Rules
{
    /// <summary>
    /// Rule to score a die score from a straight (only when 6 dice rolled)
    /// </summary>
    public class Rule_Straight : IRule
    {
        public int RuleScore { get; }

        public Rule_Straight(int score)
        {
            if (score < 0)
                throw new ArgumentOutOfRangeException(nameof(score), "Score values cannot be negative");                // nameof - C# 6

            RuleScore = score;
        }

        public int AddScore(List<Roll> rolls)
        {
            if (rolls == null || rolls.Count < 6)  // Specification allows rolls of 1-6 dice
                return 0;

            // Check for any duplicate numbers, which indicates the straight has failed
            if (rolls.Where(r => !r.Scored).GroupBy(r => r).Count(g => g.Count() > 1) == 0)
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
