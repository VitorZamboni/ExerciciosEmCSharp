Console.WriteLine("------ Gera 20 numeros e imprimes aqueles que: (n % 11 == 5)");

List<int> numeros = new List<int>();

for (int i = 0; i < 20; i++)
{
    numeros.Add(new Random().Next(1000, 1999));
}

foreach(int n in numeros)
{
    if (n % 11 == 5)
    {
        Console.WriteLine(n);
    }
}   