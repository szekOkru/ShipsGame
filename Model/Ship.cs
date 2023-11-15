using Ships.Model.ShipComponents;

namespace Ships.Model
{
    public class Ship
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Hull Hull { get; set; }
        public Tower Tower { get; set; }

        // Engine
        public Engine Engine { get; set; }
        public int AmountOfFuel { get; set; }

        // Torpedoes
        public bool HasTorpedoes { get; set; }
        public TorpedoLauncher TorpedoLauncher { get; set; }
        public int AmountOfTorpedoes { get; set; }

        // Turrets
        public Turret Turret { get; set; }
        public int AmountOfTurrets { get; set; }
        public int TotalAmountOfShells { get; set; }

        // Sonar
        public bool HasSonar { get; set; }
        public Sonar Sonar { get; set; }

        // Balistic computer
        public bool HasBalisticComputer { get; set; }
        public BalisticComputer BalisticComputer { get; set; }

        // ASW
        public bool CapableOfAsw { get; set; }
        public AntiSubmarineWarfare AntiSubmarineWarfare { get; set; }
    }
}