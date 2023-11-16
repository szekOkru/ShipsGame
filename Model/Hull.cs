using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships.Model
{
    public class Hull
    {
        private int Health { get; set; }
        private int Armor { get; set; }

        // Constructor
        public Hull(int health, int armor)
        {
            Health = health;
            Armor = armor;
        }
        public string ShowData()
        {
            return $"\n Health: {Health}\n Armor: {Armor}";
        }
    }
}
