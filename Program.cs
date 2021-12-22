using POOLive.src.Entities;

namespace POOLive
{
    class Program
    {
        static void Main(string[] args)
        {
            Heroi wedge = new Heroi("Wedge", "Mago-Negro");
            Inimigo KingMumy = new Inimigo("KingMumy", "Zumbi");
            Combate combate = new Combate();            

            combate.entrarCombate(wedge, KingMumy);
        

        }
    }
}
