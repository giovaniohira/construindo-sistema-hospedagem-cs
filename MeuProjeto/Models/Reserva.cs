namespace MeuProjeto.Models {
    public class Reserva {
        public int Id;
        public Suite Suite;
        public Pessoa Pessoa;
        public int Dias;

        public double Total {
            get {
                if (Dias < 10) {
                    return suite.preco * Dias;
                }
                return suite.preco * Dias * 0.9;
            }
        }


        public Reserva(int Id, Suite Suite, Pessoa Pessoa, int Dias) {
            this.Id = Id;
            this.Suite = Suite;
            this.Pessoa = Pessoa;
            this.Dias = Dias;
        }
    }
}