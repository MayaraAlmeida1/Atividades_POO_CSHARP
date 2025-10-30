
namespace Parte1_Classe_Normal_e_Heranca
{
    public class Carro : Veiculo
    {
         //* ATRIBUTOS EXTRAS
        public int quantidadePortas {get; set;}

        //* CONSTRUTOR
        public Carro(string MarcaConstrutor, string ModeloConstrutor, int AnoConstrutor, int quantidadePortasConstrutor) :base(MarcaConstrutor, ModeloConstrutor, AnoConstrutor)
        {
            Marca = MarcaConstrutor;
            Modelo = ModeloConstrutor;
            Ano = AnoConstrutor;
            quantidadePortas = quantidadePortasConstrutor;
        }

        //* SOBSCREVER MÉTODO
        public override void Ligar(){
            Console.WriteLine($"O carro {Modelo} está pronto para rodar!");
        }
    }
}