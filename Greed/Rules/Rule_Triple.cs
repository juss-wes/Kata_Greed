using System;
using System.Collections.Generic;
using System.Linq;
using Greed.Models;

namespace Greed.Rules
{
    /// <summary>
    /// Rule to score a die score from 3 of the same dice
    /// </summary>
    public class Rule_Triple : IRule
    {
        public int RuleScore { get; }                       // read-only auto property - C# 6
        private int RollValue { get; }                      // read-only auto property - C# 6

        public Rule_Triple(int rollValue, int score)
        {
            if (rollValue <= 0 || rollValue > 6)
                throw new ArgumentOutOfRangeException(nameof(rollValue), $"A die value of {rollValue} is invalid");     // nameof and string interpolation - C# 6
            if (score < 0)
                throw new ArgumentOutOfRangeException(nameof(score), "Score values cannot be negative");                // nameof - C# 6

            RollValue = rollValue;
            RuleScore = score;
        }

        public int AddScore(List<Roll> rolls)
        {
            if (rolls == null)
                return 0;

            // Determine if there are 3 or more of a given die value
            // (including duplicates if there are multiple sets of triples)

            var score = 0;
            while (rolls.Where(r => !r.Scored).Count(r => r.RollNumber == RollValue) >= 3)
            {
                score += RuleScore;

                // Update die as used to avoid double counting
                var dieUsed = 0;
                rolls
                    .Where(r => !r.Scored && r.RollNumber == RollValue)
                    .ToList()
                    .ForEach(r =>
                {
                    if (dieUsed < 3)
                    {
                        r.Scored = true;
                        dieUsed++;
                    }
                });
            }

            return score;
        }
    }
}
