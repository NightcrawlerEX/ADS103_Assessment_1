/*
// File created by
// Student Number: A00125081
// Student Name: James Simpson
// To view the commit history and the source code go to
// https://github.com/NightcrawlerEX/ADS103_Assessment_1
*/

/*
// This file is the main file for the Assessment 1 Task
// It creates the Task1 object (battle game). In Task1's constructor the characters are created
// and in the Run method the battle is run
//
*/

Logger.Log("=============================================");
Logger.Log("================== Task 1 ===================");
Logger.Log("=============================================");
try
{
        //Task1 task1 = new Task1();//initialize the characters
        //task1.Run();//run the battle        
}
catch (Exception ex)
{
        Logger.LogError(ex.Message, ex);
}
Logger.Log("=============================================");
Logger.Log("================== Task 2 ===================");
Logger.Log("=============================================");
try
{
        Task2 task2 = new Task2();
        task2.Run();
}
catch (Exception ex)
{
        Logger.LogError(ex.Message, ex);
}