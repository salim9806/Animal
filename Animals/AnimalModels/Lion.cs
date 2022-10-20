using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.AnimalModels
{
    internal class Lion:Cat
    {
        protected int numberOfFemales;

        public int NumberOfFemales { 
            get => numberOfFemales;
            set
            {
                if (value > 0)
                    numberOfFemales = value;
            }
        }

        public Lion(string name, Gender gender):base(name, gender, isWild:true)
        {}

        public override string MakeSound()
        {
            return "grrrr igraaaaaaaaauuuuuu";
        }

        public void Hunt()
        {
            if (gender == Gender.female)
            { 
                isAwake = true;
                feelingHunger = true;
                mood = Mood.excited;
            }
            isAwake = false;
        }

        public override void Mate(Animal partner)
        {
            if (partner is Lion)
                base.Mate(partner);
            else
                mood = Mood.angry;
        }   
    }
}
