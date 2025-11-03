namespace Atividade_Sistemas_de_transportes;

class Program
{
    static void Main(string[] args)
    {
        Carro carro1 = new Carro("Audi", "SUV Q8", 2024, 4);
        Moto moto1 = new Moto("Yamaha", "MT-125", 2016, 124.7);

        carro1.Ligar();
        carro1.ExibirDetalhes();

        moto1.Ligar();
        moto1.ExibirDetalhes();
    }
}
