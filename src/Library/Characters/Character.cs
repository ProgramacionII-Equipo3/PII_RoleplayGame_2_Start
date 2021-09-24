using System;
using System.Linq;

namespace RoleplayGame
{
    /// <summary>
    /// This class is a superclass for all classes representing different types of characters.
    /// </summary>
    public abstract class Character
    {
        public abstract Item[] Items { get; }

        private int _health { get; set; }

        /// <summary>
        /// The character's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The character's health.
        /// </summary>
        public int Health
        {
                      get => this._health;
            protected set => this._health = value < 0 ? 0 : value;
        }

        /// <summary>
        /// The attack value of the character.
        /// </summary>
        public int AttackValue { get => Items.Aggregate(0, (total, el) => total + el.AttackValue); }

        /// <summary>
        /// The defense value of the character.
        /// </summary>
        public int DefenseValue { get => Items.Aggregate(0, (total, el) => total + el.DefenseValue); }

        /// <summary>
        /// Receives an attack from a concrete oponent.
        /// </summary>
        /// <param name="power">The strength of the received attack.</param>
        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
                this.Health -= power - this.DefenseValue;
        }

        /// <summary>
        /// Cures the character (or rather, sets its health to 100, reducing it if it was higher than that).
        /// </summary>
        public void Cure()
        {
            this.Health = 100;
        }
    }
}