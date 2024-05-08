using ClassLibrary;

class Program
{
    static void Main()
    {
        IHeroInventory warrior = new Warrior();
        warrior = new Artifacts(warrior);
        warrior = new Weapon(warrior);

        IHeroInventory mage = new Mage();
        warrior = new Clothes(warrior);

        IHeroInventory palladin = new Palladin();
        palladin = new Artifacts(palladin);
        palladin = new Clothes(palladin);
        palladin = new Weapon(palladin);

        Console.WriteLine(warrior.HeroInventory());
        Console.WriteLine(mage.HeroInventory());
        Console.WriteLine(palladin.HeroInventory());
    }
}