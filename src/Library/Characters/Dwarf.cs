namespace RoleplayGame
{
    public class Dwarf: Character, Wielder<Axe>, Wielder<Shield>, Wielder<Helmet>
    {
        public Dwarf(string name)
        {
            this.Name = name;
        }

        public override Item[] Items { get => new Item[] { this.Axe, this.Shield, this.Helmet }; }

        Axe Wielder<Axe>.Item { get; set; }
        public Axe Axe { get => (this as Wielder<Axe>).Item; set => (this as Wielder<Axe>).Item = value; }

        Shield Wielder<Shield>.Item { get; set; }
        public Shield Shield { get => (this as Wielder<Shield>).Item; set => (this as Wielder<Shield>).Item = value; }

        Helmet Wielder<Helmet>.Item { get; set; }
        public Helmet Helmet { get => (this as Wielder<Helmet>).Item; set => (this as Wielder<Helmet>).Item = value; }

    }
}