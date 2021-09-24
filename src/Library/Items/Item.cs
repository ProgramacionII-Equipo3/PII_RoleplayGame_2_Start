using System;

namespace RoleplayGame
{
    /// <summary>
    /// This class represents a generic item that can be wielded by a character.
    /// </summary>
    public abstract class Item
    {
        /// <summary>
        /// The defense value of the item.
        /// </summary>
        public virtual int DefenseValue { get => 0; }

        /// <summary>
        /// The attack value of the item.
        /// </summary>
        public virtual int AttackValue { get => 0; }

    }
}