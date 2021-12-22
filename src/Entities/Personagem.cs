namespace POOLive.src.Entities
{

    public class Personagem
    {
        public string Nome { get; set; }
        public int Nivel { get; set; }
        public int PontosDeVida { get; set; }
        public int PontosDeMagia { get; set; }
        public string Classe { get; set; }
        public int ValorUltimoAtaque { get; set; }

        public Personagem(string Nome, string Classe)
        {
            this.Nome = Nome;
            this.Classe = Classe;
            this.Nivel = 1;
            this.PontosDeVida = 50;
            this.PontosDeMagia = 50;
        }

        //Exibição do Obejto
        public override string ToString(){
            return "Nome: " + this.Nome +
            "\nClasse: " + this.Classe +
            "\nNivel: " + this.Nivel +
            "\nPontos de vida: " + this.PontosDeVida +
            "\nPontos de Magia: " + this.PontosDeMagia;
        }

        public virtual string Atacar()
        {
            Random dado = new Random();
            int forcaAtaque = this.Nivel + dado.Next(1,20);
            this.ValorUltimoAtaque = forcaAtaque;

            return this.Nome + " Ataca e da " + forcaAtaque + " de dano" ;
        }

        public void ReceberDano(int danoRecebido)
        {
            this.PontosDeVida -= danoRecebido;
        }

    }
}