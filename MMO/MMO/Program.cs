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

            Tanks T = new Tanks("Tank", 200, 25);
            Heiler H = new Heiler("Medic", 100, 5, 15);
            Soldier S = new Soldier("Soldier", 100, 10);

            List<Units> playerUnits = new List<Units>() { T, H, S};

            foreach (Units pU in playerUnits)
            {
                pU.UnitDescription();
            }



            Console.ReadLine();

        }
    }
}
