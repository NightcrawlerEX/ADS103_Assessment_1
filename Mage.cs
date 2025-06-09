public class Mage : Character
{
    private ManaPoints _manaPoints;
    private Damage _fireBallDamage;
    public Mage(Name name, HitPoints hitPoints, Strength strength, Defence defence,
    ManaPoints manaPoints, Damage fireBallDamage)
    : base(name, hitPoints, strength, defence)
    {
        _manaPoints = manaPoints;
        _fireBallDamage = fireBallDamage;
    }//end constructor

    public int FireBall()
    {
        return 0;
    }
}//end class