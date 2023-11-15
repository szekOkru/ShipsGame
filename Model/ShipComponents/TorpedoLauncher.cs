using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships.Model.ShipComponents
{
    public class TorpedoLauncher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Speed { get; set; }
        public int Size { get; set; }
        public int AmountOfTorpedoes { get; set; }
        public Detection Detection { get; set; }
        public int Weight { get; set; }
    }

    public enum Detection
    {
        Stealth,
        Normal,
        HighlyVisible
    }
}
