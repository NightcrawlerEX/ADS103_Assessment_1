/*
// File created by
// Student Number: A00125081
// Student Name: James Simpson
// To view the commit history and the source code go to
// https://github.com/NightcrawlerEX/ADS103_Assessment_1
*/

/// <summary>
/// This class follows the value object paradigm. Value objects are used so that I don't have to 
/// write a bunch of validation logic throughout the app.
/// Value objects in this project are simple with no operator overrides and are intended to be
/// recreated if you wish to change a value
/// 
/// Rage points are the "Energy" for the warrior class and its derived classes. It is used
/// to use their special move
/// </summary>
internal class RagePoints
{
    private int _value;

    /// <summary>
    /// Constructor will throw an exception if the object fails validation
    /// </summary>
    /// <param name="value">the number of hit points</param>
    public RagePoints(int value)
    {
        _value = value;
        Validate();
    }//end constructor

    /// <summary>
    /// Perform the validation of the object
    /// </summary>
    /// <exception cref="Exception">the error exception</exception>
    private void Validate()
    {
        if (_value < 1) throw new Exception("RagePoints must be larger than zero");
        if (_value > 100) throw new Exception("Cannot have more than 100 RagePoints");
    }//end valudate

    /// <summary>
    /// Made so that can access value.
    /// </summary>
    public int Value => _value;

}//end class