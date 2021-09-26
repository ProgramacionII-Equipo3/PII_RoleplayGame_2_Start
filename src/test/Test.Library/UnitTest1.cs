using NUnit.Framework;
using RoleplayGame;

namespace Test.Library
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void AttackTest() // Test if the characters can be attacked
        {            
            SpellsBook book = new SpellsBook();
            book.Spells = new Spell[]{ new Spell() };
            
            Wizard wizard = new Wizard("Wizard");
            wizard.Staff = new Staff();
            wizard.SpellsBook = book;

            Dwarf dwarf = new Dwarf("Dwarf");
            dwarf.Axe = new Axe();
            dwarf.Helmet = new Helmet();

            int dwarfExpected = 0;
            int wizardExpected = 100;
            dwarf.ReceiveAttack(wizard.AttackValue);
            wizard.ReceiveAttack(dwarf.AttackValue);
           
            Assert.AreEqual(dwarfExpected, dwarf.Health);
            Assert.AreEqual(wizardExpected, wizard.Health);
        }

        [Test]
        public void IsItemsEquiped() // Test for the item that can be equipped for the characters
        {
            Dwarf manolo = new Dwarf("Manolo");
            manolo.Axe = new Axe();
            manolo.Helmet = new Helmet();
            int damageExpected = 25;
            int defenseExpected = 18;

            Assert.AreEqual(damageExpected, manolo.AttackValue);
            Assert.AreEqual(defenseExpected, manolo.DefenseValue);

            Wizard mario = new Wizard("Mario");
            SpellsBook libro = new SpellsBook();
            libro.Spells = new Spell[] { new Spell() };
            mario.SpellsBook = libro;
            mario.Staff = new Staff();
            int attackExpected = 170;
            int defensevalueExpected = 170;

            Assert.AreEqual(attackExpected, mario.AttackValue);
            Assert.AreEqual(defensevalueExpected, mario.DefenseValue);
        }

        [Test]
        public void HealingTest() // Test for  character´s Cure method
        {
            Archer robin = new Archer("Robin");
            robin.Bow = new Bow();

            Knight batman = new Knight("Batman");

            batman.ReceiveAttack(robin.AttackValue);
            int healthExpected = 100;
            batman.Cure();
            Assert.AreEqual(healthExpected, batman.Health);
            
        }
    }
}