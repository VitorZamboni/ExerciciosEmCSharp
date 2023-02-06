using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01
{
    public class Aluno
    {

        private List<Double> notas = new List<double>(3);
        private double media;
        private int faltas;
        private SituacaoAluno situacao;
        public List<double> Notas { get => notas;}
        public int Faltas { get => faltas; set
            {
                if(value >= 0)
                {
                    faltas = value;
                }
            } }

        public SituacaoAluno GetSituacaoAluno()
        {
            SetSituacaoAluno();
            return situacao;
        }
        public void SetNota(double nota)
        {
            if(nota>=0 && nota <= 10)
            {
                this.Notas.Add(nota);
            } else
            {
                Console.WriteLine("Nota Invalida");
            }
        }
        private void SetSituacaoAluno()
        {
            SetMedia();
            if(media > 7 && faltas<=7)
            {
                this.situacao = SituacaoAluno.APROVADO;
            }
            else if (media > 3 && media < 7 && faltas<=7) 
            {
                this.situacao = SituacaoAluno.RECUPERACAO;
                Console.Write($"Aluno em {this.situacao} digite a nota da prova de recuperação: ");
                this.SetNota(Convert.ToDouble(Console.ReadLine()));
                SetMedia();
                if (media >= 5)
                {
                    this.situacao = SituacaoAluno.APROVADO;
                }
                else
                {
                    this.situacao = SituacaoAluno.REPROVADO;
                }
            }
            else
            {
                this.situacao = SituacaoAluno.REPROVADO;
            }
        }

        private void SetMedia()
        {
            double somatoria = 0;
            foreach(double nota in Notas)
            {
                somatoria += nota;
            }
            this.media = somatoria / Notas.Count();
        }
    }
}
