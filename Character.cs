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

        damage -= this._defence.Value;//Subract defence from the damage
        if (damage < 1) damage = 1;//should always do at least 1 point of damage
        int hitPoints = this._hitPoints.Value - damage; //and subtract the result from hitPoints
        if (hitPoints < 1) hitPoints = 0; //Make negative HP not a thing

        //create new hitpoints value object
        HitPoints newHitPoints = new HitPoints(hitPoints);//will throw exception if not correct value
        this._hitPoints = newHitPoints;
    }//end TakeDamage

    /// <summary>
    /// RemoveDamage is the inverse of take damage. Used for healing
    /// </summary>
    /// <param name="healAmount"></param>
    public void RemoveDamage(int healAmount)
    {
        int hitPoints = _hitPoints.Value;
        hitPoints -= healAmount;
        _hitPoints = new HitPoints(hitPoints);
    }//end RemoveDamage

    /// <summary>
    /// This method tests if the character is alive
    /// </summary>
    /// <returns>true if hitPoints are greater than zero</returns>
    public bool IsAlive()
    {
        return this._hitPoints.Value > 0 ? true : false;
    }//end IsAlive


    /// <summary>
    /// Getter for the name
    /// </summary>
    public Name Name => _name;

    /// <summary>
    /// Getter for the HP
    /// </summary>
    public HitPoints HitPoints => _hitPoints;

    /// <summary>
    /// Getter for the strength
    /// </summary>
    public Strength Strength => _strength;

    /// <summary>
    /// Getter for the Defence
    /// </summary>
    public Defence Defence => _defence;

    /// <summary>
    /// Returns the character type
    /// </summary>
    /// <returns>the character type in string format e.g. "Warrior"</returns>
    protected abstract string GetCharacterTypeString();

    /// <summary>
    /// Override of ToString to output character information. This is useful for logging
    /// This function must be called from an implemented classes ToString function
    /// </summary>
    /// <returns>the character information in string form</returns>
    public override string ToString()
    {
        string output = $"Type: {this.GetCharacterTypeString()}"; //get implementation specific type
        //add character base stats
        output += $"\nName: {Name}\n";
        output += $"HP: {HitPoints}\n";
        output += $"Strength: {Strength}\n";
        output += $"Defence: {Defence}\n";
        return output;
    }//end ToString
}//end class