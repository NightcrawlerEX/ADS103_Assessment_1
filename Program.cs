Logger.Log("=============================================");
Logger.Log("============ ADS103 Assessment 1 ============");
Logger.Log("=============================================");

try
{
        //in this try/catch block we initialize the characters
        Logger.Log("Initializing Characters");

        Mage myMage = new Mage(
            new Name("MyMage"),
            new HitPoints(45),
            new Strength(45),
            new Defence(44),
            new ManaPoints(76),
            new Damage(55) //fire ball damage
        );
        Logger.Log($"New Mage initialized.\n{myMage.ToString()}\n");

        Warrior warrior = new Warrior(
            new Name("Wazza"),
            new HitPoints(55),
            new Strength(55),
            new Defence(54),
            new RagePoints(87)
        );
        Logger.Log($"New Warrior initialized.\n{warrior.ToString()}\n");

        Paladin paladin = new Paladin(
                new Name("pally"),
                new HitPoints(35),
                new Strength(35),
                new Defence(34),
                new RagePoints(76),
                new Damage(44) //heal amount
            );
        Logger.Log($"New Paladin initialized.\n{paladin.ToString()}\n");
}
catch (Exception ex)
{
        Logger.LogError(ex.Message, ex);
}




Console.WriteLine("=============================================");
Console.WriteLine("============== END Assessment 1 =============");
Console.WriteLine("=============================================");