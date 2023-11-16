using Ships.Model;

class Program
{
    static void Main(string[] args)
    {
        Country Germany = new Country("Germany");

        Germany.BuildShip("Bismark", Ship.Class.Battleship, new Hull(10000, 250), new Turret(Turret.GunSize.Fifteen, Turret.BarrelsNumber.Dual), 4);
        Germany.BuildShip("Tirpitz", Ship.Class.Battleship, new Hull(11000, 230), new Turret(Turret.GunSize.Fifteen, Turret.BarrelsNumber.Triple), 4);

        Germany.BuildShip("D1", Ship.Class.Destroyer, new Hull(1100, 10), new Turret(Turret.GunSize.Four, Turret.BarrelsNumber.Dual), 4);
        Germany.BuildShip("D23", Ship.Class.Destroyer, new Hull(1500, 15), new Turret(Turret.GunSize.Four, Turret.BarrelsNumber.Triple), 3);

        Germany.ShowFleet();
    }
}