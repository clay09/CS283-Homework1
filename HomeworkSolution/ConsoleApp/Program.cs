using PokemonLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Attack> attack = new List<Attack>();
            attack.Add(new Attack()
            {
                Mode = "藤編",
                Power = 7
            });
            attack.Add(new Attack
            {
                Mode = "汙泥炸彈",
                Power = 80
            });

            Pokemon rule = new Pokemon()
            {
                Name = "妙蛙種子",
                Hp = 60,
                Weight = 5.94f,
                Property = "草/毒",
                Hieght = 0.67f,
                StarSand = 271484,
                Candy = 27,
                Strengthening = new Strengthening()
                {
                    StarSand = 3000,
                    Candy = 3
                },
                Evolution = new Evolution()
                {
                    Candy = 25
                },
                AttackMode = attack
            };

            Console.WriteLine($"名稱:{rule.Name}");
            Console.WriteLine($"血量:{rule.Hp}/{rule.Hp} HP");
            Console.WriteLine($"體重:{rule.Weight} , {rule.Property} , 身高:{rule.Hieght}");
            Console.WriteLine($"星星沙子:{rule.StarSand} , 妙蛙種子的糖果:{rule.Candy}");
            Console.WriteLine($"強化: 星星沙子:{rule.Strengthening.StarSand}  糖果:{rule.Strengthening.Candy}");
            Console.WriteLine($"進化: 糖果:{rule.Evolution.Candy}");
            foreach (var item in rule.AttackMode)
            {
                Console.WriteLine($"{item.Mode}  {item.Power}");
            }
        }
    }
}
