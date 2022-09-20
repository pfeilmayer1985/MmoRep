using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO
{
    public class Heiler : Units
    {
        public int Heal { get; set; }
        public Heiler(string unittype, int life, int damage, int heal)
        {
            UnitType = unittype;
            Life = life;
            Damage = damage;
            Heal = heal;
        }
    
        public void HealUnit (Units healme)
        {
            healme.Life += Heal;
        }

    
    }
}
