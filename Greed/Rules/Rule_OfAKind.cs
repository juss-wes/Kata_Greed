using System;
using System.Collections.Generic;
using System.Linq;
using Greed.Models;

namespace Greed.Rules
{
    /// <summary>
    /// Rule to score a die score from many of the same dice
    /// </summary>
    public class Rule_OfAKind : IRule
    {
        public int RuleScore { get; }                       // read-only auto property - C# 6
        private int RollValue { get; }                       // read-only auto property - C# 6
        private int DiceCount { get; }                       // read-only auto property - C# 6

        public Rule_OfAKind(int rollValue, int count, int score)
        {
            if (rollValue <= 0 || rollValue > 6)
                throw new ArgumentOutOfRangeException(nameof(rollValue), $"A die value of {rollValue} is invalid");     // nameof and string interpolation - C# 6
            if (count <= 0)
                throw new ArgumentOutOfRangeException(nameof(count), "Must require 1 or more dice to score");       // string interpolation - C# 6
            if (score < 0)
                throw new ArgumentOutOfRangeException(nameof(score), "Score values cannot be negative");                // nameof - C# 6

            RollValue = rollValue;
            DiceCount = count;
            RuleScore = score;
        }

        public int AddScore(List<Roll> rolls)
        {
            if (rolls == null)
                return 0;

            // Determine if there are the requisite number of duplicates in the list of dice roles

            var score = 0;
            while (rolls.Where(r => !r.Scored).Count(r => r.RollNumber == RollValue) >= DiceCount)
            {
                score += RuleScore;

                // Update die as used to avoid double counting
                var dieUsed = 0;
                rolls
                    .Where(r => !r.Scored && r.RollNumber == RollValue)
                    .ToList()
                    .ForEach(r =>
                    {
                        if (dieUsed < DiceCount)
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
