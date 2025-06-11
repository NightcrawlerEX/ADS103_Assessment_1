
/*
// This file is the main file for the Assessment 1 Task
//
//
//
*/

Logger.Log("=============================================");
Logger.Log("============ ADS103 Assessment 1 ============");
Logger.Log("=============================================");

//========================================================================
//======================= Character Initialization =======================
//========================================================================
Mage mage;
Warrior warrior;
Paladin paladin;
try
{
        //in this try/catch block we initialize the characters
        Logger.Log("************************************************************************");
        Logger.Log("************************ Initializing Characters ************************");
        Logger.Log("************************************************************************");
        mage = new Mage(
            new Name("MyMage"),
            new HitPoints(100),
            new Strength(40),
            new Defence(30),
            new ManaPoints(10),
            new Damage(88) //fire ball damage
        );
        Logger.Log($"New Mage initialized.\n{mage.ToString()}\n");

        warrior = new Warrior(
            new Name("Wazza"),
            new HitPoints(55),
            new Strength(55),
            new Defence(54),
            new RagePoints(87)
        );
        Logger.Log($"New Warrior initialized.\n{warrior.ToString()}\n");

        paladin = new Paladin(
                new Name("pally"),
                new HitPoints(100),
                new Strength(45),
                new Defence(30),
                new RagePoints(10),
                new Damage(20) //heal amount
            );
        Logger.Log($"New Paladin initialized.\n{paladin.ToString()}\n");


        //========================================================================
        //=============================== Battle  ================================
        //========================================================================
        Logger.Log("************************************************************************");
        Logger.Log("*************************** Starting Battle ****************************");
        Logger.Log("************************************************************************");
        Character[] battleParticipants = { mage, paladin };
        bool bIsBattleFinished = false;
        int i = new Random().Next(0, 2);//choose a random character to start
        while (!bIsBattleFinished)
        {
                Character attacker = battleParticipants[i % 2];
                Character defender = battleParticipants[(i + 1) % 2];
                int damage = attacker.DoAction();
                defender.TakeDamage(damage);
                i++;
                Logger.Log(battleParticipants[0].ToString());
                Logger.Log(battleParticipants[1].ToString());


                if (defender.IsAlive() == false)
                {
                        Logger.Log($"{defender.Name.Value}'s HP is zero");
                        Logger.Log($"{defender.Name.Value} looses the battle");
                        bIsBattleFinished = true;
                }
                Logger.Log("");
                Thread.Sleep(3000);
        }//end while
         //if we get here the battle has ended
        Character winner = battleParticipants[i % 2];
        Character looser = battleParticipants[(i + 1) % 2];
        Logger.Log("************************************************************************");
        Logger.Log("***************************** End Battle *******************************");
        Logger.Log("************************************************************************");
        Logger.Log("Battle Stats");
        Logger.Log($"Winner: {winner.Name.Value}");
        Logger.Log($"Looser: {looser.Name.Value}");
        Logger.Log($"Total Rounds: {i / 2}");
        
}
catch (Exception ex)
{
        Logger.LogError(ex.Message, ex);
}


Console.WriteLine("=============================================");
Console.WriteLine("============== END Assessment 1 =============");
Console.WriteLine("=============================================");