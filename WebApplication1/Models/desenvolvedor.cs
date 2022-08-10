using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class desenvolvedor
    {
        [Key]
        public int id { get; set; }
        public string foto { get; set; }
        public string nome { get; set; }
        public string bio { get; set; }

        //relaçao
        public List<Desenvolvedor_game> Desenvolvedores_games { get; set; }

    }
}
