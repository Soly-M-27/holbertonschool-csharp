using System;

namespace MyMath
{
    /// <summary>
    /// Public Class Operations
    /// </summary>
    public class Operations
    {
        /// <summary>
        /// Methods that returns the max int of a list of nums
        /// </summary>
        /// <param name="nums">list of nums</param>
        /// <returns>Max of list or 0 if list is empty</returns>
        public static int Max(List<int> nums)
        {
            if (nums.Count == 0 || nums == null)
                return (0);

            return (Max(nums));
        }

    }
}
