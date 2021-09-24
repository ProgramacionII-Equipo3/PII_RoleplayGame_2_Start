using System;
using System.Linq;

namespace RoleplayGame
{
    /// <summary>
    /// This interface represents a character who can wield a concrete type of item.
    /// </summary>
    /// <typeparam name="I">The type of the item which can be wielded.</typeparam>
    public interface Wielder<I> where I: Item
    {
        /// <summary>
        /// The item of the character.
        /// </summary>
        public I Item { get; set; }
    }
}