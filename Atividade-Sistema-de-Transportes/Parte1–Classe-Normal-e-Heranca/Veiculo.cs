
namespace Parte1_Classe_Normal_e_Heranca
{
    public class Veiculo
    {
        //* ATRIBUTOS
        public string Marca {get; set;}
        public string Modelo {get; set;}
        public int Ano {get; set;}

        //* CONSTRUTOR
        public Veiculo(string MarcaConstrutor, string ModeloConstrutor, int AnoConstrutor)
        {
            Marca = MarcaConstrutor;
            Modelo = ModeloConstrutor;
            Ano = AnoConstrutor;
        }

        //* MÉTODOS
        public virtual void Ligar()
        {
            Console.WriteLine($"O veículo {Modelo} está ligadp!");
        }

        public virtual void ExibirDetalhes()
        {
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
        }
    }
}