public class Paladin : Warrior
{
    Damage _healAmount;
    public Paladin(Name name, HitPoints hitPoints, Strength strength, Defence defence,
    RagePoints ragePoints, Damage healAmount)
    : base(name, hitPoints, strength, defence, ragePoints)
    {
        _healAmount = healAmount;
    }//end constructor

    public int Heal()
    {
        return 0;
    }
}//end class