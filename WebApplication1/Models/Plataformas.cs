using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Plataformas
    {
        [Key]
        public int id { get; set; }
        public string foto { get; set; }
        public string nome { get; set; }
        public string bio { get; set; }

        public List<Game> Games { get; set; }
    }
}
