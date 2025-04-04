using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp_Study.design_pattern
{
    /*팩토리 패턴 실습
     * WeaponFactory 제작을 시도해보자
    1. 무기는 이름, 공격력, 공격 범위
    2. 팩토리를 통해서 무기 생성을 진행하는 경우
    (1) 철검, 나무창, 쇠도끼
    +) 무기 팩토리에 희귀도를 추가하여 제작 할 수 있도록 하자
    (1) 일반등급 +0% 데미지 추가, 희귀등급 +10%, 에픽 15퍼 전설등급: 20퍼

    internal class practice_250404
    {
        static void Main()
        {
            WeaponFactory weaponFactory = new WeaponFactory();
            Weapon ironSword = weaponFactory.Create("철검","노말");
            Weapon woodSpear =  weaponFactory.Create("나무창","레어");
            Weapon ironAxe = weaponFactory.Create("쇠도끼","전설");

            ironSword.Print();
            woodSpear.Print();
            ironAxe.Print();
            try
            {
                // 예외가 발생할 수 있는 코드
                //Weapon woodStick = weaponFactory.Create("나무막대기", "신화");
                Weapon ironSword2 = weaponFactory.Create("철검", "신화");
            }
            catch (ArgumentException ex) //매개변수 충족 하지않을 때 던져짐
            {
                Console.WriteLine("에러 발생: " + ex.Message);
            }
        }

        public class WeaponFactory
        {

            public Weapon Create(string name,string rarity) {
                Weapon weapon;

                switch (name)
                {
                    case "철검": weapon = new Weapon("철검",300,3); break;
                    case "나무창": weapon = new Weapon("나무창", 200, 5); break;
                    case "쇠도끼": weapon = new Weapon("쇠도끼",500,1); break;
                    default:
                        //throw new ArgumentException("존재하지 않는 무기 이름입니다: {0}",name);
                        //throw new ArgumentException(string, string) 생성자는 포맷 문자열이 아니라,
                        //첫 번째는 메시지, 두 번째는 "내부 파라미터" 용으로 쓰기 때문입니다.
                        throw new ArgumentException($"존재하지 않는 무기 이름입니다: {name}");                        
                }
                weapon.SetRarity(rarity);
                return weapon;
            }
        }

        public class Weapon
        {
            private string name;
            private int attackPoint;
            private int attackRange;

            public Weapon(string name,int ackPoint,int ackRange) { 
                this.name = name; this.attackPoint = ackPoint; this.attackRange = ackRange; }

            //Damage changes based on rarity
            public void SetRarity(string rarity)
            {
                switch (rarity)
                {
                    case "노말": 
                        this.attackPoint += attackPoint * 0; break;
                    case "레어":
                        this.attackPoint += (int)(attackPoint * 0.05); break;
                    case "희귀":
                        this.attackPoint += (int)(attackPoint * 0.1); break;
                    case "전설":
                        this.attackPoint += (int)(attackPoint * 0.2); break;
                    default:
                        //throw new ArgumentException("존재하지 않는 등급입니다: {0}", rarity);
                        throw new ArgumentException($"존재하지 않는 등급입니다: {rarity}");
                }
            }

            public void Print()
            {
                Console.WriteLine("이름 : {0}, 무기 공격력 : {1}, 무기 공격범위 : {2}", name, attackPoint, attackRange);
            }
        }
    }*/

    /*
    - 빌더 패턴 - 
    Animal Builder
    1. 동물은 이름, 생산품, 울음소리, 사료종류를 조합,
    2. 여러 종류의 동물을 구현할 수 있도록 빌더를 제작해보자
    동물의 종류 양,소,닭
    +) 희귀종 동물도 만들수 있도록 하자.
    (1) 희귀종 동물은 특수생산품을 생산하도록 구현하자.

    // TODO : 희귀종 동물은 특수 생산품을 생산하도록 구현하기
    */

 internal class practice_250404
 {
     public static void Main()
     {
         AnimalBuilder sheepBuilder = new AnimalBuilder()
             .SetName("양")
             .SetProuct("양털")
             .SetFeed("양 전용 사료");
         AnimalBuilder chickenBuilder = new AnimalBuilder()
             .SetName("닭")
             .SetProuct("달걀")
             .SetFeed("닭 전용 사료");
         AnimalBuilder cowBuilder = new AnimalBuilder()
            .SetName("소")
            .SetProuct("소고기")
            .SetFeed("소 전용 사료");

         Animal sheep = sheepBuilder.Build();
         Animal chicken = chickenBuilder.Build();
         Animal cow = cowBuilder.Build();

         sheep.Print();
         chicken.Print();
         cow.Print();
     }

     public class AnimalBuilder
     {
         public string name;
         public string product;
         public string feed;

         public AnimalBuilder()
         {
             name = "default name";
             product = "default product";
             feed = "default feed";
         }

         public AnimalBuilder SetName(string name)
         {
             this.name = name;
             return this;
         }

         public AnimalBuilder SetProuct(string product)
         {
             this.product = product;
             return this;
         }

         public AnimalBuilder SetFeed(string feed)
         {
             this.feed = feed;
             return this;
         }

         public Animal Build()
         {
             Animal animal = new Animal();
             animal.Name = name;
             animal.Product = product;
             animal.Feed = feed;

             return animal;
         }
     }

     public class Animal
     {
         public string Name { get; set; }
         public string Product { get; set; }
         public string Feed { get; set; }

         public void Print()
         {
             Console.WriteLine("이름 : {0}, 생산품 : {1}, 사료 : {2}",Name,Product,Feed);
         }
     }
 }
}
