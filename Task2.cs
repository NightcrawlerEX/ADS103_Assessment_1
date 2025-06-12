/*
// File created by
// Student Number: A00125081
// Student Name: James Simpson
// To view the commit history and the source code go to
// https://github.com/NightcrawlerEX/ADS103_Assessment_1
*/

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
        LinkedList test = new LinkedList(new Node(1));
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

    }//end Run
}//end