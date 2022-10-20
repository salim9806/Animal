using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.AnimalModels
{
    enum WaterHabitat
    {
        freshWater,
        saltWater
    }

    internal class Fish:Animal
    {

        protected WaterHabitat habitat;

        public Fish(string name, WaterHabitat habitat, Gender gender):base(name, gender)
        {
            this.habitat = habitat;
        }

        public override string MakeSound()
        {
            return "Buhb Buhb Buhb";
        }

        public void Hide()
        {
            mood = Mood.scared;
            isAwake = true;
        }

        public override void Mate(Animal partner)
        {
            if (partner is Fish)
            {
                base.Mate(partner);

            }
            else
                mood = Mood.aggressive;
        }
    }
}
