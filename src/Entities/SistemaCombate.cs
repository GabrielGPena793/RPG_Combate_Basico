namespace POOLive.src.Entities
{
    public class SistemaCombate
    {
        public void Confronto(Heroi Heroi, Inimigo inimigo)
        {
    
            System.Console.WriteLine(Heroi.Atacar());
            System.Console.WriteLine(inimigo.Atacar());


            if(Heroi.ValorUltimoAtaque == inimigo.ValorUltimoAtaque)
            {
                System.Console.WriteLine($"Empate!, Ambos deram {Heroi.ValorUltimoAtaque}");
            }
            else if(Heroi.ValorUltimoAtaque > inimigo.ValorUltimoAtaque)
            {
                System.Console.WriteLine($"{inimigo.Nome} recebe {Heroi.ValorUltimoAtaque - inimigo.ValorUltimoAtaque} de dano");
                inimigo.ReceberDano(Heroi.ValorUltimoAtaque - inimigo.ValorUltimoAtaque);
                System.Console.WriteLine($"{Heroi.Nome} venceu esse round!");
            }
            else
            {
                System.Console.WriteLine($"{Heroi.Nome} recebe {inimigo.ValorUltimoAtaque - Heroi.ValorUltimoAtaque} de dano");
                Heroi.ReceberDano(inimigo.ValorUltimoAtaque - Heroi.ValorUltimoAtaque);
                System.Console.WriteLine($"{inimigo.Nome} venceu esse round!");
            }

        }
    }
}