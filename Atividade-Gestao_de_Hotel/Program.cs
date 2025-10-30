namespace Atividade_Gestao_de_Hotel;

class Program
{
    static void Main(string[] args)
    {
        //* CRIANDO HÓSPEDES
        Hospede hospede1 = new Hospede("Mayara Souza Almeida", "123.456.789-00", "(11) 99985-9645");
        Hospede hospede2 = new Hospede("Andreia Kátia Souza", "987.654.321-11", "(11) 45889-6513");

        //* CRIANDO QUARTOS
        Quarto quarto1 = new Quarto(101, "Simples", 120.50);
        Quarto quarto2 = new Quarto(201, "Suíte", 335);

        //* CRIANDO RESERVAS
        Console.WriteLine("\n>>> Controle de reservas <<<");
        Reserva reserva1 = new Reserva(hospede1, quarto1, 3); // É passado como parâmetro o objeto criado de hospede e quarto, pois esse objeto vai com todos os valores (hospede 1 e quarto 1)
        ReservaVIP reservaVIP1 = new ReservaVIP(hospede2, quarto2, 5, 20); // 20 é a porcentagem

        //* CRIANO LISTA PARA RESERVAS (facilita organização)
        List<Reserva> reservas = new List<Reserva> { reserva1, reservaVIP1 }; // "<Reserva>" mostra o tipo da lista, nesse caso estamos criando uma lista para a classe Reserva

        foreach (var reserva in reservas) // Variável "reserva" criada é o auxiliar que percorre a lita "reservas" fazendo as ações em cada um dos objetos achados
        {
            reserva.CalcularTotal(); // Calcular o total de todos os elementos que o auxiliar "reserva" encontrou
            Console.WriteLine(reserva.ResumoReserva()); // Imprime o resumo da reserva de todos os elementos que o auxiliar "reserva" encontrou


        }
    }
}
