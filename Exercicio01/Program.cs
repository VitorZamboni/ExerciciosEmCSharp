using Exercicio01;

Console.WriteLine("-------- Boas Vindas a Escola Giga Byte -----------");
Aluno aluno = new Aluno();
while(aluno.Notas.Count < 3)
{
    Console.WriteLine("Digite a nota do aluno");
    aluno.SetNota(Convert.ToDouble(Console.ReadLine()));
}

Console.WriteLine("Digite o numero de faltas do aluno");
aluno.Faltas = (Convert.ToInt32(Console.ReadLine()));
Console.WriteLine($"Este aluno está :{aluno.GetSituacaoAluno()}");
