// See https://aka.ms/new-console-template for more information
using System;

namespace IMC
{
    class Program
    {
        static void Main (string[] args)
        {
            // Entrada de dados
            Console.WriteLine("Digite o seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine($"Olá, {nome}!");

            Console.WriteLine("A seguir, digite o seu peso atual:");
            int peso = int.Parse(Console.ReadLine());
            Console.WriteLine(" \n");
            
            Console.WriteLine("Agora, digite a sua altura:");
            float altura = float.Parse(Console.ReadLine());
            Console.WriteLine(" \n");

            float imc = peso / (altura * 2);

            string imcResult = imc.ToString("0.0");
            Console.WriteLine(imcResult);

            //Condições
            if(imc < 17)
            {
                Console.WriteLine("Situação: muito abaixo do peso.");
                return;
            }
            else if (imc >= 17 && imc <= 18.4)
            {
                Console.WriteLine("Situação: abaixo do peso.");
                return;
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("Situação: peso normal.");
                return;
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("Situação: acima do peso.");
                return;
            }
            else if (imc >= 30 && imc <= 34.9)
            {
                Console.WriteLine("Situação: muito acima do peso.");
                return;
            }
            else {
                Console.WriteLine("Situação: muito acima do peso II");
                return;
            }

            Console.WriteLine(imc);
        }
    }
}
