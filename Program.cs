Console.WriteLine("=============================================");
Console.WriteLine("============ ADS103 Assessment 1 ============");
Console.WriteLine("=============================================");

try
{
    //Should not be able to instantiate this later
    Character testChar = new Character(
            new Name("Jeff"),
            new HitPoints(85),
            new Strength(65),
            new Defence(43)
        );

    Mage myMage = new Mage(
            new Name("MyMage"),
            new HitPoints(45),
            new Strength(45),
            new Defence(44),
            new ManaPoints(76),
            new Damage(55) //fire ball damage
    );

    Warrior warrior = new Warrior(
            new Name("Wazza"),
            new HitPoints(55),
            new Strength(55),
            new Defence(54),
            new RagePoints(87)
    );

    Paladin paladin = new Paladin(
            new Name("pally"),
            new HitPoints(35),
            new Strength(35),
            new Defence(34),
            new RagePoints(76)
    );


}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}




Console.WriteLine("=============================================");
Console.WriteLine("============== END Assessment 1 =============");
Console.WriteLine("=============================================");