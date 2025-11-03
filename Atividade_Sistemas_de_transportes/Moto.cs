
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
            Console.WriteLine($"A moto {Modelo} de {Cilindrada}cc está pronta!");
        }

         public override string ExibirDetalhes()
        {
            return
                $">>> DETALHES DO VEÍCULO: <<<\nMarca: {Marca} \nModelo: {Modelo} \nAno: {Ano} \nCilindrada: {Cilindrada}cc";
        }
    }
}