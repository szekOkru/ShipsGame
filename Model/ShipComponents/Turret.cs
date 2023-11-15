using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships.Model.ShipComponents
{
    public class Turret
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Caliber { get; set; }
        public int DamagePerShot { get; set; }
        public int BarrelsPerTurret { get; set; }
        public int ReloadTime { get; set; }
        public int Accuracy { get; set; }
        public int AmountOfShells { get; set; }
        public int Weight { get; set; }
    }
}
