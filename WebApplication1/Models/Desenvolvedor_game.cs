namespace WebApplication1.Models
{
    public class Desenvolvedor_game
    {
        public int gameId { get; set; }
        public Game Game { get; set; }
        public int DesenvolvedorId { get; set; }
        public desenvolvedor desenvolvedor { get; set; }
    }
}
