using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships.Model.ShipComponents
{
    public class Hull
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Armor { get; set; }
        public int Length { get; set; }
        public TorpedoBlister TorpedoBlister { get; set; }
        public int MaximumTonnage { get; set; }
    }

    public enum TorpedoBlister
    {
        None,
        Weak,
        Average,
        Strong,
        Maximum
    }
}
