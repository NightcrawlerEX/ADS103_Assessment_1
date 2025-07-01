/*
// File created by
// Student Number: A00125081
// Student Name: James Simpson
// To view the commit history and the source code go to
// https://github.com/NightcrawlerEX/ADS103_Assessment_1
*/
internal class LinkedList
{
    Node? _root = null;//the start of the linked list
    Node? _endNode = null;//end end of the linked list
    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="node">the first node to add</param>
    public LinkedList(/*Node node*/)
    {
        /*//first node is the start and end of the list (its the only one)
        _root = node;
        _endNode = node;*/
    }//end Constructor

    /// <summary>
    /// Pushes the node onto the start of the list
    /// </summary>
    /// <param name="node">the node to push onto the front of the list</param>
    public void PushFront(Node node)
    {
        if (_root == null)//if is first node
        {
            //first node is the start and end of the list (its the only one)
            _root = node;
            _endNode = node;
        }
        else //not first node
        {
            //place the old root node behind the new node
            node.Next = _root;
            _root = node;
            //last node does not change
        }
    }//end PushFront

    /// <summary>
    /// Pushes the node on to the end of the list
    /// </summary>
    /// <param name="node">the node to push onto the end of the list</param>
    public void PushBack(Node node)
    {
        if (_endNode == null)//if is first node
        {
            //first node is the start and end of the list (its the only one)
            _root = node;
            _endNode = node;
        }
        else //not first node
        {
            _endNode.Next = node;//just tack onto the back
            _endNode = node;
        }
    }//end PushBack

    /// <summary>
    /// Deletes the node at the front of the linked list
    /// Note that this will just remove the node from the list and its up to the garbage
    /// collection to actually delete the node. If you have a reference to the node somewhere
    /// else it will not be deleted
    /// </summary>
    public void DeleteFront()
    {
        //here we just remove the root node. There are no other references to it
        if (_root == null) return;
        if (_root.Next != null)
        {
            _root = _root.Next;
        }
        else
        {
            _root = null;
            _endNode = null;
        }
    }//end DeleteFront

    /// <summary>
    /// Will check to see if there are any nodes left in the list
    /// </summary>
    /// <returns>true if nodes exist. false otherwise</returns>
    public bool HasNodes()
    {
        if(_root != null) return true;
        else return false;
    }

    /// <summary>
    /// Deletes the node at the back of the linked list
    /// Note that this will just remove the node from the list and its up to the garbage
    /// collection to actually delete the node. If you have a reference to the node somewhere
    /// else it will not be deleted
    /// </summary>
    public void DeleteBack()
    {
        if(_root == null) return;
        if (_endNode == null) return;
        if (_root == _endNode)
        {
            // Only one node in the list
            _root = null;
            _endNode = null;
            return;
        }
        // More than one node so find the second last node
        Node current = _root;
        while (current.Next != _endNode)
        {
            current = current.Next;
        }
        // drop the last node
        current.Next = null;
        _endNode = current;
    }//end DeleteBack

    /// <summary>
    /// Prints the linked list
    /// </summary>
    public void Print()
    {
        if (_root == null) return;
        Console.Write("{");
        _root.Print();
    }//end Print
}//end class