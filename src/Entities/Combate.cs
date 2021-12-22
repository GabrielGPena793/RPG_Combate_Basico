namespace POOLive.src.Entities
{
    public class Combate
    {
        SistemaCombate sistemaCombate = new SistemaCombate();
        public void entrarCombate(Heroi heroi, Inimigo inimigo)
        {
            System.Console.WriteLine("Deseja atacar ?");
            System.Console.WriteLine("1 - sim");
            System.Console.WriteLine("2 - não");
            int resposta = int.Parse(Console.ReadLine());

            if(resposta == 1)
            {
                sistemaCombate.Confronto(heroi, inimigo);
            }
            else if(resposta == 2)
            {
                System.Console.WriteLine("Modo Combate encerrado!");
            }
        }
    }
}