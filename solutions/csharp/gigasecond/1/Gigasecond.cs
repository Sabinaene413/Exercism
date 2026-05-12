public static class Gigasecond
{
    public static DateTime Add(DateTime moment)
    {
        const double gigasecond = 1_000_000_000;
        return moment.AddSeconds(gigasecond);
    }
}