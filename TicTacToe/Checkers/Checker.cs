using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TicTacToe.Checkers
{
    public class Checker
    {
        public Color Color;
        public bool isKing = false;
        public Checker(Color color, bool king = false)
        {
            this.Color = color;
            isKing = king;
        }
    }
}
