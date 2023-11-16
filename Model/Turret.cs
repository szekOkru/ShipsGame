using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Ships.Model.Turret;
using static System.Net.Mime.MediaTypeNames;

namespace Ships.Model
{
    public class Turret
    {
        private string Name { get; set; }
        private GunSize Caliber { get; set; }
        private BarrelsNumber BarrelsNum { get; set; }
        private int Ammo { get; set; }

        public enum BarrelsNumber
        {
            Single = 1,
            Dual = 2,
            Triple = 3,
            Quadruple = 4,
        }
        public enum GunSize
        {
            Four = 1,
            Eight = 2,
            Fifteen = 3,
        }

        // Constructor
        public Turret(GunSize caliber, BarrelsNumber barrelsNumber)
        {
            Name = GenerateName(caliber, barrelsNumber);
            Caliber = caliber;
            BarrelsNum = barrelsNumber;
            Ammo = CalculateAmmo(barrelsNumber);
        }

        // Methods
        private static string GenerateName(GunSize caliber, BarrelsNumber barrelsNumber)
        {
            switch (barrelsNumber)
            {
                case BarrelsNumber.Single:
                    return $"{caliber}' 1x Turret";
                case BarrelsNumber.Dual:
                    return $"{caliber}' 2x Turret";
                case BarrelsNumber.Triple:
                    return $"{caliber}' 3x Turret";
                case BarrelsNumber.Quadruple:
                    return $"{caliber}' 4x Turret";
                default:
                    return "You shouldn't be seeing this!";
            }
        }
        private static int CalculateAmmo(BarrelsNumber barrelsNumber) => (int)barrelsNumber * 100;
        public int GetAmmo() => Ammo;
        public string ShowData()
        {
            return $"\n Name: {Name}\n Caliber: {Caliber}\n BarrelsNum: {BarrelsNum}\n Ammo: {Ammo}";
        }
    }

}