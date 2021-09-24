namespace RoleplayGame
{
    public class Wizard: Character, Wielder<SpellsBook>, Wielder<Staff>
    {
        public Wizard(string name): base(name) {}

        public override Item[] Items { get => new Item[] { this.SpellsBook, this.Staff }; }

        SpellsBook Wielder<SpellsBook>.Item { get; set; }
        public SpellsBook SpellsBook { get => (this as Wielder<SpellsBook>).Item; set => (this as Wielder<SpellsBook>).Item = value; }

        Staff Wielder<Staff>.Item { get; set; }
        public Staff Staff { get => (this as Wielder<Staff>).Item; set => (this as Wielder<Staff>).Item = value; }
    }
}