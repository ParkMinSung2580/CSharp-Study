using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CSharp_Study.design_pattern
{
    //프로토 타입
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
                        /*throw new ArgumentException(string, string) 생성자는 포맷 문자열이 아니라,
                        첫 번째는 메시지, 두 번째는 "내부 파라미터" 용으로 쓰기 때문입니다.*/
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
    }
}
