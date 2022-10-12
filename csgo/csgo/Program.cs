using csgo.Models;
using csgo.WeaponEnums;
using System;
using System.Collections.Generic;

namespace csgo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Weapons glock = new Weapons(WeaponEnum.Glock);
            Weapons usp = new Weapons(WeaponEnum.USP);
            Weapons deagle = new Weapons(WeaponEnum.Deagle);
            Weapons ak47 = new Weapons(WeaponEnum.AK47);
            Weapons m4a1s = new Weapons(WeaponEnum.M4A1S);
            Weapons awp = new Weapons(WeaponEnum.AWP);
            Weapons[] weapons =
            {
                glock,
                usp,
                deagle,
                ak47,
                m4a1s,
                awp
            };
            stage:
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"CSGO-ya xos geldiniz\nZehmet olmasa silahinizi secin ve ya proqramdan cixin :)\n0.Programi dayandirmaq");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("1.Glock");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("2.USP");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("3.Deagle");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("4.AK-47");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("5.M4A1-S");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("6.AWP");
            string ansstr;
            byte ansnum;
            ansstr = Console.ReadLine();
            while (!byte.TryParse(ansstr,out ansnum)||ansnum<0||ansnum>6)
            {
                Console.WriteLine("Duzgun secim edin");
                ansstr = Console.ReadLine();
            }
            switch (ansnum)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Selector(glock);
                    Console.Clear();
                    goto stage;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Selector(usp);
                    Console.Clear();
                    goto stage;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Selector(deagle);
                    Console.Clear();
                    goto stage;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Selector(ak47);
                    Console.Clear();
                    goto stage;
                case 5:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Selector(m4a1s);
                    Console.Clear();
                    goto stage;
                case 6:
                    Console.ForegroundColor = ConsoleColor.White;
                    Selector(awp);
                    Console.Clear();
                    goto stage;
                default:
                    return;
            }



        }

        static void Selector(Weapons weapon)
        {
        stage1:
            Console.Clear();
            weapon.ShowWeaponInfo();
            Console.WriteLine("\nSilahin Opsiyalari:\n1.Rengini deyismek\n2.Atis Modunu deyis\n3.Ates acmaq :)\n4.Silahi yeniden doldurmaq\n5.Back to Menu");
            string ansstr;
            byte ansnum;
            ansstr = Console.ReadLine();
            while (!byte.TryParse(ansstr,out ansnum)||ansnum<1||ansnum>5)
            {
                Console.WriteLine("Duzgun deyer secin");
                ansstr = Console.ReadLine();
            }
            Console.Clear();
            switch (ansnum)
            {
                case 5:
                    return;
                case 1:
                    Console.WriteLine("Silahin yeni rengini qeyd edin");
                    string color = Console.ReadLine();
                    ColorChanger(weapon, color);
                    goto stage1;
                case 2:
                    Console.WriteLine("Silahin atis modunu qeyd edin\n1.Semi\n2.Auto\n3.Burst");
                    string ans2str;
                    byte ans2num;
                    ans2str = Console.ReadLine();
                    while (!byte.TryParse(ans2str, out ans2num) || ans2num < 0 || ans2num > 3)
                    {
                        Console.WriteLine("Duzgun deyer secin");
                        ans2str = Console.ReadLine();
                    }
                    switch (ans2num)
                    {
                        case 1:
                            weapon.ShootMode = 1;
                            break;
                        case 2:
                            weapon.ShootMode = 2;
                            break;
                        case 3:
                            weapon.ShootMode = 3;
                            break;
                        default:
                            break;
                    }
                    goto stage1;
                case 3:
                    weapon.Shoot();
                    goto stage1;
                case 4:
                    weapon.Reload();
                    goto stage1;
                default:
                    goto stage1;
                    


            }
        }

        static void ColorChanger(Weapons weapon,string color)
        {
            weapon.Color = color;
        }
        
    }
}
