namespace AtividadePOO;

internal class Program
{
    private static void Main(string[] args)
    {
        Veiculo[] veiculos =
        [
            new Carro("civic", 2010),
            new Moto("biz", 2010),
            new Caminhao("scania", 2024)
        ];
        foreach (var veiculo in veiculos)
        {
            veiculo.Ligar();
            veiculo.Acelerar();
        }
    }
}