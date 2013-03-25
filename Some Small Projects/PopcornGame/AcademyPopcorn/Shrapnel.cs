using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class Shrapnel : MovingObject
    {
        public new const string CollisionGroupString = "shrapnel";

        public Shrapnel(MatrixCoords topLeft, MatrixCoords speed) : base(topLeft,new char[,]{{'.'}},speed)
        {
        }
        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == Block.CollisionGroupString;
        }

        public override string GetCollisionGroupString()
        {
            return Shrapnel.CollisionGroupString;
        }
    }
}