using System.Collections.Generic;
using Greed.Models;

namespace Greed.Rules
{
    /// <summary>
    /// Interface that all scoring rules will implement
    /// </summary>
    public interface IRule
    {
        int AddScore(IEnumerable<Roll> rolls);
    }
}