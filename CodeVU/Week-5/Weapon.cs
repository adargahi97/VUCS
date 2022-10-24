using System;
using System.Collections.Generic;
using System.Text;

namespace Week_5
{
    public class Weapon
    {
        //name, minimum damage, max damage, isTwoHanded, bonus hit chance
        private string name;
        private int _minDamage;
        private int _maxDamage;
        private int _bonusHitChance;
        private bool _isTwoHanded;

        public Weapon(string name, int _minDamage, int _maxDamage, int _bonusHitChance, bool _isTwoHanded)
        {
            this.name = name;
            this._minDamage = _minDamage;
            this._maxDamage = _maxDamage;
            this._bonusHitChance = _bonusHitChance;
            this._isTwoHanded = _isTwoHanded;
        }

        //properties
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


        //Ability to create a weapon object to be used by the character
    }
}
