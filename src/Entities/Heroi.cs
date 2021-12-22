namespace POOLive.src.Entities
{
    public class Heroi : Personagem
    {
        public Heroi(string Nome, string Classe) : base(Nome, Classe)
        {
        }
        //ataque com o cajado  
        public override string Atacar()
        {
            Random dado = new Random();
            int forcaAtaque = this.Nivel + dado.Next(1,10);
            this.ValorUltimoAtaque = forcaAtaque;

            return this.Nome + " Ataca com o seu cajado e da " + forcaAtaque + " de dano" ;
        }
        //atque com o cajado com bonus
        public string Atacar(int bonus)
        {
            Random dado = new Random();
            int forcaAtaque = this.Nivel + dado.Next(1,10) + bonus;
            this.ValorUltimoAtaque = forcaAtaque;

            return this.Nome + " Ataca com bônus com seu cajado e da "+ forcaAtaque + " de dano";
        }
    }
}