using ScenarioGeneration.Enemy;

namespace ScenarioGeneration;

public class ScenarioGeneration
{
    public static void Main(string[] args)
    {
        var generator = new EnemyGenerator(new Dragon());
        //generator.GiveWeapon();
    }
}
