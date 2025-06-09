public class Paladin : Warrior
{
    public Paladin(Name name, HitPoints hitPoints, Strength strength, Defence defence, RagePoints ragePoints) 
    : base(name, hitPoints, strength, defence, ragePoints)
    {

    }//end constructor

    public int Heal()
    {
        return 0;
    }
}//end class