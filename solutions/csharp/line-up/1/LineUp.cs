public static class LineUp
{
    public static string Format(string name, int number)
    {
        string ordered = NumberFormat(number);
        return name + ", you are the " + ordered + " customer we serve today. Thank you!";
    }

    public static string NumberFormat(int number)
    {
        int last = number%10;
        int last2 = number%100;
        if(last2 < 10 || last2 > 13 )
        {
            if(last == 1)
                return number + "st";
            if(last == 2)
                return number + "nd";
            if(last == 3)
                return number + "rd";
        }
        return number + "th";
    }
}
