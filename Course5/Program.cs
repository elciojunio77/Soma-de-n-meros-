﻿using System;
using System.Globalization;

namespace Course5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Quantos números intieros você vai digitar? ");
            int N = int.Parse(Console.ReadLine());

            int soma = 0;

            for (int i =1; i <= N; i++)
            {
                Console.WriteLine("Valor #{0}: ", i);
                int valor = int.Parse(Console.ReadLine());
                soma = soma + valor;
            }
            Console.WriteLine("Soma = " + soma);


        }
        


    }
}