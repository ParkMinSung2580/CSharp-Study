using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Study
{
    internal class Yosepus
    {
        /*
         * 요세푸스 문제
        n명이 동그랗게 모여있을때 숫자 k를 외치면 1번부터 시작해서 k번째 사람이 모임에서 빠지는 경우를 반복했을 때 
        마지막에 남아 있는 사람을 구하는 문제       
        
        배열
        리스트 
        연결리스트 //연결리스트 뺀거 + 3 가면 다음순서
         */

        static void Main(string[] args)
        {
            List<int> list = new List<int>();

            Console.WriteLine("사람 수를 입력하세요");     //4줄
            string input = Console.ReadLine();
            int humanNum = int.Parse(input);
            //Console.WriteLine(num);       //디버깅

            //죽을 사람 
            Console.WriteLine("빠지는 수 입력하세요");     //4줄
            string input2 = Console.ReadLine();
            int findNum = int.Parse(input2);
            //Console.WriteLine(num2); 

            for (int i = 0; i < humanNum; i++)
            {
                list.Add(i + 1);                //사람추가
            }

            //list 범위기반반복 리스트 잘들어갔는지 확인용
            /*foreach(int num in list)
            {
                Console.WriteLine("{0}", num);
            }*/

            int index = 0; // 시작 인덱스
            while (list.Count > 1)
            {
                // M-1 번째 사람을 찾음
                index = (index + findNum - 1) % list.Count;
                Console.WriteLine("제거된 사람: " + list[index]);
                list.RemoveAt(index); // 해당 사람을 리스트에서 제거
                Console.Write("남은 사람들 : ");
                foreach (int num in list)
                {
                    Console.Write("{0} ", num);
                }
                Console.Write("\n");
            }
        }
    }
}
