﻿namespace DiceRollGame.Game

{
    public class Dice
    {
        private readonly Random _random;
        private const int SideCount = 6;

        public Dice(Random random)
        {
            _random = random;
        }

        public int Roll() => _random.Next(1, SideCount);

        public void Description() =>
            Console.WriteLine($"This is a dice with {SideCount} sides.");
    }
}