namespace POOLive.src.Entities
{
    public class Inimigo : Personagem
    {
        public Inimigo(string Nome, string Classe) : base(Nome, Classe)
        {
            this.PontosDeMagia = 0;
            this.PontosDeVida = 80;
        }

        
        public override string Atacar()
        {
            Random dado = new Random();
            int forcaAtaque = this.Nivel + dado.Next(1,20);
            this.ValorUltimoAtaque = forcaAtaque;

            return this.Nome + " Ataca e da " + forcaAtaque + " de dano";
        }

    }
}