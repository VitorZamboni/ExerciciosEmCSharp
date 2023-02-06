Console.WriteLine("------ Sequencia de Fibonacci ------");

Console.Write("Informe quantos termos queres que tenha a sequencia: ");
int tamanho = Convert.ToInt32(Console.ReadLine());

int primeiroTermo = 0;
int segundoTermo = 1;
Console.WriteLine(primeiroTermo);
Console.WriteLine(segundoTermo);

for(int i = 0;i < tamanho-2; i++)
{
    int temp = segundoTermo;
    segundoTermo += primeiroTermo;
    primeiroTermo = temp;
    Console.WriteLine(segundoTermo);
}