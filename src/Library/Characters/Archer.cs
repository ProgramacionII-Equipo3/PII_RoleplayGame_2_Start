namespace RoleplayGame
{
    public class Archer: Character, Wielder<Bow>, Wielder<Helmet>
    {
        public Archer(string name): base(name) {}

        public override Item[] Items { get => new Item[] { this.Bow, this.Helmet }; }
        Bow Wielder<Bow>.Item { get; set; }
        public Bow Bow { get => (this as Wielder<Bow>).Item; set => (this as Wielder<Bow>).Item = value; }
        Helmet Wielder<Helmet>.Item { get; set; }
        public Helmet Helmet { get => (this as Wielder<Helmet>).Item; set => (this as Wielder<Helmet>).Item = value; }
    }
}