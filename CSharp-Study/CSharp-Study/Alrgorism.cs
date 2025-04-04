using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Study
{
    internal class Alrgorism
    {

        //선택 삽입 버블 머지 퀵 힙 정렬 

        //선택정렬
        public static void SelectSort(ref int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                int minIndex = i;
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                        minIndex = j;
                }
                 if (minIndex != i)
                 {
                    int temp = arr[i];
                    arr[i] = arr[minIndex];
                    arr[minIndex] = temp;
                 }
            }
        }

        //삽입정렬

        public static void InsertSort(ref int[] arr)
        {

        }

        public static void ArrPrint(int[] arr)
        {
            Console.WriteLine(string.Join(", ", arr));
        }

        public static void Main()
        {
            Random rand = new Random();
            int[] arr = new int[20]; // 크기 10의 배열 생성

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(1, 100); // 1부터 99까지의 랜덤 값 저장
            }
            // 배열 출력
            SelectSort(ref arr);
            ArrPrint(arr);
        }
    }
}
