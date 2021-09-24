namespace RoleplayGame
{
    public class Knight: Character, Wielder<Sword>, Wielder<Shield>, Wielder<Armor>
    {
        public Knight(string name): base(name) {}

        public override Item[] Items { get => new Item[] { this.Sword, this.Shield, this.Armor }; }

        Sword Wielder<Sword>.Item { get; set; }
        public Sword Sword { get => (this as Wielder<Sword>).Item; set => (this as Wielder<Sword>).Item = value; }

        Shield Wielder<Shield>.Item { get; set; }
        public Shield Shield { get => (this as Wielder<Shield>).Item; set => (this as Wielder<Shield>).Item = value; }

        Armor Wielder<Armor>.Item { get; set; }
        public Armor Armor { get => (this as Wielder<Armor>).Item; set => (this as Wielder<Armor>).Item = value; }
   }
}