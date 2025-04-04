using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Study.design_pattern
{
    internal class chain_Method
    {
        static void Main(string[] args)
        {
            GameObject gameObject = new GameObject();
            gameObject.SetX(1).SetY(2).SetZ(3);
            gameObject.Print();
        }

        public class GameObject
        {
            private int x;
            private int y;
            private int z;

            public GameObject SetX(int x)
            {
                this.x = x;
                return this;
            }

            public GameObject SetY(int y)
            {
                this.y = y;
                return this;
            }

            public GameObject SetZ(int z)
            {
                this.z = z;
                return this;
            }

            public void Print()
            {
                Console.WriteLine("x:{0} y:{1} z:{2}", x, y, z);
            }
        }
    }
}
