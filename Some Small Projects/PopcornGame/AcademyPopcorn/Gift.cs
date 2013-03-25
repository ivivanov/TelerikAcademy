using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class Gift : MovingObject
    {
        public const char Symbol = 'G';
        public new const string CollisionGroupString = "gift";


        public Gift(MatrixCoords topLeft, MatrixCoords speed) : base(topLeft,new char[,] { { Symbol } },speed)
        {
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "racket";
        }

        public override string GetCollisionGroupString()
        {
            return Gift.CollisionGroupString;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
    }
}