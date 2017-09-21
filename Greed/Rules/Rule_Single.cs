using System;
using System.Collections.Generic;
using System.Linq;
using Greed.Models;

namespace Greed.Rules
{
    /// <summary>
    /// Rule to score a die score from a single, specific, die
    /// </summary>
    public class Rule_Single : IRule
    {
        public int Score { get; }               // read-only auto property - C# 6
        private int RollValue { get; }          // read-only auto property - C# 6

        public Rule_Single(int rollValue, int score)
        {
            if (rollValue <= 0 || rollValue > 6)
                throw new ArgumentOutOfRangeException(nameof(rollValue), $"A die value of {rollValue} is invalid");     // nameof and string interpolation - C# 6
            if (score < 0)
                throw new ArgumentOutOfRangeException(nameof(score), "Score values cannot be negative");                // nameof - C# 6

            RollValue = rollValue;
            Score = score;
        }

        public int AddScore(IEnumerable<Roll> rolls)
        {
            if (rolls == null)
                return 0;

            // Determine if there are any rolls matching the scoring die value

            var dieCount = rolls
                .Where(r => !r.Scored)
                .Count(r => r.RollNumber == RollValue);

            return (dieCount * Score);
        }
    }
}
