/*
// File created by
// Student Number: A00125081
// Student Name: James Simpson
// To view the commit history and the source code go to
// https://github.com/NightcrawlerEX/ADS103_Assessment_1
*/

/// <summary>
/// Node is a single node in the linked list. It contains an integer to hold some data and a
/// reference to the next node in the linked list. We need to make the next reference nullable
/// so that we can deal with the last node which has nothing.
/// 
/// The members are public for ease of use
/// </summary>
internal class Node
{
    public int Data { get; set; }//bit of data

    //define a nullable node to hold the next thing in the list. Allow it to be null
    //so that the end of the list is covered
    public Node? Next { get; set; }

    public Node(int data, Node? next = null)
    {
        Data = data;
        Next = next;
    }//end Constructor
}//end class