
namespace Parte1_Classe_Normal_e_Heranca
{
    public class Moto : Veiculo
    {
         //* ATRIBUTOS EXTRAS
        public float Cilindrada {get; set;}

        //* CONSTRUTOR
        public Moto(string MarcaConstrutor, string ModeloConstrutor, int AnoConstrutor, float CilindradaConstrutor) :base(MarcaConstrutor, ModeloConstrutor, AnoConstrutor)
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
    }
}