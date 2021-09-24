using System;
using System.Linq;

namespace RoleplayGame
{
    /// <summary>
    /// This class is a superclass for all classes representing different types of characters.
    /// </summary>
    public abstract class Character
    {
        /// <summary>
        /// The list of items the character possesses.
        /// Its main purpose is to facilitate calculation of the total attack and defense values.
        /// </summary>
        public abstract Item[] Items { get; }

        /// <summary>
        /// The character's name.
        /// </summary>
        public string Name;

        private int _health;

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
        /// Receives an attack from an oponent.
        /// </summary>
        /// <param name="power">The strength of the received attack.</param>
        public void ReceiveAttack(int power)
        {
            if (this.DefenseValue < power)
                this.Health -= power - this.DefenseValue;
        }

        /// <summary>
        /// Cures the character.
        /// </summary>
        public void Cure()
        {
            if(this.Health < 100)
                this.Health = 100;
        }
    }
}