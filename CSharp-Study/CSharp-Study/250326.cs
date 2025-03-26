using System.Xml.Linq;

namespace _250336
{
    /*
     게임에서 플레이어가 다양한 물체 앞에서 상호작용 키를 누르면 앞 대상에 따라서 다양한 반응을 일으킬 수 있다.
    예를 들어 NPC앞에선 상호작용 키에 대화가 시작
    상자 앞에서 상호작용 키에 아이템 습득
    문 앞에서 상호작용 키의 이동 진행

    NPC중 상인 NPC는 상호작용 키에 상점을 열기
     */
    internal class Program
    {
        public class Player
        {
            private string mName { get; }
            public Player(string name) { mName = name; }
            public void Interaction(IInteractable interactable)
            {
                interactable.Interaction();
            }
        }

        public class NPC : IInteractable        //public abstract class NPC : IInteractable
        {
            public string mName { get; private set; }
            public NPC(string name) { mName = name; }
            public virtual void Interaction()
            {
                Console.WriteLine($"{mName} - 상호작용 : 대화하기");       //기본구현 if-> NPC 클래스를 추상클래스로 변환하면 interation()함수는 자식 클래스에서 반드시 구현하게 만들 수 있음 
            }
        }
        public class Shopkeeper : NPC, IInteractable
        {
            public Shopkeeper(string name) : base(name) { }
            public void OpenShop()
            {
                Console.WriteLine("상점을 열었다.");
            }

            public override void Interaction() //대화기능 및 + 상점 열기 기능 추가
            {
                base.Interaction();     //대화 후 상점 열기  
                OpenShop();
            }
        }
        public class Box : IInteractable
        {
            public string mName { get; private set; }
            public Box(string name) { mName = name; }
            public void Interaction()
            {
                Console.WriteLine($"{mName} - 상호작용 : 상자열기");
            }
        }
        public class Door : IInteractable
        {
            public string mName { get; private set; }
            public Door(string name) { mName = name; }
            public void Interaction()
            {
                Console.WriteLine($"{mName} - 상호작용 : 문열기");
            }
        }

        public interface IInteractable
        {
            void Interaction();
        }


        static void Main(string[] args)
        {
            //플레이어 객체 생성
            Player player = new Player("min seong");

            //npc 객체 생성 및 상호작용
            NPC normalNPC = new NPC("일반NPC");
            player.Interaction(normalNPC);
            Console.WriteLine("\n");

            //shopkeeper(상점npc) 객체 생성 및 상호작용
            Shopkeeper shopkeeper = new Shopkeeper("무기NPC");
            player.Interaction(shopkeeper);
            Console.WriteLine("\n");

            //box(상자) 객체 생성 및 상호작용
            Box box = new Box("수상한 상자");
            player.Interaction(box);
            Console.WriteLine("\n");

            //door(문) 객체 생성 및 상호작용
            Door door = new Door("나무 문");
            player.Interaction(door);
            Console.WriteLine("\n");
        }
    }
}