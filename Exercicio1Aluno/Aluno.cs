using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio1Aluno
{
    internal class Aluno
    {
        public int matricula;
        public string nome;
        private double prova1;
        private double prova2;
        private double trabalho1;


        /// <summary>
        /// Método contrutor utilizado para guardar as informações (nome e matricula) do aluno. 
        /// </summary>
        /// <param name="matricula"></param>
        /// <param name="nome"></param>
        internal Aluno(int matricula, string nome)
        {
            this.matricula = matricula;
            this.nome = nome;

        }

        /// <summary>
        /// Método criado para setar "valores" necessarios para o exercicio..  
        /// </summary>
        /// <param name="notaProva1"></param>
        /// <param name="notaProva2"></param>
        /// <param name="notaTrabalho1"></param>
        internal void definirNotas(double notaProva1, double notaProva2, double notaTrabalho1)
        {
            prova1 = notaProva1;
            prova2 = notaProva2;
            trabalho1 = notaTrabalho1;
        }
        /// <summary>
        /// Este método tem como funcionalidade de calcular a média ponderada.
        /// </summary>
        /// <returns></returns>
        internal double definirMedia()
        {
            double media = (prova1 * 2.5 + prova2 * 2.5 + trabalho1 * 2) / 7;
            return media;

        }

        /// <summary>
        /// Método que defini se o aluno foi aprovado ou reprovado. 
        /// </summary>
        /// <param name="media"></param>
        /// <returns></returns>
        public bool definirAprovacao(double media)
        {
            if (media >= 6)
            {
                return true;
            }
            return false;
        }
    }
}
