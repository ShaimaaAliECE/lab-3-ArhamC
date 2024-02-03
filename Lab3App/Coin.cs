using Lab3App;
using System.Collections.Generic;
using System;

class Coin : Collectable
{
    private int value;
    private int score;

    public Coin(string description, int value, int score) : base(description)
    {
        this.value = value;
        this.score = score;
    }

    public override void AddMe(List<Collectable> collected)
    {
        base.AddMe(collected);
        Console.WriteLine($"{Description} Collected, Congrats!!!!");
        this.Board.UpdateTotalScore(score);
        this.Board.UpdateTotalValue(value);
    }

    public override void Display()
    {
        Console.WriteLine($"Coin {Description} is displayed");
    }
}

