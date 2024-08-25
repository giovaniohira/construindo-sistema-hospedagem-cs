namespace MeuProjeto.Models {
    public class Suite {
        public int Numero { get; private set; }
        public double Preco{ get; private set; }

        public Suite(int Numero, double Preco) {
            this.Numero = Numero;
            this.Preco = Preco;
        }
    }
}