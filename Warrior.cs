public class Warrior : Character
{
    private RagePoints _ragePoints;
    public Warrior(Name name, HitPoints hitPoints, Strength strength, Defence defence, RagePoints ragePoints)
    : base(name, hitPoints, strength, defence)
    {
        _ragePoints = ragePoints;
    }//end constructor

    public int HeavySwing()
    {
        return 0;
    }
}//end class