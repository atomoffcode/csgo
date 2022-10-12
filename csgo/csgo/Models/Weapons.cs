using csgo.WeaponEnums;
using System;
using System.Collections.Generic;
using System.Text;

namespace csgo.Models
{
    class Weapons
    {
        public int ShootMode = 0;
        public int BulletCapacity;
        public int Bullets;
        private string _color="default";
        public string Color
        {
            get => _color;
            set
            {
                _color = value;
            }
        }
        public WeaponEnum Weapon;



        
        public Weapons(WeaponEnum weapon)
        {
            Weapon = weapon;
            BulletCapacity = BCF(weapon);
            Bullets = BulletCapacity;
        }

        public void ShowWeaponInfo()
        {
            string mode;
            switch (ShootMode)
            {
                case 1:
                    mode = "Semi";
                    break;
                case 2:
                    mode = "Auto";
                    break;
                case 3:
                    mode = "Burst";
                    break;
                default:
                    mode = "Disabled";
                    break;
            }
            Console.WriteLine($"Model:{Weapon.ToString()};  Color:{_color};  Mode:{mode};  Bullets:{Bullets}/{BulletCapacity}");
        }
        public void Reload()
        {
            Bullets = BulletCapacity;
        }

        public void Shoot()
        {
            while (Bullets > 0)
            {


                switch (ShootMode)
                {
                    case 0:
                        Console.WriteLine("Atisdan once Silahin Atis Modunu secin!!!");
                        Console.ReadKey();
                        return;
                    case 1:
                        Bullets -= 1;
                        return;
                    case 2:
                        if (Weapon == WeaponEnum.AWP || Weapon == WeaponEnum.USP || Weapon == WeaponEnum.Deagle || Weapon == WeaponEnum.Glock)
                        {
                            Console.WriteLine("Avto atis rejimi bu silahda movcud deyil!!!");
                            Console.ReadKey();
                            return;
                        }
                        else
                        {
                            Bullets = 0;
                            return;
                        }
                    case 3:
                        if (Weapon == WeaponEnum.Glock)
                        {
                            if (Bullets==2)
                            {
                                Bullets -= 2;
                            }
                            else
                            {
                                Bullets -= 3;
                            }
                            return;
                        }
                        else
                        {
                            Console.WriteLine("Burst atis rejimi bu silahda movcud deyil!!!");
                            Console.ReadKey();
                            return;
                        }
                    default:
                        Console.WriteLine("Duzgun atis modu secin!!!");
                        Console.ReadKey();
                        return;
                }
            }
            Console.WriteLine("Silahinizin daragi bosdur, yeniden doldurun");
            Console.ReadKey();
            return;
        }
        static byte BCF(WeaponEnum weapon)
        {
            
            switch (weapon)
            {
                case WeaponEnum.Glock:
                    return  20;
                case WeaponEnum.USP:
                    return  12;
                case WeaponEnum.Deagle:
                    return  7;
                case WeaponEnum.AK47:
                    return  30;
                case WeaponEnum.M4A1S:
                    return  20;
                case WeaponEnum.AWP:
                    return 10;
                default:
                    return  0;


            }
        }
    }
}
