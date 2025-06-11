/// <summary>
/// Warrior is an implementation of base class "Character"
/// Warrior class defines a specific "Warrior" character.
/// </summary>
public class Warrior : Character
{
    protected RagePoints _ragePoints; //The warriors rage points. Specific to warrior type
    private int _heavySwingMultiplier = 2;//Heavy swing damage multiplier
    private int _heavySwingCost = 15;//Cost of heavy swing in rage points
    protected int _ragePointsIncreasePerTurn = 5;//the number of rage points that increase per turn

    /// <summary>
    /// Constructor
    /// </summary>
    /// <param name="name">the name of this warrior</param>
    /// <param name="hitPoints">the hit points the warrior starts with</param>
    /// <param name="strength">strength of the warrior character</param>
    /// <param name="defence">defence of the warrior character</param>
    /// <param name="ragePoints">rage points. A specific warrior attribute</param>
    public Warrior(Name name, HitPoints hitPoints, Strength strength,
    Defence defence, RagePoints ragePoints)
    : base(name, hitPoints, strength, defence)
    {
        _ragePoints = ragePoints;
    }//end constructor

    /// <summary>
    /// This is the warriors signature move. Called via DoAction
    /// </summary>
    /// <returns>the damage from the heavy swing attack</returns>
    public int HeavySwing()
    {
        Logger.Log($"Warrior {Name.Value} uses Heavy Swing");
        return _heavySwingMultiplier * Strength.Value;
    }//end HeavySwing

    /// <summary>
    /// Attack is used when the special attack is not
    /// </summary>
    /// <returns></returns>
    public int Attack()
    {
        Logger.Log($"Warrior {Name.Value} Attacks");
        return Strength.Value;
    }//end Attack

    /// <summary>
    /// Method that is called on base class "Character" to do action related to warrior
    /// 
    /// If ragePoints greater than 15 spend 15 ragePoints to do HeavySwing and return the 
    /// damage from that attack 
    /// else
    /// Add 5 ragePoints to total
    /// Return strength (default attack damage) 
    /// </summary>
    /// <returns></returns>
    public override int DoAction()
    {
        //If ragePoints greater than 15 spend 15 ragePoints to do HeavySwing
        if (_ragePoints.Value > _heavySwingCost)
        {
            //reduce rage points by cost of heavy swing
            int ragePoints = _ragePoints.Value;
            ragePoints -= _heavySwingCost;
            _ragePoints = new RagePoints(ragePoints);

            //perform the HeavySwing move
            return HeavySwing();
        }
        else //not enough rage points to do heavy swing
        {
            int ragePoints = _ragePoints.Value;
            ragePoints += _ragePointsIncreasePerTurn;
            Logger.Log($"{Name.Value} rage points increased by {_ragePointsIncreasePerTurn}");
            return Attack();//do normal attack
        }
    }//end DoAction

    /// <summary>
    /// /// <summary>
    /// For logging. When ToString is called on character object it in turn calls
    /// this virtual function and appends the text to the output
    /// </summary>
    /// <returns>the name of the class</returns>
    /// </summary>
    /// <returns></returns>
    protected override string GetCharacterTypeString() => "Warrior";


    /// <summary>
    /// For logging. Appends the implementation specific stats to the output of the base
    /// stats from the Character class
    /// </summary>
    /// <returns></returns>
    public override string ToString()
    {
        return base.ToString() + $", Rage Points: {_ragePoints.Value}";
    }
}//end class