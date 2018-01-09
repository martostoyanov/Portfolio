using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PvP_Battle_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Champion player1 = new Champion(300, 2000, 0.5, 3.5);
            Champion player2 = new Champion(300, 2000, 0.5, 3.5);

            int proverka = 999;
            double player1_points = 10;
            double player2_points = 10;
            double points_remaining = 0;
            double player1_hp = 0;
            double player2_hp = 0;

            Console.WriteLine("Статистики:");
            Console.WriteLine("Сила: 1 точка - +10% към силата на удара");
            Console.WriteLine("Издръжливост: 1 точка - +15% бонус към базовата кръв и 7.5% към защитата");
            Console.WriteLine("Бързина: 1 точка - + 0.1 удара за секунда");
            Console.WriteLine("Сръчност: 1 точка - +1 към DPS ");
            Console.WriteLine();
            Console.WriteLine("Базови:");
            Console.WriteLine("Кръв: " + player1.hp);
            Console.WriteLine("Защита: " + player1.defense);
            Console.WriteLine("Базова атака: " + player1.attack_dmg);
            Console.WriteLine("Удара за секунда: " + player1.attack_speed);
            Console.WriteLine("DPS: " + player1.dps);
            Console.ReadLine();
            Console.Write("Въведете максимален брой рундове: ");
            int battle = int.Parse(Console.ReadLine());
            //Герой 1
            Console.Write("Въведе име на Герой 1: ");
            string champion_name1 = Console.ReadLine();
            Console.Write("Въведете точки Сила: ");
            player1.strenght = double.Parse(Console.ReadLine());
            points_remaining = player1_points - player1.strenght;
            for (int i = 0; i < proverka; i++)
            {
                if (player1.strenght > 5)
                {
                    Console.WriteLine("Моля въведете наново");
                    points_remaining = 10;
                    Console.Write("Въведете точки Сила: ");
                    player1.strenght = double.Parse(Console.ReadLine());
                    points_remaining = player1_points - player1.strenght;
                }
            }
            Console.WriteLine("Остават " + points_remaining + " точки");
            Console.Write("Въведете точки Издръжливост: ");
            player1.endurance = double.Parse(Console.ReadLine());
            points_remaining = points_remaining - player1.endurance;
            Console.WriteLine("Остават " + points_remaining + " точки");

            for (int i = 0; i < proverka; i++)
            {
                if (player1.endurance > 5)
                {

                    Console.WriteLine("Моля въведете наново");
                    Console.Write("Въведете точки Издръжливост: ");
                    player1.endurance = double.Parse(Console.ReadLine());
                    points_remaining = points_remaining - player1.endurance;
                    Console.WriteLine("Остават " + points_remaining + " точки");
                }
            }
            if (points_remaining == 0)
            {
                Console.WriteLine("Няма повече точки за разпределяне");
            }
            Console.Write("Въведете точки Бързина: ");
            player1.agility = double.Parse(Console.ReadLine());
            points_remaining = points_remaining - player1.agility;
            Console.WriteLine("Остават " + points_remaining + " точки");
            for (int i = 0; i < proverka; i++)
            {
                if (player1.agility > 5)
                {
                    Console.WriteLine("Моля въведете наново");
                    Console.Write("Въведете точки Бързина: ");
                    player1.agility = double.Parse(Console.ReadLine());
                    points_remaining = points_remaining - player1.agility;
                    Console.WriteLine("Остават " + points_remaining + " точки");
                }
            }
            if (points_remaining >= 6)
            {
                Console.WriteLine("Имате {0} точки останали за последният скил от макс 5! Стартирайте и въведете отново.", points_remaining);
                Environment.Exit(0);
            }
            else {
                player1.dexterity = points_remaining;
                Console.WriteLine("Точки Сръчност: " + player1.dexterity);
            }

            Console.WriteLine("Финален Билд: " + " " + player1.strenght + " " + player1.endurance + " " + player1.agility + " " + player1.dexterity);

            double final_health1 = player1.hp + (player1.hp * (player1.endurance * 0.10));
            double final_damage1 = player1.attack_dmg + (player1.attack_dmg * (player1.strenght * 0.15));
            double final_atack_sp1 = player1.attack_speed + (player1.agility * 0.1);
            double final_def1 = player1.defense + (player1.defense * (player1.endurance * 0.05));
            double final_dps1 = ((final_damage1 * final_atack_sp1) / 60) + player1.dexterity;
            Console.WriteLine();
            Console.WriteLine("Финален преглед на Герой 1:");
            Console.WriteLine("Име: " + champion_name1);
            Console.WriteLine("Kръв: " + final_health1);
            Console.WriteLine("Сила на удара: " + final_damage1);
            Console.WriteLine("Брой удара в секунда: " + final_atack_sp1);
            Console.WriteLine("Защита: " + final_def1);
            Console.WriteLine("DPS: " + final_dps1);
            Console.WriteLine();
            //Герой 2
            Console.Write("Въведе име на Герой 2: ");
            string champion_name2 = Console.ReadLine();
            double points_remaining_p2 = 0;
            Console.Write("Въведете точки Сила: ");
            player2.strenght = double.Parse(Console.ReadLine());
            points_remaining_p2 = player2_points - player2.strenght;
            for (int i = 0; i < proverka; i++)
            {
                if (player2.strenght > 5)
                {
                    Console.WriteLine("Моля въведете наново");
                    points_remaining_p2 = 10;
                    Console.Write("Въведете точки Сила: ");
                    player2.strenght = double.Parse(Console.ReadLine());
                    points_remaining_p2 = player2_points - player2.strenght;
                }
            }

            Console.WriteLine("Остават " + points_remaining_p2 + " точки");
            Console.Write("Въведете точки Издръжливост: ");
            player2.endurance = double.Parse(Console.ReadLine());
            points_remaining_p2 = points_remaining_p2 - player2.endurance;
            Console.WriteLine("Остават " + points_remaining_p2 + " точки");
            for (int i = 0; i < proverka; i++)
            {
                if (player2.endurance > 5)
                {
                    Console.WriteLine("Моля въведете наново");
                    Console.Write("Въведете точки Издръжливост: ");
                    player2.endurance = double.Parse(Console.ReadLine());
                    points_remaining_p2 = points_remaining_p2 - player2.endurance;
                    Console.WriteLine("Остават " + points_remaining_p2 + " точки");
                }
            }

            if (points_remaining_p2 == 0)
            {
                Console.WriteLine("Няма повече точки за разпределяне");
            }  
            Console.Write("Въведете точки Бързина: ");
            player2.agility = double.Parse(Console.ReadLine());
            points_remaining_p2 = points_remaining_p2 - player2.agility;
            Console.WriteLine("Остават " + points_remaining + " точки");
            for (int i = 0; i < proverka; i++)
            {
                if (player2.agility > 5)
                {
                    Console.WriteLine("Моля въведете наново");
                    Console.Write("Въведете точки Бързина: ");
                    player2.agility = double.Parse(Console.ReadLine());
                    points_remaining_p2 = points_remaining_p2 - player1.agility;
                    Console.WriteLine("Остават " + points_remaining_p2 + " точки");
                }
            }
            if (points_remaining_p2 == 0)
            {
                Console.WriteLine("Няма повече точки за разпределяне");
            }
            else if (points_remaining_p2 >= 6)
            {
                Console.WriteLine("Имате {0} точки останали за последният скил от макс 5! Стартирайте и въведете отново.", points_remaining);
                Environment.Exit(0);
            }
            else {
                player2.dexterity = points_remaining_p2;
                Console.WriteLine("Точки Сръчност: " + player2.dexterity);
            }

            Console.WriteLine("Финален Билд: " + " " + player2.strenght + " " + player2.endurance + " " + player2.agility + " " + player2.dexterity);

            double final_health2 = player2.hp + (player2.hp * (player2.endurance * 0.15));
            double final_damage2 = player2.attack_dmg + (player2.attack_dmg * (player2.strenght * 0.10));
            double final_atack_sp2 = player2.attack_speed + (player2.agility * 0.1);
            double final_def2 = player2.defense + (player2.defense * (player2.endurance * 0.05));
            double final_dps2 = ((final_damage2 * final_atack_sp2) / 60) + player2.dexterity;
            Console.WriteLine();
            Console.WriteLine("Финален преглед на Герой 2:");
            Console.WriteLine("Име: " + champion_name2);
            Console.WriteLine("Kръв: " + final_health2);
            Console.WriteLine("Сила на удара: " + final_damage2);
            Console.WriteLine("Брой удара в секунда: " + final_atack_sp2);
            Console.WriteLine("Защита: " + final_def2);
            Console.WriteLine("DPS: " + final_dps2);
            Console.WriteLine();
            Console.ReadLine();
            //Condition 1
            if (final_atack_sp1 > final_atack_sp2)
            {
                Console.WriteLine("Герой 1 ще удари първи!");
                Console.WriteLine("Рунд 1");
                player2_hp = final_health2 - (final_dps1 - final_def2);
                Console.WriteLine("Герой 2 остава с " + player2_hp + " кръв.");
                player1_hp = final_health1 - (final_dps2 - final_def1);
                Console.WriteLine("Герой 1 остава с " + player1_hp + " кръв.");
                for (int i = 2; i <= battle; i++)
                {
                        Console.WriteLine("Рунд " + i);
                        player2_hp = player2_hp - (final_dps1 - final_def2);
                        Console.WriteLine("Герой 2 остава с " + player2_hp + " кръв.");
                        player1_hp = player1_hp - (final_dps2 - final_def1);
                        Console.WriteLine("Герой 1 остава с " + player1_hp + " кръв.");
                    if (player1_hp <= 0)
                    {
                        Console.WriteLine("Герой 2 с име " + champion_name2 + " e победител!");
                        break;
                    }
                    else if (player2_hp <= 0)
                    {
                        Console.WriteLine("Герой 1 с име " + champion_name1 + " e победител!");
                        break;
                    }
                }
                if (player2_hp == player1_hp || player1_hp == player2_hp)
                {
                    Console.WriteLine("Няма победител!");
                }
                else if (player1_hp <= player2_hp)
                {
                    Console.WriteLine("Герой 2 с име " + champion_name2 + " e победител, защото има повече кръв!");
                }
                else if (player2_hp <= player1_hp)
                {
                    Console.WriteLine("Герой 1 с име " + champion_name1 + " e победител, защото има повече кръв!");
                }
            }
            //Condition 2
            else if (final_atack_sp2 > final_atack_sp1)
                {
                    Console.WriteLine("Герой 2 ще удари първи!");
                    Console.WriteLine("Рунд 1");
                    player1_hp = final_health1 - (final_dps2 - final_def1);
                    Console.WriteLine("Герой 1 остава с " + player1_hp + " кръв.");
                    player2_hp = final_health2 - (final_dps1 - final_def2);
                    Console.WriteLine("Герой 2 остава с " + player2_hp + " кръв.");
                for (int i = 2; i <= battle; i++)
                {
                    Console.WriteLine("Рунд " + i);
                    player1_hp = player1_hp - (final_dps2 - final_def1);
                    Console.WriteLine("Герой 1 остава с " + player1_hp + " кръв.");
                    player2_hp = player2_hp - (final_dps1 - final_def2);
                    Console.WriteLine("Герой 2 остава с " + player2_hp + " кръв.");
                    if (player1_hp <= 0)
                    {
                        Console.WriteLine("Герой 2 с име " + champion_name2 + " e победител!");
                        break;
                    }
                    else if (player2_hp <= 0)
                    {
                        Console.WriteLine("Герой 1 с име " + champion_name1 + " e победител!");
                        break;
                    }
                }
                if (player2_hp == player1_hp || player1_hp == player2_hp)
                {
                    Console.WriteLine("Няма победител!");
                }
                else if (player1_hp <= player2_hp)
                {
                    Console.WriteLine("Герой 2 с име " + champion_name2 + " e победител, защото има повече кръв!");
                }
                else if (player2_hp <= player1_hp)
                {
                    Console.WriteLine("Герой 1 с име " + champion_name1 + " e победител, защото има повече кръв!");
                }

            }
                //Condition 3
                else
                {
                    Console.WriteLine("Двата героя ще се ударят едновременно.");
                    Console.WriteLine("Рунд 1:");
                    player2_hp = final_health2 - (final_dps1 - final_def2);
                    Console.WriteLine("Герой 2 остава с " + player2_hp + " кръв.");
                    player1_hp = final_health1 - (final_dps2 - final_def1);
                    Console.WriteLine("Герой 1 остава с " + player1_hp + " кръв.");
                        for (int i = 2; i <= battle; i++)
                        {
                            Console.WriteLine("Рунд " + i);
                            player2_hp = player2_hp - (final_dps1 - final_def2);
                            Console.WriteLine("Герой 2 остава с " + player2_hp + " кръв.");
                            player1_hp = player1_hp - (final_dps2 - final_def1);
                            Console.WriteLine("Герой 1 остава с " + player1_hp + " кръв.");
                                if (player1_hp <= 0 && player2_hp <= 0)
                                {
                                    Console.WriteLine("Двата героя се убиха взаимно. Damn son.");
                                    break;
                                }
                                else if (player1_hp <= 0)
                                {
                                    Console.WriteLine("Герой 2 с име " + champion_name2 + " e победител!");
                                    break;
                                }
                                else if (player2_hp <= 0)
                                {
                                    Console.WriteLine("Герой 1 с име " + champion_name1 + " e победител!");
                                    break;
                                }
                }
                if (player2_hp == player1_hp || player1_hp == player2_hp)
                {
                    Console.WriteLine("Няма победител!");
                }
                else if (player1_hp <= player2_hp)
                {
                    Console.WriteLine("Герой 2 с име " + champion_name2 + " e победител, защото има повече кръв!");
                }
                else if (player2_hp <= player1_hp)
                {
                    Console.WriteLine("Герой 1 с име " + champion_name1 + " e победител, защото има повече кръв!");
                }    
            }
        }
    }
}