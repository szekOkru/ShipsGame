using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ships.Model
{
    public class Ship
    {
        private int Id { get; set; }
        private string Name { get; set; }
        private Class ShipClass { get; set; }
        private bool IsCapital { get; set; }
        private Hull Hull { get; set; }
        private Turret Turret { get; set; }
        private int TotalAmmo { get; set; }
        private int TurretsNum { get; set; }
        
        public enum Class
        {
            Destroyer,
            LightCruiser,
            HeavyCruiser,
            BattleCruiser,
            Battleship
        }

        // Constructor
        public Ship(string name, Class shipClass, Hull hull, Turret turret, int turretsNum)
        {
            Name = name;
            ShipClass = shipClass;
            IsCapital = GenerateRole();
            Hull = hull;
            Turret = turret;
            TotalAmmo = turretsNum * turret.GetAmmo();
            TurretsNum = turretsNum;
        }

        // Methods
        public void SetId(int shipId)
        {
            Id = shipId;
        }
        private bool GenerateRole()
        {
            if (ShipClass == Class.BattleCruiser || ShipClass == Class.Battleship)
                return true;
            else
                return false;
        }
        public bool GetIsCapital() => IsCapital;
        public bool GetName() => IsCapital;
        public int GetId() => Id;
        public string ShowData()
        {
            return $"Id: {Id}\nName: {Name}\nShipClass: {ShipClass}\nIsCapital: {IsCapital}\nHull: {Hull.ShowData()}\nTurret: {Turret.ShowData()}\nTotalAmmo: {TotalAmmo}\nTurretsNum: {TurretsNum}\n";
        }
    }
}