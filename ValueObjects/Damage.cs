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
/// 
/// Damage deals with the case of positive damage and negative damage (heal)
/// 
/// </summary>
internal class Damage
{
    private int _value;

    /// <summary>
    /// Constructor will throw an exception if the object fails validation
    /// </summary>
    /// <param name="value">the number of hit points</param>
    public Damage(int value)
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
        //if (_value < 1) throw new Exception("Damage must be larger than zero");
        //if (_value > 500) throw new Exception("Cannot have more than 500 Damage");

        //Damage is extended to be able to heal also
        if (_value < -500) _value = -500;//truncate heal at 500
        if (_value > 500) _value = 500;//truncate damage at 500
    }//end valudate

    /// <summary>
    /// Made so that can access value.
    /// </summary>
    public int Value => _value;

}//end class