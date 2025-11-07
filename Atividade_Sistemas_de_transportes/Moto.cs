
namespace Atividade_Sistemas_de_transportes
{
    public class Moto : Veiculo
    {
         //* ATRIBUTOS EXTRAS
        public double Cilindrada {get; set;}

        //* CONSTRUTOR
        public Moto(string MarcaConstrutor, string ModeloConstrutor, int AnoConstrutor, double CilindradaConstrutor) :base(MarcaConstrutor, ModeloConstrutor, AnoConstrutor)
        {
            Marca = MarcaConstrutor;
            Modelo = ModeloConstrutor;
            Ano = AnoConstrutor;
            Cilindrada = CilindradaConstrutor;
        }

        //* SOBSCREVER MÉTODO
        public override void Ligar(){
            Console.WriteLine($"\nA moto {Modelo} de {Cilindrada}cc está pronta!");
        }

         public override void ExibirDetalhes()
        {
            Console.WriteLine($">> DETALHES DO VEÍCULO <<");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Ano: {Ano}");
            Console.WriteLine($"Cilindrada: {Cilindrada}cc");

        }
    }
}