/*
// File created by
// Student Number: A00125081
// Student Name: James Simpson
// To view the commit history and the source code go to
// https://github.com/NightcrawlerEX/ADS103_Assessment_1
*/


/// <summary>
/// This class contains the logic related to Task 1
/// This first program will simulate a battle between Role Playing Game (RPG) characters
/// This is a battle game with classes Mage, Warrior, and Paladin
/// </summary>
internal class Task1
{
    private Mage mage;
    private Warrior warrior;
    private Paladin paladin;

    /// <summary>
    /// Constructor initializes the characters for the game
    /// </summary>
    public Task1()
    {
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
    }//end Constructor

    /// <summary>
    /// The run command is used to start and run the battle
    /// </summary>
    public void Run()
    {
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
    }//end Run

}//end