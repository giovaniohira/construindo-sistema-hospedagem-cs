using MeuProjeto.Models;

class Program {
    static void Main() {
        Pessoa p1 = new Pessoa("João", "123.456.789-00");
        Pessoa p2 = new Pessoa("Maria", "987.654.321-00");
        Suite s1 = new Suite(1, 100.0);
        Suite s2 = new Suite(2, 200.0);

        Reserva r1 = new Reserva(1, s1, p1, 11);
        Reserva r2 = new Reserva(1, s1, p2, 9);

        Console.WriteLine(r1.total);
        Console.WriteLine(r2.total);
    }
}