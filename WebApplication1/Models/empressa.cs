using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class empressa
    {
        [Key]
        public int id { get; set; }
        public string foto { get; set; }
        public string nome { get; set; }
        public string bio { get; set; }

        //relaçao
        public List<Game> Games { get; set; }
    }
}
