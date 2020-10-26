using System;
using System.Collections.Generic;

namespace _19._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string text = string.Empty;
            Stack<string> editor = new Stack<string>();
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (command[0] == "1")
                {
                    string addition = command[1];
                    text += addition;
                    editor.Push(text);
                }
                else if (command[0] == "2")
                {
                    int count = int.Parse(command[1]);
                    if (count <= text.Length && text.Length != 0 && count != 0)
                    {
                        text = text.Remove(text.Length - count, count);
                        editor.Push(text);
                    }
                }
                else if (command[0] == "3")
                {
                    int index = int.Parse(command[1]);
                    if (index <= text.Length && index != 0)
                    {
                        Console.WriteLine(text[index - 1]);
                    }
                }
                else if (command[0] == "4")
                {
                    if (editor.Count > 1)
                    {
                        editor.Pop();
                        text = editor.Peek();
                    }
                    else if (editor.Count == 1)
                    {
                        editor.Pop();
                        text = string.Empty;
                    }
                }
            }
        }
    }
}
