public abstract class Character
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

    /// <summary>
    /// Abstract method designed to be overridden by base class. This should be the character's
    /// specific action
    /// </summary>
    /// <returns>how much damage the action does</returns>
    public abstract int DoAction();

    /// <summary>
    /// Called to apply damage to the character object
    /// Subract defence from the damage and subtract the result from hitPoints. You 
    /// should always do at least 1 point of damage. Output remaining hitPoints at the 
    /// end of the method
    /// </summary>
    /// <param name="damage">damage to do to the character</param>
    public void TakeDamage(int damage)
    {
        //ToDo: To extend this further we would override some operators on the value objects
        //however this is not pertanent at this time. Task must be added and approved if we
        //care enough to do this
        

    }//end TakeDamage


}//end class