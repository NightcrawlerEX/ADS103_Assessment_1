internal class Paladin : Warrior
{
    Damage _healAmount; //the amount to heal when using special attack
    int _healingCost = 10; //the cost in rage points to heal

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name">name of the paladin</param>
    /// <param name="hitPoints">the hit points the paladin starts with</param>
    /// <param name="strength">strength of the paladin</param>
    /// <param name="defence">defence of the paladin</param>
    /// <param name="ragePoints">rage points the paladin starts with</param>
    /// <param name="healAmount">the amount to heal when using special attack</param>
    public Paladin(Name name, HitPoints hitPoints, Strength strength, Defence defence,
    RagePoints ragePoints, Damage healAmount)
    : base(name, hitPoints, strength, defence, ragePoints)
    {
        _healAmount = healAmount;
    }//end constructor

    /// <summary>
    /// Paladin's special move heal
    /// </summary>
    /// <returns>the amount to heal</returns>
    public int Heal()
    {

        Logger.Log($"Paladin {Name.Value} uses Heal");
        return _healAmount.Value;
    }//end Heal

    /// <summary>
    /// Method that is called on base class "Character" to do action related to Paladin
    /// 
    /// method and decide to Heal using ragePoints
    /// healing Paladin should return zero damage from the DoAction method. 
    /// </summary>
    /// <returns></returns>
    public override int DoAction()
    {
        //If ragePoints greater than healing cost use heal
        if (_ragePoints.Value > _healingCost)
        {
            //reduce rage points by cost of heavy swing
            int ragePoints = _ragePoints.Value;
            ragePoints -= _healingCost;
            _ragePoints = new RagePoints(ragePoints);

            //perform the healing move
            int amountToHeal = Heal();
            RemoveDamage(amountToHeal);
        }
        else //not enough rage points to do heavy swing
        {
            int ragePoints = _ragePoints.Value;
            ragePoints += _ragePointsIncreasePerTurn;
            _ragePoints = new RagePoints(ragePoints);
            Logger.Log($"{Name.Value} rage points increased by {_ragePointsIncreasePerTurn}");
        }

        return 0; //healing Paladin should return zero damage from the DoAction method. 
    }//end DoAction


    /// <summary>
    /// For logging. When ToString is called on character object it in turn calls
    /// this virtual function and appends the text to the output
    /// </summary>
    /// <returns>the name of the class</returns>
    protected override string GetCharacterTypeString() => "Paladin";

}//end class