namespace RoleplayGame
{
    public class Archer: Character
    {
        public Archer(string name): base(name) {}

        public override Item[] Items { get => new Item[] { this.Bow, this.Helmet }; }

        public Bow Bow;
        public Helmet Helmet;
    }
}