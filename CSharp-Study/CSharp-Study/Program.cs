internal class Program
{
    const int MAX_Count = 6;

    abstract class Pokemon  // Pokemon 부모 추상 클래스
    {
        protected string mName;
        public Pokemon(string name) { this.mName = name; }
        public string getName { get { return mName; } }
        public abstract void Attack();
    }

    class Skill
    { 
        
    }

    class Pikachu : Pokemon // 피카츄
    {
        public Pikachu(string name) : base(name) { }
        public override void Attack()
        {
            Console.WriteLine("스킬 사용 : 백만볼트");
        }
    }
    class Meowth : Pokemon // 뮤츠
    {
        public Meowth(string name) : base(name) { }
        public override void Attack()
        {
            Console.WriteLine("스킬 사용 : 염력");
        }
    }
    class Mew : Pokemon // 뮤
    {
        public Mew(string name) : base(name) { }
        public override void Attack()
        {
            Console.WriteLine("스킬 사용 : 사이코키네시스");
        }
    }
    class Chikorita : Pokemon // 치코리타
    {
        public Chikorita(string name) : base(name) { }
        public override void Attack()
        {
            Console.WriteLine("스킬 사용 : 베어가르기");
        }
    }
    class Wobbuffet : Pokemon   // 마자용
    {
        public Wobbuffet(string name) : base(name) { }
        public override void Attack()
        {
            Console.WriteLine("스킬 사용 : 맞아ㅇㅇㅇㅇㅇ용");
        }
    }

    class Psyduck : Pokemon   // 고라파덕
    {
        public Psyduck(string name) : base(name) { }
        public override void Attack()
        {
            Console.WriteLine("스킬 사용 : 흉내내기");
        }
    }

    class Trainer
    {
        public string mName;     // 트레이너 이름
        public int index = 0;    // 인덱스
        public Pokemon[] pokemon = new Pokemon[MAX_Count];  // 해당 트레이너가 가질 수 있는 포켓몬 인벤토리 최대 6

        public Trainer(string name) { mName = name; }

        public bool isHavePokemon()
        {
            return (index > 0); // 실제로 포켓몬이 하나라도 있으면 true
        }
        public bool isFullPokemon()
        {
            return (index >= MAX_Count); // 포켓몬이 가득 차면 true
        }
        public void Print()
        {
            if (isHavePokemon())
            {
                Console.WriteLine("{0}이 가진 포켓몬 목록", mName);
                for (int i = 0; i < index; i++) // index까지만 반복
                {
                    Console.WriteLine("{0}", pokemon[i].getName);
                }
            }
            else
            {
                Console.WriteLine("포켓몬이 하나도 없습니다.");
            }
        }

        public void getPokemon(Pokemon catchPokemon)
        {
            if (!isFullPokemon())
            {
                pokemon[index] = catchPokemon;
                index++; // 새로운 포켓몬을 추가할 때마다 index를 증가시킴
                Console.WriteLine("{0} 획득!",catchPokemon.getName);
            }
            else
            {
                Console.WriteLine("포켓몬 인벤토리가 가득 찼습니다.");
            }
        }
        public Pokemon pokemonPeek(int num)
        {
            if (isHavePokemon())
            {
                return pokemon[num];
            }
            else
            {
                Console.WriteLine("잘못된 인덱스 기입");
                return null;
            }
        }
    }

    // Main 함수
    static void Main(string[] args)
    {
        Pokemon[] filed = new Pokemon[6]; 
        Trainer kim = new Trainer("kim");

        Pokemon pikachu = new Pikachu("피카츄");
        Pokemon mew = new Mew("뮤");
        Pokemon meowth = new Meowth("뮤츠");
        Pokemon chikorita = new Chikorita("치코리타");
        Pokemon wobbuffet = new Wobbuffet("마자용");
        Pokemon psyduck = new Psyduck("고라파덕");

        kim.getPokemon(pikachu);
        kim.Print();
        filed[0] = kim.pokemonPeek(0);
        Console.WriteLine("내가 꺼낸 포켓몬 : {0}", filed[0].getName);
        filed[0] = kim.pokemonPeek(1);
        Console.WriteLine("--------------------------------------");
        kim.getPokemon(meowth);
        kim.getPokemon(chikorita);
        kim.getPokemon(wobbuffet);
        kim.getPokemon(psyduck);
        kim.Print();

        pikachu.Attack();
        mew.Attack();
        meowth.Attack();
        chikorita.Attack();
        wobbuffet.Attack();
        psyduck.Attack();
    }
}