using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class MeteoriteBall : Ball, IObjectProducer
    {
        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed) : base(topLeft ,speed)
        {
        }

        public override IEnumerable<GameObject> ProduceObjects()
        {
            List<GameObject> producedObjects = new List<GameObject>();
            producedObjects.Add(new TrailObject(base.topLeft, new char[,] { { '*' } },3));
            return producedObjects;
        }
    }
}