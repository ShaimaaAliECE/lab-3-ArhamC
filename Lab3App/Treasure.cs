using System;

namespace Lab3App
{
    class Treasure : Collectable
    {
        private int score;

        public Treasure(string description, int score) : base(description)
        {
            this.score = score;
        }

        public void UpdateTotalScore(ref int totalScore)
        {
            totalScore += score;
        }
    }
}
