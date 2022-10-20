using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.AnimalModels
{
    enum Gender
    {
        male,
        female
    }

    enum Mood
    {
        angry,
        happy,
        sad,
        aggressive,
        scared,
        excited,
        playful
    }

    internal class Animal
    {
        protected string name;
        protected Gender gender;
        protected bool feelingHunger = true;
        protected bool isAwake = true;
        protected Mood mood = Mood.scared;

        public string Name { get => name; }
        public Gender Gender { get => gender; }

        public Animal(string name, Gender gender)
        {
            this.gender = gender;
            this.name = name;
        }
        public virtual string MakeSound()
        {
            mood = Mood.aggressive;
            return "boooooooooo";
        }

        public void Eat()
        {
            feelingHunger = false;
        }

        public void Sleep()
        {
            isAwake = false;
        }

        public virtual void Mate(Animal partner) 
        {
            if (gender != partner.gender || mood == Mood.excited)
            {
                mood = Mood.happy;
                return;
            }
            
            mood = Mood.angry;

        }

    }
}
