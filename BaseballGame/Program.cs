using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace BaseballGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> operations = new List<string>{ "5", "2", "C", "D", "+" };
            List<string> stack = new List<string>();

            for (int i = 0; i < operations.Count; i++)
            {
                if (operations[i] == "C")
                    stack.RemoveAt(stack.Count);
                else if (operations[i] == "+")
                    stack.Add(operations[stack.Count - 1] + operations[stack.Count - 2]);
                else if (operations[i] == "D")
                    stack.Add((int.Parse(operations[i - 1])*2).ToString());
                else
                    stack.Add(operations[i]);





            }
            
            
        }
    }
}
