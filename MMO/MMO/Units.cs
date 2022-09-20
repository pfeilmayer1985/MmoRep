using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO
{
    public class Units
    {
        public string UnitType { get; set; }
        public int Life { get; set; }
        public int Damage { get; set; }



        public void Attack(Units atack)
        {
            atack.Life -= Damage;
        }


        public void UnitDescription()
        {
            Console.WriteLine($"This unit is a {this.GetType().Name}. Initial life is {Life} and can inflict {Damage} damage.");
        }

        public void ActualUnitStats()
        {
            Console.WriteLine($"This {this.GetType().Name} has taken a {Damage} hit points damage and hast {Life} remaining life");
        }


    }


}
