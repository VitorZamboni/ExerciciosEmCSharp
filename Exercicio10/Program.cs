Console.WriteLine("------ Gera um numero e deves adivinhar qual é ------");
int numeroASerAdivinhado = new Random().Next(100);
int numeroDoUsuario = -1;
int tentativas = 0;
while (numeroDoUsuario != numeroASerAdivinhado)
{
    Console.Write("Chute um número: ");
    numeroDoUsuario = Convert.ToInt32(Console.ReadLine());
    if (numeroDoUsuario < numeroASerAdivinhado) 
    {
        Console.WriteLine("MAIOR");
    }
    else if (numeroDoUsuario > numeroASerAdivinhado) 
    {
        Console.WriteLine("MENOR");
    }
    tentativas++;
}

Console.WriteLine($"Acertou!!! Número de tentativas: {tentativas}");