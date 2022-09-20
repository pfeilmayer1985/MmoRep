using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO
{
    public class Healer : Units
    {
        public int Healpoints { get; set; }
        public Healer(string unittype, int life, int damage, int healpoints)
        {
            UnitType = unittype;
            Life = life;
            Damage = damage;
            Healpoints = healpoints;
            MaxLife = life;

        }

        public void HealUnit (Units healme)
        {
            healme.Life += Healpoints;
        }

    
    }
}
