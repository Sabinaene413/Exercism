static class LogLine
{
    public static string Message(string logLine)
    {
        int colonIndex = logLine.IndexOf(':');
        string message = logLine.Substring(colonIndex + 1);

        return message.Trim();
    }

    public static string LogLevel(string logLine)
    {
        int startIndex = logLine.IndexOf('[') + 1;
        int endIndex = logLine.IndexOf(']');
        int length = endIndex - startIndex;
        
        string level = logLine.Substring(startIndex, length);
        
        return level.ToLower();
    }

    public static string Reformat(string logLine)
    {
        string message = Message(logLine);
        string level = LogLevel(logLine);
        
        return $"{message} ({level})";
    }
}
