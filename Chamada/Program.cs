using System;
using System.Collections.Generic;
using Chamada.src;

namespace Chamada
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Boa tarde Boaz e Claubinho! Para consultar a Lista de Chamada de hoje, aperte ENTER: ");
            Console.ReadLine();
            Console.WriteLine("Processando...");
            Console.WriteLine("Lista pronta, aperte ENTER novamente para ver.");
            Console.ReadLine();

            List<Presenca> presencas = new List<Presenca>(new Presenca[]{
            new AnaPaula("Ana Paula", 1, "Turma Dotnet"),
            new AnaClementino("Ana Clementino", 2, "Turma Dotnet"),
            new Danny("Danny", 3, "Turma Dotnet"),
            new Erick("Erick", 4, "Turma Dotnet"),
            new Fabricio("Fabricio", 5, "Turma Dotnet"),
            new Gabriela("Gabriela", 6, "Turma Dotnet"),
            new Guilherme("Guilherme", 7, "Turma Dotnet"),
            new Gustavo("Gustavo", 8, "Turma Dotnet"),
            new Italo("Italo", 9, "Turma Dotnet"),
            new Jose("Jose", 10, "Turma Dotnet")
        }
            );

            foreach (Presenca presenca in presencas)
            {
                if (presenca.Numero == 1)
                {
                    Console.Write($"Alune: {presenca.Nome}, Nº{presenca.Numero}, {presenca.Serie} - "); presenca.Presente("Presente");
                    Console.WriteLine("Aperte Enter para continuar");
                    Console.ReadLine();
                }
                else if (presenca.Numero == 2)
                {
                    Console.Write($"Alune: {presenca.Nome}, Nº{presenca.Numero}, {presenca.Serie} - "); presenca.Presente("Presente");
                    Console.ReadLine();
                }
                else if (presenca.Numero == 3)
                {
                    Console.Write($"Alune: {presenca.Nome}, Nº{presenca.Numero}, {presenca.Serie} - "); presenca.Presente("Presente");
                    Console.ReadLine();
                }
                else if (presenca.Numero == 4)
                {
                    Console.Write($"Alune: {presenca.Nome}, Nº{presenca.Numero}, {presenca.Serie} - "); presenca.Presente("Falta");
                    Console.ReadLine();
                }
                else if (presenca.Numero == 5)
                {
                    Console.Write($"Alune: {presenca.Nome}, Nº{presenca.Numero}, {presenca.Serie} - "); presenca.Presente("Presente");
                    Console.ReadLine();
                }
                else if (presenca.Numero == 6)
                {
                    Console.Write($"Alune: {presenca.Nome}, Nº{presenca.Numero}, {presenca.Serie} - "); presenca.Presente("Falta");
                    Console.ReadLine();
                }
                else if (presenca.Numero == 7)
                {
                    Console.Write($"Alune: {presenca.Nome}, Nº{presenca.Numero}, {presenca.Serie} - "); presenca.Presente("Presente");
                    Console.ReadLine();
                }
                else if (presenca.Numero == 8)
                {
                    Console.Write($"Alune: {presenca.Nome}, Nº{presenca.Numero}, {presenca.Serie} - "); presenca.Presente("Falta");
                    Console.ReadLine();
                }
                else if (presenca.Numero == 9)
                {
                    Console.Write($"Alune: {presenca.Nome}, Nº{presenca.Numero}, {presenca.Serie} - "); presenca.Presente("Presente");
                    Console.ReadLine();
                }
                else if (presenca.Numero == 10)
                {
                    Console.Write($"Alune: {presenca.Nome}, Nº{presenca.Numero}, {presenca.Serie} - "); presenca.Presente("Falta");
                    Console.ReadLine();
                    Console.WriteLine("Lista Finalizada");
                }
            }

        }

    }
}