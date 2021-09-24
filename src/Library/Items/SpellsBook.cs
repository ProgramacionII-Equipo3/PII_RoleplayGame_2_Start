using System.Collections.Generic;
using System.Linq;

namespace RoleplayGame
{
    public class SpellsBook: Item
    {
        public Spell[] Spells { get; set; }
        
        public override int AttackValue { get => Spells.Aggregate(0, (total, el) => total + el.AttackValue); }

        public override int DefenseValue { get => Spells.Aggregate(0, (total, el) => total + el.DefenseValue); }
    }
}