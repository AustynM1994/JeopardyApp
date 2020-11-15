using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeopardyApp
{
    [Serializable]
    class Player
    {
        private string name;
        private int score;

        public string Name { get => name; set => name = value; }
        public int Score { get => score; set => score = value; }

        public Player()
        {

        }

        public Player(string name, int score)
        {
            this.Name = name;
            this.Score = score;
        }

        public override string ToString()
        {
            return $"Player Name: {name}, Player Score: {score}";
        }
    }
}
