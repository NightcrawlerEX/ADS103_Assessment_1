internal class Mage : Character
{
    private ManaPoints _manaPoints; //mage specific attribute
    private Damage _fireBallDamage; //damage done by the mage's special attack
    private int _fireBallCost = 10;//the cost in MP to use the fireball special move
    private int _manaPointsIncreasePerTurn = 5;//the number of MP that increase per turn 

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name">the name of the mage</param>
    /// <param name="hitPoints">number of hit points the mage starts with</param>
    /// <param name="strength">strength of the mage</param>
    /// <param name="defence">defence of the mage</param>
    /// <param name="manaPoints">mage specific attribute. MP</param>
    /// <param name="fireBallDamage">the damage done by the mage's special move</param>
    public Mage(Name name, HitPoints hitPoints, Strength strength, Defence defence,
    ManaPoints manaPoints, Damage fireBallDamage)
    : base(name, hitPoints, strength, defence)
    {
        _manaPoints = manaPoints;
        _fireBallDamage = fireBallDamage;
        Logger.Log($"{fireBallDamage.Value}");
    }//end constructor

    /// <summary>
    /// Mage special attack
    /// </summary>
    /// <returns>the damage done by this special attack</returns>
    public int FireBall()
    {
        Logger.Log($"Mage {Name.Value} uses Fireball");
        Logger.Log($"Fireball damage {_fireBallDamage.Value}");
        return _fireBallDamage.Value;
    }//end FireBall

    /// <summary>
    /// Attack is used when the special attack is not
    /// </summary>
    /// <returns></returns>
    public int Attack()
    {
        Logger.Log($"Mage {Name.Value} Attacks");
        return Strength.Value;
    }//end Attack

    /// <summary>
    /// Method that is called on base class "Character" to do action related to Mage
    /// If manaPoints greater than 10
    ///     Use FireBall and return its damage amount 
    /// else
    ///     Return strength (default attack damage)
    /// </summary>
    /// <returns>the damage done by the action</returns>
    public override int DoAction()
    {
        if (_manaPoints.Value > _fireBallCost)
        {
            //reduce rage points by cost of heavy swing
            int manaPoints = _manaPoints.Value;
            manaPoints -= _fireBallCost;
            _manaPoints = new ManaPoints(manaPoints);

            //perform the FireBall move
            return FireBall();
        }
        else //not enough MP to perform fireball
        {
            int manaPoints = _manaPoints.Value;
            manaPoints += _manaPointsIncreasePerTurn;
            _manaPoints = new ManaPoints(manaPoints);
            Logger.Log($"{Name.Value} mana points increased by {_manaPointsIncreasePerTurn}");
            return Attack();//do normal attack
        }
    }//end DoAction

    /// <summary>
    /// For logging. When ToString is called on character object it in turn calls
    /// this virtual function and appends the text to the output
    /// </summary>
    /// <returns>the name of the class</returns>
    protected override string GetCharacterTypeString() => "Mage";

    /// <summary>
    /// For logging. Appends the implementation specific stats to the output of the base
    /// stats from the Character class
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return base.ToString() + $", MP: {_manaPoints.Value}";
    }
}//end class