using System.ComponentModel.DataAnnotations;

namespace PC04.Models
{
    public class Registro
    {
         public int Id { get; set; }
        [Required]
        public string Nombre { get; set; }
      
        public string Url { get; set; }
    
        public string Apellido { get; set; }
    }
}