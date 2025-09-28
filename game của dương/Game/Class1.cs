using System;
using System.Collections.Generic;

namespace Game
{
    public class Class1
    {
        private int score;
        private List<string> enemies;
        private Random random;

        public Class1()
        {
            score = 0;
            random = new Random();
            enemies = new List<string>();
            SpawnEnemies();
        }

        private void SpawnEnemies()
        {
            string[] words = { "cat", "dog", "apple", "banana", "code", "java", "ship", "game" };
            while (enemies.Count < 5)
            {
                enemies.Add(words[random.Next(words.Length)]);
            }
        }

        public GameState GetState(string word)
        {
            if (!string.IsNullOrEmpty(word) && enemies.Contains(word))
            {
                enemies.Remove(word);
                score += 10;
            }

            if (enemies.Count < 5)
                SpawnEnemies();

            return new GameState
            {
                Score = score,
                Enemies = enemies.ToArray()
            };
        }
    }

    public class GameState
    {
        public int Score { get; set; }
        public string[] Enemies { get; set; }
    }
}
