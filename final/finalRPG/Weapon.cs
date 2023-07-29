using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

public abstract class Weapon
{
    protected string Name { get; set; }
    protected double BaseDamage { get; set; }

    public virtual double CalculateDamage(int playerLevel)
    {
        int diceRoll = RollDice();
        double damageIncreasePercentage = GetDamageIncreasePercentage(diceRoll);
        double magicIncreasePercentage = GetMagicIncreasePercentage(playerLevel);
        double totalDamage = BaseDamage * (1 + damageIncreasePercentage / 100) * (1 + magicIncreasePercentage / 100);
        return totalDamage;
    }

    private int RollDice()
    {
        // Simulate rolling the dice to get a random value between 1 and 6 (inclusive)
        Random random = new Random();
        return random.Next(1, 7);
    }

    protected double GetDamageIncreasePercentage(int diceRoll)
    {
        // Calculate damage increase percentage based on dice roll
        double[] percentages = { 0, 0, 20, 30, 40, 50, 60 };
        return percentages[diceRoll];
    }

    protected double GetMagicIncreasePercentage(int playerLevel)
    {
        // Calculate magic damage increase percentage based on player level
        double[] magicPercentages = { 0, 40, 60, 80, 100 };
        return magicPercentages[Math.Min(playerLevel - 1, 4)];
    }
}

