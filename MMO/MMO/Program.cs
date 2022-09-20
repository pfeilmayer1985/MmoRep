using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MMO
{
    public class Program
    {
        static void Main(string[] args)
        {

            Tank T = new Tank("Tank", 200, 25);
            Healer H = new Healer("Medic", 100, 5, 15);
            Soldier S = new Soldier("Soldier One", 100, 10);
            Soldier S1 = new Soldier("Soldier Two", 100, 12);

            List<Units> playerUnits = new List<Units>() { T, H, S, S1};

            foreach (Units pU in playerUnits)
            {
                pU.UnitDescription();
            }

            
            Console.WriteLine($"A {T.UnitType} attacks a Soldier");
            T.Attack(S);
            S.ActualUnitStats();
            Console.WriteLine($"The {H.UnitType} helps the wounded {S.UnitType}. {S.UnitType} will receive {H.Healpoints} life points back.");
            H.HealUnit(S);
            Console.WriteLine($"{S.UnitType} received {H.Healpoints} life points and now has {S.Life} life.");
            Console.WriteLine($"Both {S.UnitType} and {S1.UnitType} attack the {T.UnitType} and inflict {S.Damage+S1.Damage} total damage.");
            S.Attack(T);
            S1.Attack(T);
            T.ActualUnitStats();
            //Console.WriteLine($"The {T.UnitType} has {T.Life} remaining life.");

            Console.ReadLine();

        }
    }
}
