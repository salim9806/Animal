using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.AnimalModels
{
    internal class Monkey:Animal
    {
        protected bool isAlpha = false;

        public Monkey(bool isAlpha, string name, Gender gender):base(name, gender)
        {
            this.isAlpha = isAlpha;
            if (gender == Gender.female)
                this.isAlpha = false;
        }

        public override string MakeSound()
        {
            return "Ek Ek Ek Ock Ock Ock Tooky Tooky Tooky";
        }

        public void MakeFire()
        {
            mood = Mood.happy;
        }

        public override void Mate(Animal partner)
        {
            if(partner is Monkey)
            {
                base.Mate(partner);
                    
            }
            else 
                mood = Mood.aggressive;
        }
    }
}
