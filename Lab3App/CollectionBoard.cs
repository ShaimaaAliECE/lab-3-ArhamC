using System;

namespace Lab3App
{
    public class CollectionBoard
    {
        private int totalScore;
        private int totalValue;

        public void UpdateTotalScore(int score)
        {
            totalScore += score;
            Console.WriteLine($"Total Score is updated to: {totalScore}");
        }

        public void UpdateTotalValue(int value)
        {
            totalValue += value;
            Console.WriteLine($"Total Value is updated to: {totalValue}");
        }
    }
}
