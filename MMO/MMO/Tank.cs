using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO
{
    public class Tank : Units
    {
        public Tank(string unittype, int life, int damage)
        {
            UnitType = unittype;
            Life = life;
            Damage = damage;
            MaxLife = life;
        }

        

    }
}
