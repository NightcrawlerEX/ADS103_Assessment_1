/// <summary>
/// This class follows the value object paradigm. Value objects are used so that I don't have to 
/// write a bunch of validation logic throughout the app.
/// Value objects in this project are simple with no operator overrides and are intended to be
/// recreated if you wish to change a value
/// </summary>
internal class HitPoints
{
    private int _value;

    /// <summary>
    /// Constructor will throw an exception if the object fails validation
    /// </summary>
    /// <param name="value">the number of hit points</param>
    public HitPoints(int value)
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
        if (_value < 0) throw new Exception("Hit points must be larger or equal to zero");
        //if (_value > 100) throw new Exception("Cannot have more than 100 Hit Points");
        //removed max value for hit points as it is not specified in any crieria given
        //this allows the paladin to have more than 100 hit points
    }//end valudate

    /// <summary>
    /// Made so that can access value.
    /// </summary>
    public int Value => _value;

}//end class