using System;
using System.Collections.Generic;
using System.Text;
using Week_5;

namespace Week_5
{
    public class Character
    {
        //name, hit chance, max life, health, block, equipped weapon
        private string _name;
        private int _maxHealth;
        private int _hitChance;
        private int _health;
        private int _block;
        private Weapon _weapon;

        public Character(string _name, int _maxHealth, int _hitChance, int _health, int _block, Weapon _weapon)
        {
            this._name = _name;
            this._maxHealth = _maxHealth;
            this._hitChance = _hitChance;
            this._health = _health;
            this._block = _block;
            this._weapon = _weapon;
        }

        public string Name() { return this._name; }

        public int MaxHealth
        {
            get { return this._hitChance; }
            set { this._hitChance = value; }
        }

        public int Health
        {
            get { return _health; }
            set
            { //todo: replace with property name
                if (value <= MaxHealth)
                {
                    _health = value;
                }
                else
                {
                    _health = 1;
                }
            }
        }

        public int HitChance
        {
            get { return _hitChance; }

            set { _hitChance = _weapon.BonusHitChance + value; }
        }

        public int Block
        {
            get { return _block; }
            set { _block = value; }
        }

        public Weapon Weapon
        {
            get { return _weapon; }
            set { _weapon = value; }
        }


        /* TODO:
         *  Ability to create a character object to be used in the dungeon for creating your player and the monsters they battle
            Calculate the hit chance (e.g. player hit chance + weapon bonus hit chance)
            Calculate the damage (e.g. using System.Random to choose a number between the equipped weapon minimum and maximum damage)
         */
    }
}