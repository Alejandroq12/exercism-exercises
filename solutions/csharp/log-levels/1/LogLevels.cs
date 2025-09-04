static class LogLine
{
    public static string Message(string logLine)
    {
        string[] arrayOfLogLine = logLine.Split(" ").Skip(1).ToArray();
        return string.Join(" ", arrayOfLogLine).Trim();
    }

    public static string LogLevel(string logLine)
    {
        string[] arrayOfLogLevel = logLine.Split(" ");
        return string.Join(" ", arrayOfLogLevel[0]).Trim('[', ']', ':').ToLower();
    }

    public static string Reformat(string logLine) => $"{Message(logLine)} ({LogLevel(logLine)})";
}
