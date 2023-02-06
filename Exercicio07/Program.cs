Console.WriteLine("------ Calcula e exibe os divisores de um número ------");
Console.Write("Inoforme um número: ");
int numero = Convert.ToInt32(Console.ReadLine());

List<int> divisores = new List<int>();
for (int i = 1; i < numero; i++)
{
    if (numero % i == 0) divisores.Add(i);
}

foreach (var divisor in divisores)
{
    Console.WriteLine(divisor);
}
