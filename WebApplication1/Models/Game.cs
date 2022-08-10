using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication1.Data.Enums;

namespace WebApplication1.Models
{
    public class Game
    {
        [Key]
        public int id { get; set; }
        public string foto { get; set; }
        public string nome { get; set; }
        public string bio { get; set; }
        public double preço { get; set; }
        public GameCat GameCat { get; set; }
        public List<Desenvolvedor_game> Desenvolvedores_games { get; set; }

        //plataformas
        public int Plataformasid { get; set; }
        [ForeignKey("PlataformasId")]
        public Plataformas Plataformas { get; set; }

        //empressa
        public int empressaid { get; set; }
        [ForeignKey("empressaId")]
        public empressa empressa { get; set; }
    }
}
