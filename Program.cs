﻿using pz1;

namespace pz1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter exercise number(1-4): ");
            int menu = int.Parse(Console.ReadLine());
           
            switch(menu)
            {
                case 1:
                    Ex1 ex1 = new Ex1();
                    ex1.Exercise();
                    break;
                case 2:
                    Ex2 ex2 = new Ex2(); 
                    ex2.Exercise();
                    break;
                case 3:
                    Ex3 ex3 = new Ex3();
                    ex3.Exercise();
                    break;
                case 4:
                    Ex4 ex4 = new Ex4();
                    ex4.Exercise();
                    break;
            }
        }
    }
}