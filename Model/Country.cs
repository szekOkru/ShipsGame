using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ships.Model
{
    public class Country
    {
        private List<Ship> Fleet { get; set; }
        private string Name { get; set; }

        public Country(string name)
        {
            Name = name;
            Fleet = new List<Ship>();
        }

        public Ship BuildShip(string name, Ship.Class shipClass, Hull hull, Turret turret, int turretNum)
        {
            Ship newlyBuildShip = new Ship(name, shipClass, hull, turret, turretNum);
            newlyBuildShip.SetId(GetFleetCount());
            Fleet.Add(newlyBuildShip);

            return newlyBuildShip;
        }   
        private int GetFleetCount()
        {
            int FleetCount = Fleet.Count;
            return ++FleetCount;
        }
        public void ShowFleet()
        {
            Console.Clear();
            Console.WriteLine("What do you want to display?\n1. All\n2. Ships\n3. Ship types");

            if(!int.TryParse(Console.ReadLine(), out int response))
                ShowFleet();
            if (response < 1 || response > 2)
                ShowFleet();

            Console.Clear();

            var selectedShips = new List<Ship>();
            switch (response)
            {
                case 1:
                    selectedShips = Fleet.OrderBy(s => s.GetId()).ToList();
                    foreach (var ship in selectedShips)
                    {
                        Console.WriteLine(ship.ShowData());
                    }
                    break;
                case 2:
                    Console.WriteLine("What ships you want to display?\n1. Capital\n2. Screen");
                    if (!int.TryParse(Console.ReadLine(), out int shipsResponse))
                        ShowFleet(); // Remake

                    Console.Clear();
                    switch (shipsResponse)
                    {
                        case 1:
                            selectedShips = GetShipsByIsCapital(true);

                            if (selectedShips == null)
                                return;
                                // Add error handling

                            foreach (var capitalShip in selectedShips)
                            {
                                Console.WriteLine(capitalShip.ShowData());
                            }
                            break;
                        case 2:
                            selectedShips = GetShipsByIsCapital(false);

                            if (selectedShips == null)
                                return;
                            // Add error handling

                            foreach (var capitalShip in selectedShips)
                            {
                                Console.WriteLine(capitalShip.ShowData());
                            }
                            break;
                    }
                    break;
                case 3:
                    // To add
                    break;
            }
        }

        private List<Ship>? GetShipsByIsCapital(bool userChoice)
        {
            if (Fleet.Count <= 0)
                return null;

            if(userChoice == true)
                return Fleet.Where(s => s.GetIsCapital() == true).OrderBy(s => s.GetId()).ToList();
            else
                return Fleet.Where(s => s.GetIsCapital() == false).OrderBy(s => s.GetId()).ToList();

        }
    }
}