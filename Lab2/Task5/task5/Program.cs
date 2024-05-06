using task5;

class Program
{
    static void Main()
    {
        Director director = new Director();
        HeroBuilder heroBuilder = new HeroBuilder();
        EnemyBuilder enemyBuilder = new EnemyBuilder();

        Hero hero = director.ConstructHero(heroBuilder);
        Hero enemy = director.ConstructEnemy(enemyBuilder);

        Console.WriteLine("Hero:\n" + hero);
        Console.WriteLine();
        Console.WriteLine("Enemy:\n" + enemy);
    }
}