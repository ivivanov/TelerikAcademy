using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class ExplodingBlock : Block
    {
        public const char Symbol = 'E';
        public new const string CollisionGroupString = "explodingblock";

        public ExplodingBlock(MatrixCoords topLeft):base(topLeft)
        {
            this.body[0, 0] = ExplodingBlock.Symbol;
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> producedObjects = new List<GameObject>();
            if (this.IsDestroyed)
            {
                producedObjects.Add(new Shrapnel(this.topLeft, new MatrixCoords(0, 1)));
                producedObjects.Add(new Shrapnel(this.topLeft, new MatrixCoords(1, 0)));
                producedObjects.Add(new Shrapnel(this.topLeft, new MatrixCoords(0, -1)));
                producedObjects.Add(new Shrapnel(this.topLeft, new MatrixCoords(-1, 0)));
                producedObjects.Add(new Shrapnel(this.topLeft, new MatrixCoords(1, 1)));
                producedObjects.Add(new Shrapnel(this.topLeft, new MatrixCoords(1, -1)));
                producedObjects.Add(new Shrapnel(this.topLeft, new MatrixCoords(-1, 1)));
                producedObjects.Add(new Shrapnel(this.topLeft, new MatrixCoords(-1, -1)));
            }
            return producedObjects;
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }

        public override string GetCollisionGroupString()
        {
            return ExplodingBlock.CollisionGroupString;
        }
    }
}
