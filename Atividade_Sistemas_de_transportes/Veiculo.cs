
namespace Atividade_Sistemas_de_transportes
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

        public virtual string ExibirDetalhes()
        {
            return
                $">>> DETALHES DO VEÍCULO: <<<\nMarca: {Marca} \nModelo: {Modelo} \nAno: {Ano}";
        }
    }
}