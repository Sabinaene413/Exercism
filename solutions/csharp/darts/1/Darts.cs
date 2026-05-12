public static class Darts
{
    public static int Score(double x, double y)
    {
       double distanceSquared = x * x + y * y;

        return distanceSquared switch
        {
            <= 1   => 10, // Inner circle
            <= 25  => 5,  // Middle circle
            <= 100 => 1,  // Outer circle
            _      => 0   // Outside the target
        };
    }
}
