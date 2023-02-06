Console.WriteLine("------ Diz se um ano é ou não bissexto ------");
Console.Write("Informe o ano:");

int ano = Convert.ToInt32(Console.ReadLine());

bool AnoEhBissexto = ((ano % 400 == 0) || (ano % 4 == 0 && ano % 100 != 0));
if (AnoEhBissexto)
{
    Console.WriteLine(ano+" é bissexto");
} else
{
    Console.WriteLine(ano + " não é bissexto");
}

