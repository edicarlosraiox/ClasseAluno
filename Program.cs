using System;
using System.Globalization;
using ExemploClasseAluno.NotasAluno;

namespace classe
{
    class Program
    {
        static async void Main(string[] args)
        {
            CultureInfo CI = CultureInfo.InvariantCulture;

            Aluno aluno = new Aluno();


            Console.Write("Nome do Aluno: ");
            aluno.Nome = Console.ReadLine();
            Console.WriteLine("Digite as tres Notas do Aluno: ");
            aluno.Nota1 = double.Parse(Console.ReadLine(), CI);
            aluno.Nota2 = double.Parse(Console.ReadLine(), CI);
            aluno.Nota3 = double.Parse(Console.ReadLine(), CI);

            aluno.NotaFinal();
            

            Console.WriteLine("Nota Final = " 
            + aluno.NotaFinal().ToString("F2",CI));


            if(aluno.Aprovado())
            {
              Console.WriteLine("Aprovado");
            }

         else   {
                 Console.WriteLine("Reprovado");
                 Console.WriteLine("Faltaram :" + aluno.notaRestante().ToString("F2",CI));
            }
            
            

            
        }
    }
}