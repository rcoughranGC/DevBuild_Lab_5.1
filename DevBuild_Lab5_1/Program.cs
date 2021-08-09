using System;
using System.Collections.Generic;

namespace DevBuild_Lab5_1
{

    class GameCharacter
    {
        private string _name;
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }

        private int _strength;
        public int strength
        {
            get { return _strength; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                else if (value >1000)
                {
                    value = 1000;
                }
                _strength = value; 
            }
        }

        private int _intelligence;
        public int intelligence
        {
            get { return _intelligence; }
            set
            {
                if (value < 0)
                {
                    value = 0;
                }
                else if (value > 1000)
                {
                    value = 1000;
                }
                _intelligence = value;
            }
        }

        public GameCharacter(string name, int strength, int intelligence)
        {
            this.name = name;
            this.strength = strength;
            this.intelligence = intelligence;
        }
        
        public virtual void Play()
        {
            Console.WriteLine($"Character Name: {_name}\nStrength: {_strength}\nIntelligence: {_intelligence}");
        }

    }
    class Warrior : GameCharacter
    {
        private string _weaponType;
        public string weaponType
        {
            get { return _weaponType; }
            set { _weaponType = value; }
        }
        public Warrior(string name, int strength, int intelligence, string weaponType) : base(name, strength, intelligence) // I dont know if this is what we're supposed to do, b/c it gets to 
        {                                                                                                                   // be a bit much later on down further.
            this.weaponType = weaponType;
        }
        
        public override void Play()
        {
            Console.WriteLine($"Character Name: {name}\n Strength: {strength}\n Intelligence: {intelligence} \n Weapon Type: {weaponType}"); //what goes here? the public property or private field?
        }

    }
    
    class MagicCharacter : GameCharacter
    {
        private int _magicalEnergy;

        public int magicalEnergy
        {
            get { return _magicalEnergy; }
            set { _magicalEnergy = value; }
        }

        public MagicCharacter(string name, int strength, int intelligence, int magicalEnergy) : base(name, strength, intelligence)
        {
            this.magicalEnergy = magicalEnergy;
        }
        public override void Play()
        {
            Console.WriteLine($"Character Name: {name}\n Strength: {strength}\n Intelligence: {intelligence} \n Magic Energy: {magicalEnergy}");
        }
    }
    class Wizard : MagicCharacter
    {
        private int _spellNumber;
       
        public int spellNumber
        {
            get { return _spellNumber; }
            set { _spellNumber = value; }
        }


        public Wizard(string name, int strength, int intelligence, int magicalEnergy, int spellNumber) : base(name, strength, intelligence, magicalEnergy)
        {
            this.spellNumber = spellNumber;
        }
        public override void Play()
        {
            Console.WriteLine($"Character Name: {name}\n Strength: {strength}\n Intelligence: {intelligence} \n Magic Energy: {magicalEnergy} \n Spells: {spellNumber}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<GameCharacter> gameCharacters = new List<GameCharacter>();
            gameCharacters.Add(new Warrior("Conan", 600, 100, "Atantean Sword"));
            gameCharacters.Add(new Warrior("Heman", 1200, 60, "Power Sword"));
            gameCharacters.Add(new Wizard("Merlin", 80, 800, 200, 60));
            gameCharacters.Add(new Wizard("Gandalf", 140, 1200, 600, 190));
            gameCharacters.Add(new Wizard("Dumbledor", 99, 600, 120, 40));

            foreach (GameCharacter character in gameCharacters)
            {
                character.Play();
            }
        }
    }
}
