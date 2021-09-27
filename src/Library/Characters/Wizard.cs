namespace RoleplayGame
{
    public class Wizard: Character
    {
        public Wizard(string name): base(name) {}

        public override Item[] Items { get => new Item[] { this.SpellsBook, this.Staff }; }

        public SpellsBook SpellsBook;
        public Staff Staff;
    }
}