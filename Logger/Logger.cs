/*
// File created by
// Student Number: A00125081
// Student Name: James Simpson
// To view the commit history and the source code go to
// https://github.com/NightcrawlerEX/ADS103_Assessment_1
*/

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