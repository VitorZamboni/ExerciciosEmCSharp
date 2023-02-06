Console.WriteLine("------ Gera uma matriz identidade da ordem que o usuario solicitar ------");
Console.Write("Digite a ordem que queres a matriz: ");
int ordem = Convert.ToInt32(Console.ReadLine());

for (int linha = 1; linha <= ordem; linha++)
{
	for (int coluna = 0; coluna <= ordem; coluna++)
	{
		if (coluna == linha)
		{
			Console.Write("1 ");
		}
		else
		{
			Console.Write("0 ");
		}

	}
	Console.WriteLine();
}
