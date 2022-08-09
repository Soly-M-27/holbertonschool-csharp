using System;

namespace Enemies
{
    /// <summary>
    /// Public class within Enemies namespace
    /// </summary>
    public class Zombie
    {
        /// private field health set without declaration 
        private int _health;

        /// <summary>
        /// Public Constructor for Zombie class 
        /// </summary>
        public Zombie()
        {
            _health = 0;
        }
        /// <summary>
        /// New Public Constructor for Zombie where
        /// value must be greater than or equal to 0.
        /// If value is less than 0, throw an ArgumentException
        /// with the message "Health must be greater or equal to 0   
        /// </summary>
        /// <param name="value"></param>
        public Zombie(int value)
        {
            if (value >= 0)
            {
                this._health = value;
            }
            else
            {
                throw new ArgumentException("Health must be greater than or equal to 0");
            }
        }
        /// <summary>
        /// Returns the value of health
        /// of the Zombie object 
        /// </summary>
        /// <returns>private field _health</returns>
        public int GetHealth()
        {
            return _health;
        }
    }
}