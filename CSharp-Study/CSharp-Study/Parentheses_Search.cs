using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Study
{
    internal class Parentheses_Search
    {
        static void Main(string[] args)
        {
            char[] open = { '(', '{', '[' };
            char[] close = { ')', '}', ']' };
            string input = Console.ReadLine(); //input
            Stack<char> st = new Stack<char>();
            string answer = "YES";

            for (int i = 0; i < input.Length; i++)
            {
                if (open.Contains(input[i]))
                {
                    st.Push(input[i]);
                }
                else if (close.Contains(input[i]))
                {
                    if (!st.Any()) // 닫는 괄호가 있는데 스택이 비어있으면 오류
                    {
                        answer = "NO";
                        break;
                    }
                    char lastOpen = st.Pop();
                    if (Array.IndexOf(open, lastOpen) != Array.IndexOf(close, input[i])) //open배열에서 가장 마지막에 들어온 열린괄호와 닫힌괄호에서의 현재 input[i] 즉,닫힌괄호를 만나자마자 해당 괄호와 인덱스가 맞는지?  
                    {
                        answer = "NO";
                        break;
                    }
                }
            }

            // 모든 괄호 처리가 끝났을 때 스택이 비어 있어야 정상
            if (st.Any())
            {
                answer = "NO";
            }

            Console.WriteLine(answer);
        }
    }
}
