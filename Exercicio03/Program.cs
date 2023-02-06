Console.WriteLine("------ Calcula o valor de uma multa de velocidade ------");



Console.Write("Velocidade maxima permitidada na via: ");
int velocidadeDaVia = Convert.ToInt32(Console.ReadLine());

Console.Write("Velocidade do Veículo: ");
int velocidadeDoVeiculo = Convert.ToInt32(Console.ReadLine());

double valorDaMulta = CalculaValorDaMulta(velocidadeDoVeiculo, velocidadeDaVia);

Console.WriteLine($"O valor da multa sera de R${valorDaMulta}");


double CalculaValorDaMulta(int velocidadeDoVeiculo, int velocidadeDaVia)
{
    int diferencaDeVelocidade = velocidadeDoVeiculo - velocidadeDaVia;

    if (diferencaDeVelocidade <= 0)
    {
        return 0;
    }

    if(diferencaDeVelocidade <= 10)
    {
        return 50;
    } else if (diferencaDeVelocidade > 10 && diferencaDeVelocidade <= 30)
    {
        return 100;
    } else
    {
        return 200;
    }
}