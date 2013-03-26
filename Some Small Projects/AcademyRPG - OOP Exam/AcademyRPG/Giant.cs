using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Giant : Character, IFighter, IGatherer
    {
        private int attackPoints;
        private bool gatheredStone;

        public Giant(string name, Point position)
            : base(name, position, 0)
        {
            this.HitPoints = 200;
            this.attackPoints = 150;
            this.gatheredStone = false;
        }

        public bool GatheredStone
        {
            get
            {
                return this.gatheredStone;
            }
            set
            {
                this.gatheredStone = value;
            }
        }

        public int AttackPoints
        {
            get 
            {
                return attackPoints; 
            }
            private set
            {
                this.attackPoints = value;
            }
        }

        public int DefensePoints
        {
            get { return 80; }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner)
                {
                    return i;
                }
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (this.GatheredStone == false)
            {
                if (resource.Type == ResourceType.Stone)
                {
                    this.GatheredStone = true;
                    this.AttackPoints += 100;
                    return true;
                }
            }
            else
            {
                if (resource.Type == ResourceType.Stone)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
