using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class GiftBlock : Block
    {
        public const char Symbol = '@';
        public new const string CollisionGroupString = "giftblock";

        public GiftBlock(MatrixCoords topLeft) : base(topLeft)
        {
            this.body[0, 0] = GiftBlock.Symbol;
        }
        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> producedObjects = new List<GameObject>();
            if (this.IsDestroyed)
            {
                producedObjects.Add(new Gift(this.topLeft, new MatrixCoords(1, 0)));
            }
            return producedObjects;
        }
    }
}