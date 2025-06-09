public class Character
{
    private Name _name;
    private HitPoints _hitPoints;
    private Strength _strength;
    private Defence _defence;

    /// <summary>
    /// Constructor to initialize characcter
    /// </summary>
    /// <param name="name">the name of the character</param>
    /// <param name="hitPoints">the characters HP</param>
    public Character(Name name, HitPoints hitPoints, Strength strength, Defence defence)
    {
        _name = name;
        _hitPoints = hitPoints;
        _strength = strength;
        _defence = defence;
    }//end constructor
}//end class