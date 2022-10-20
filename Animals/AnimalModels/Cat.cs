using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace Animals.AnimalModels
{
    internal class Cat:Animal
    {
        protected bool isWild=false;

        public bool IsWild {
            get
            {
                return isWild;
            }
        }

        public Cat(string name, Gender gender, bool isWild):base(name, gender)
        {
            this.isWild = isWild;
        }

        public override string MakeSound()
        {
            return "Miaow Miaow";
        }

        public void FollowLaserPoint()
        {
            mood = Mood.playful;
            isAwake = true;
            feelingHunger = false;
        }

        public override void Mate(Animal partner)
        {
            if (partner is Cat)
                base.Mate(partner);
            else
                mood = Mood.aggressive;
        }
    }
}
