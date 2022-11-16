using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Week_5
{
    public class Weapon
    {
        //name, minimum damage, max damage, isTwoHanded, bonus hit chance
        private string _name;
        private int _minDamage;
        private int _maxDamage;
        private int _bonusHitChance;
        private bool _isTwoHanded;
        private int _charisma;

        public Weapon(string _name, int _minDamage, int _maxDamage, int _bonusHitChance, bool _isTwoHanded, int _charisma)
        {
            this._name = _name;
            this._minDamage = _minDamage;
            this._maxDamage = _maxDamage;
            this._bonusHitChance = _bonusHitChance;
            this._isTwoHanded = _isTwoHanded;
            this._charisma = _charisma;
        }

        //properties
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }

        public int MinDamage
        {
            get { return _minDamage; }
            set
            {
                if (value > 0 && value <= MaxDamage)
                {
                    _minDamage = value;
                }
                else
                {
                    _minDamage = 1;
                }
            }
        }

        public int BonusHitChance
        {
            get { return _bonusHitChance; }
            set { _bonusHitChance = value; }
        }

        public bool IsTwoHanded
        {
            get { return _isTwoHanded; }
            set { _isTwoHanded = value; }
        }

        public int Charisma
        {
            get { return _charisma;}
            set { _charisma = value; }
        }


        //Ability to create a weapon object to be used by the character


    }
}
