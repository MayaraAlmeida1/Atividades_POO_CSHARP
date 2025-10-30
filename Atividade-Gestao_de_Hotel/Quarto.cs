
namespace Atividade_Gestao_de_Hotel
{
    public class Quarto
    {
         //* CRIANDO ATRIBUTOS
        public int NumeroQuarto {get; set;}
        public string TipoQuarto {get; set;} // no set já poderia manipular algumas regras de entrada, nesse caso poderia permitir escrever apenas Simples, Duplo ou Suíte
        public double PrecoDiaria {get; set;}
        public bool Disponivel {get; set;} = true;

        //* CRIANDO CONSTRUTOR
        public Quarto(int NumeroQuartoConstrutor, string TipoQuartoConstrutor, double PrecoDiariaConstrutor){
            NumeroQuarto = NumeroQuartoConstrutor;
            TipoQuarto = TipoQuartoConstrutor;
            PrecoDiaria = PrecoDiariaConstrutor;

            Disponivel = true; // Quarto inicializa como disponível
        }

        //* CRIANDO MÉTODOS
        public void ExibirDetalhes()
        {
            Console.WriteLine($">>> Informações do quarto: <<<");
            Console.WriteLine($"Quarto número: {NumeroQuarto}");
            Console.WriteLine($"Tipo de quarto: {TipoQuarto}");
            Console.WriteLine($"Preço da Diária: {PrecoDiaria:F2}");
            
            if(Disponivel){
                Console.WriteLine("O quarto está disponível para reserva");
            } else {
                Console.WriteLine("O quarto já está reservado.");
            }
        }

        public void Ocupar(){
            if(Disponivel){
                Disponivel = false; // Agora o quarto está sendo ocupado
                Console.WriteLine($"O quarto {NumeroQuarto} foi reservado.");
            } else {
                Console.WriteLine($"O quarto {NumeroQuarto} já está ocupado.");
            }
        }

        public void Liberar(){
            if(!Disponivel){ // Se o quarto estiver reservado (false) e quiser ser liberado
                Disponivel = true;
                Console.WriteLine($"O quarto {NumeroQuarto} está liberado para reserva!");
            } else {
                Console.WriteLine($"O quarto {NumeroQuarto} já está disponível para reserva.");
            }
        }
    }
}