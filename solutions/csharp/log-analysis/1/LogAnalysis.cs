public static class LogAnalysis 
{
    // TODO: define the 'SubstringAfter()' extension method on the `string` type
    public static string SubstringAfter(this string str, string delimiter)
    {
        int index = str.IndexOf(delimiter);
        return str.Substring(index + delimiter.Length);
    }

    // TODO: define the 'SubstringBetween()' extension method on the `string` type
    public static string SubstringBetween(this string str, string delimiter1, string delimiter2)
    {
        int index1 = str.IndexOf(delimiter1);
        int index2 = str.IndexOf(delimiter2);
        
        return str.Substring(index1 + delimiter1.Length, index2 - index1 - delimiter1.Length );
    }
    
    // TODO: define the 'Message()' extension method on the `string` type
    public static string Message(this string str)
    {
        return str.Substring(str.IndexOf(':') + 1).Trim();
    }

    // TODO: define the 'LogLevel()' extension method on the `string` type
    public static string LogLevel(this string str)
    {
        return str.Substring(str.IndexOf('[') + 1, str.IndexOf(']') - str.IndexOf('[') - 1);
    }
}