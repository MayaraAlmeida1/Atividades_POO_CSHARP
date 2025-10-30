
namespace Atividade_Gestao_de_Hotel
{
    public class Reserva
    {
        //* CRIANDO ATRIBUTOS
        public Hospede HospedeReserva {get; set;} // Criação de um objeto do tipo Hospede chamado HospedeReserva, esse objeto pega os valores do Hospede(nome, cpf, telefone)
        public Quarto QuartoReserva {get; set;} // Criação de um objeto do tipo Quarto chamado QuartoReserva, esse objeto pega os valores do Quarto (numero, tipo, preco, disponivel)
        public int Dias {get; set;}

        public double ValorTotal {get; set;} // Variável para o método CalcularTotal, calculando o valor total da reserva

        //* CRIANDO CONSTRUTOR
        public Reserva(Hospede HospedeConstrutor, Quarto QuartoConstrutor, int DiasConstrutor){ // Sempre é passado o tipo do dado (Hospede) e o nome da variável (HospedeConstrutor)
            HospedeReserva = HospedeConstrutor;
            QuartoReserva = QuartoConstrutor;
            Dias = DiasConstrutor;
        }

        //* CRIANDO MÉTODOS
        public virtual double CalcularTotal()
        {
            ValorTotal = QuartoReserva.PrecoDiaria * Dias;
            return ValorTotal;
        }

        public virtual string ResumoReserva(){
            return 
                // $"Hóspede {HospedeReserva.Nome} está hospedado no quarto {QuartoReserva.NumeroQuarto} por {Dias} dias. Pagando o total de R${ValorTotal}.";
                $"\nReserva de: {HospedeReserva.Nome}\nQuarto: {QuartoReserva.NumeroQuarto} ({QuartoReserva.TipoQuarto})\nValor Total: {CalcularTotal():F2} por {Dias} dias.";
        }
    }
}