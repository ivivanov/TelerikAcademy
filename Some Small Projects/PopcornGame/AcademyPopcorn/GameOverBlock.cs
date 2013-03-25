using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class GameOverBlock : Block
    {
        public const char Symbol = '_';
        public new const string CollisionGroupString = "gameoverblock";

        public GameOverBlock(MatrixCoords topLeft) : base(topLeft)
        {
            this.body[0, 0] = UnpassableBlock.Symbol;
        }
    }
}