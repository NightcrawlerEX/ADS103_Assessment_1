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
/// Each character has a name. This is used to refer to an instance of a character
/// </summary>
internal class Name
{
    private string _value;

    /// <summary>
    /// Constructor will throw an exception if the object fails validation
    /// </summary>
    /// <param name="value">the string value to initialize with</param>
    public Name(string value)
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
        if (string.IsNullOrWhiteSpace(_value)) throw new Exception("Name cannot be blank");
        if (_value.Length > 50) throw new Exception("Name must not be more than 50 characters");
    }//end valudate

    /// <summary>
    /// Made so that can access value.
    /// </summary>
    public string Value => _value;

}//end class