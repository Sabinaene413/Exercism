public class Player
{
    public int RollDie()
    {
        return System.Random.Shared.Next(1, 19);
    }

    public double GenerateSpellStrength()
    {
        return Random.Shared.NextDouble() * 100.0;
    }
}
