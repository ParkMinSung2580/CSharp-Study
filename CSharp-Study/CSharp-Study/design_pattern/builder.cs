using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Study.design_pattern
{
    internal class builder
    {
        static void Main(string[] args)
        {
            MonsterBuilder orcArcherBuilder = new MonsterBuilder();
            orcArcherBuilder
                .SetName("오크 아처")
                .SetWeapon("나무 활")
                .SetArmor("가죽 갑옷");

            MonsterBuilder orcWarriorBuilder = new MonsterBuilder();
            orcWarriorBuilder
                .SetName("오크 전사")
                .SetWeapon("+99강 막대기")
                .SetArmor("미스릴 갑옷");

            Monster monster0 = orcArcherBuilder.Build();
            Monster monster1 = orcWarriorBuilder.Build();

            Console.WriteLine("{0} {1} {2}", monster0.name, monster0.weapon, monster0.armor);
            Console.WriteLine("{0} {1} {2}", monster1.name, monster1.weapon, monster1.armor);
        }
    }
        //builder pattern
    public class MonsterBuilder
    {
        public string name;
        public string weapon;
        public string armor;

        public MonsterBuilder()
        {
            name = "몬스터";
            weapon = "기본무기";
            armor = "기본갑옷";
        }

        public Monster Build()
        {
            Monster monster = new Monster();
            monster.name = name;
            monster.weapon = weapon;
            monster.armor = armor;

            return monster;
        }

        public MonsterBuilder SetName(string name)
        {
            this.name = name;
            return this;
        }

        public MonsterBuilder SetWeapon(string weapon)
        {
            this.weapon = weapon;
            return this;
        }

        public MonsterBuilder SetArmor(string armor)
        {
            this.armor = armor;
            return this;
        }
    }

    public class Monster
    {
        public string name;
        public string weapon;
        public string armor;
    }

 }
