namespace RoleplayGame
{
    public class Dwarf: Character
    {
        public Dwarf(string name): base(name) {}

        public override Item[] Items { get => new Item[] { this.Axe, this.Shield, this.Helmet }; }

        public Axe Axe;
        public Shield Shield;
        public Helmet Helmet;

    }
}