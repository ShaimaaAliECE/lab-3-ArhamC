using Lab3App;
using System.Collections.Generic;
using System;

class Diamond : Collectable
{
    private int score;

    public Diamond(string description, int score) : base(description)
    {
        this.score = score;
    }

    public override void AddMe(List<Collectable> collected)
    {
        base.AddMe(collected);
        Console.WriteLine($"{Description} Collected, Congrats!!!!");
        this.Board.UpdateTotalScore(score);
    }

    public override void Display()
    {
        Console.WriteLine($"Diamond{Description} is displayed");
    }
}
