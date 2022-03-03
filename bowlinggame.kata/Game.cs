using System;
using System.Linq;

namespace bowlinggame.kata;

public class Game
{
    private Int32[] rolls = new Int32[21];
    private Int32 currentRoll = 0;

    public Int32 Score()
    {
        return rolls.Sum();   
    }

    public void Roll(Int32 pins)
    {
        rolls[currentRoll++] = pins;
    }
}