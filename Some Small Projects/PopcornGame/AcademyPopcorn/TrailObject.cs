using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyPopcorn
{
    public class TrailObject : GameObject
    {
        int lifeTime;

        public TrailObject(MatrixCoords topLeft,char[,] body,int lifeTime):base(topLeft,body)
        {
            this.lifeTime = lifeTime;
        }
        public override void Update()
        {
            lifeTime--;
            if (lifeTime <= 0)
            {
                this.IsDestroyed = true;
            }
        }
    }
}
