using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Ninja : Character, IFighter, IGatherer
    {
        private int attackPoints;

        public Ninja(string name, Point position, int owner) : base(name, position, owner)
        {
            this.HitPoints = 1;
            this.attackPoints = 0; 
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
            get
            {
                return int.MaxValue;
            }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            if (availableTargets.Count != 0)
            {
                List<WorldObject> sortedByHitpoints = availableTargets.OrderBy(x => x.HitPoints).ToList<WorldObject>();
           
                for (int i = 0; i < availableTargets.Count; i++)
                {
                    if (sortedByHitpoints[i].Owner != this.Owner && sortedByHitpoints[i].Owner != 0)
                    {
                        int correctIndex = availableTargets.IndexOf(sortedByHitpoints[i]);
                        return correctIndex;
                    }
                }
            }
            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                this.AttackPoints += resource.Quantity * 2;
                return true;
            }
            if (resource.Type == ResourceType.Lumber)
            {
                this.AttackPoints += resource.Quantity;
                return true;
            }

            return false;
        }
    }
}