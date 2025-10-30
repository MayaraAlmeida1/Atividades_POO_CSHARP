
namespace Atividade_Gestao_de_Hotel
{
    public class Hospede
    {
        //* CRIANDO ATRIBUTOS
        public string Nome {get; set;}
        public string CPF {get; set;}
        public string Telefone {get; set;}

        //* CRIANDO CONSTRUTOR
        public Hospede(string NomeConstrutor, string CPFconstrutor, string TelefoneConstrutor){
            Nome = NomeConstrutor;
            CPF = CPFconstrutor;
            Telefone = TelefoneConstrutor;
        }

        //* CRIANDO MÉTODOS
        public void ExibirInformacoes()
        {
            Console.WriteLine($">>> Novo hóspede cadastrado no sistema: <<<");
            Console.WriteLine($"Hospede: {Nome}");
            Console.WriteLine($"CPF: {CPF}");
            Console.WriteLine($"Telefone: {Telefone}");
        }
    }
}