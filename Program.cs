﻿namespace _17
{
    internal class Program
    {
        static bool Check(string s) 
        {
            int num1 = 0, num2 = 0;
            for (int i = 0; i < 6; i += 2) { num1 += int.Parse(s[i].ToString()); }
            for (int i = 1; i < 6; i += 2) { num2 += int.Parse(s[i].ToString()); }
            return num1 == num2;
        }
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string numberNext = Convert.ToString(int.Parse(number) + 1);
            string numberEarly = Convert.ToString(int.Parse(number) - 1);
            if (Check(numberNext) || Check(numberEarly)) Console.WriteLine(true); else Console.WriteLine(false); 
        }
    }
}