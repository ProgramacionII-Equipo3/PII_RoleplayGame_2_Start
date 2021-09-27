namespace RoleplayGame
{
    public class Knight: Character
    {
        public Knight(string name): base(name) {}

        public override Item[] Items { get => new Item[] { this.Sword, this.Shield, this.Armor }; }

        public Sword Sword;
        public Shield Shield;
        public Armor Armor;
   }
}