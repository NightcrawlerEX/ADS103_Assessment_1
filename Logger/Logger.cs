/// <summary>
/// Logger is used so we don't have Console.WriteLine everywhere and it will be easier to change
/// how logging works later on. This class is purposely simple.
/// </summary>
internal static class Logger
{
    public static void Log(string message)
    {
        Console.WriteLine(message);
    }//end Log

    public static void LogError(string message, Exception ex)
    {
        Console.WriteLine("************ Error ***************");
        Console.WriteLine(message);
        Console.WriteLine("**********************************");
    }//end LogError
}//end class