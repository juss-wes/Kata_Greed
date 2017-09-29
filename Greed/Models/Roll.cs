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

        public string RollText => GetDiceText(RollNumber);  // expression bodied method - C# 6

        /// <summary>
        /// Fairly useless method, but wanted to show off expression bodied (single bodied) member functions
        /// </summary>
        /// <param name="number">Integer to convert</param>
        /// <returns>String name of the given die number</returns>
        private string GetDiceText(int number)
        {
            switch (number)
            {
                case 1:
                    return "One";
                case 2:
                    return "Two";
                case 3:
                    return "Three";
                case 4:
                    return "Four";
                case 5:
                    return "Five";
                case 6:
                    return "Six";
                default:
                    return "OUT OF RANGE.  DOES NOT COMPUTE";
            }
        }
    }
}
