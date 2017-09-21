using System;

namespace Greed.Models
{
    /// <summary>
    /// Class to hold a given roll
    /// </summary>
    public class Roll
    {
        public int RollNumber { get; }                      // read-only auto property - C# 6
        public bool Scored { get; set; }

        public Roll(int number)
        {
            if(number <= 0 || number > 6)
                throw new ArgumentOutOfRangeException(nameof(number), $"A die value of {number} is invalid");      // nameof and string interpolation - C# 6

            RollNumber = number;
            Scored = false;
        }
    }
}
