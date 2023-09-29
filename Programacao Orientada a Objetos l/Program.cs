using System;

/* Escreva uma classe cujos objetos representam alunos matriculados em uma disciplina.
         * Cada objeto dessa classe deve guardar os seguintes dados do aluno:
         * matrícula, nome, 2 notas de prova e 1 nota de trabalho.
         * Construa os seguintes métodos para esta classe:
         * métodos construtores,
         * registrar nota de cada prova e trabalho,
         *  calcula a média final do aluno (cada prova tem peso 2,5 e o trabalho tem peso 2).
         * Teste na main, se atente para o que precisar ser public, private, parametros, retornos.. 
         */

namespace Exercicio1Aluno
{

    public class Program
    {
        static void Main(string[] args)
        {
            Aluno aluno1 = new Aluno(2154, "João");

            aluno1.definirNotas(5.3, 6.5, 7);

            double media = Math.Round(aluno1.definirMedia(), 2);

            Console.WriteLine($"O Aluno {aluno1.nome}, matricula {aluno1.matricula} ficou com a média {media}.");

            if (aluno1.definirAprovacao(media))
            {
                Console.WriteLine("O aluno foi Aprovado!");
            }
            else
            {
                Console.WriteLine("O aluno foi Reprovado!");
            }


        }
    }
}