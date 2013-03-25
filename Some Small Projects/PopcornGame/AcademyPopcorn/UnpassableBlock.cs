using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class UnpassableBlock : Block
    {
        public const char Symbol = '=';

        public new const string CollisionGroupString = "unpassableblock";

        public UnpassableBlock(MatrixCoords topLeft) : base(topLeft)
        {
            this.body[0, 0] = UnpassableBlock.Symbol;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
        }

        public override string GetCollisionGroupString()
        {
            return UnpassableBlock.CollisionGroupString;
        }
    }
}
