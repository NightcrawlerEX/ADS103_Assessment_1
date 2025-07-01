/*
// File created by
// Student Number: A00125081
// Student Name: James Simpson
// To view the commit history and the source code go to
// https://github.com/NightcrawlerEX/ADS103_Assessment_1
*/

using System.Diagnostics;

/// <summary>
/// This class contains the logic related to Task 2
/// The task is:
/// Write your own custom LinkedList class and a program to create and run a variety of performance 
/// tests on LinkedList objects
/// </summary>
internal class Task2
{
    public Task2()
    {

    }//end constructor
    
    /// <summary>
    /// Function to make sure things are adding to the list correctly
    /// </summary>
    private void RunTestCase()
    {
        LinkedList test = new LinkedList();
        test.PushBack(new Node(2));
        test.PushBack(new Node(3));
        test.PushBack(new Node(4));
        test.PushBack(new Node(5));
        test.PushBack(new Node(6));
        test.PushBack(new Node(7));
        test.PushBack(new Node(8));
        test.Print();
        test.PushFront(new Node(41));
        test.PushFront(new Node(42));
        test.PushFront(new Node(43));
        test.PushFront(new Node(44));
        test.Print();
    }//end RunTestCase

    public void Run()
    {
        Console.WriteLine("Compare insertion");
        LinkedList linkedList1 = new LinkedList();
        LinkedList linkedList2 = new LinkedList();

        // Using a time library  measure how long it takes to insert 50,000 random numbers into  
        // linkedList1 at the beginning of its structure in milliseconds. 

        Stopwatch stopwatch = Stopwatch.StartNew();
        int numberOfNodesToAdd = 1000000;
        Console.WriteLine($"Adding {numberOfNodesToAdd} nodes");
        for (int i = 0; i < numberOfNodesToAdd; i++)
        {
            linkedList1.PushFront(new Node(new Random().Next(0, 10000)));
        }
        stopwatch.Stop();
        long timeTakenForPushFront = stopwatch.ElapsedMilliseconds;
        Console.WriteLine($"Push front: {timeTakenForPushFront} milliseconds");
        // Measure how long it takes to insert 50,000 numbers onto the back of linkedList2 in 
        // milliseconds.  
        stopwatch = Stopwatch.StartNew();
        for (int i = 0; i < numberOfNodesToAdd; i++)
        {
            linkedList2.PushBack(new Node(new Random().Next(0, 10000)));
        }
        stopwatch.Stop();
        long timeTakenForPushBack = stopwatch.ElapsedMilliseconds;
        Console.WriteLine($"Push back: {timeTakenForPushBack} milliseconds");

        // Compare, in code, the time taken inserting into each list and output a 
        // message to the console stating which approach was more efficient.
        string comparisonWinner = string.Empty;
        long deltaTime;
        if (timeTakenForPushBack < timeTakenForPushFront)//if push back was faster
        {
            deltaTime = timeTakenForPushFront - timeTakenForPushBack;
            comparisonWinner = "Push Back";
        }
        else//if push front was faster
        {
            deltaTime = timeTakenForPushBack - timeTakenForPushFront;
            comparisonWinner = "Push Front";
        }//endif
        Console.WriteLine($"Fastest approach was {comparisonWinner} by {deltaTime} milliseconds");


        //Delete all Nodes starting from the front of linkedList1. 
        Console.WriteLine("Delete all Nodes starting from the front of linkedList1.");
        stopwatch = Stopwatch.StartNew();

        while(linkedList1.HasNodes())
        {
            linkedList1.DeleteFront();
        }

        stopwatch.Stop();
        long timeTakenForDeleteFront = stopwatch.ElapsedMilliseconds;
        Console.WriteLine($"Delete front: {timeTakenForDeleteFront} milliseconds");

        Console.WriteLine("Delete all Nodes starting from the back of linkedList2.");
        stopwatch = Stopwatch.StartNew();
        while(linkedList2.HasNodes())
        {
            linkedList2.DeleteBack();
        }
        long timeTakenForDeleteBack = stopwatch.ElapsedMilliseconds;
        Console.WriteLine($"Delete back: {timeTakenForDeleteBack} milliseconds");

        if (timeTakenForDeleteBack < timeTakenForDeleteFront)//if delete back was faster
        {
            deltaTime = timeTakenForDeleteFront - timeTakenForDeleteBack;
            comparisonWinner = "Delete Back";
        }
        else//if delete front was faster
        {
            deltaTime = timeTakenForDeleteBack - timeTakenForDeleteFront;
            comparisonWinner = "Delete Front";
        }//endif
        Console.WriteLine($"Fastest approach was {comparisonWinner} by {deltaTime} milliseconds");
    }//end Run
}//end