
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WEB_APPLICATION.Models
{
    public class DNI
    {
        public int IdDni { get; set; }
        [Required]
        [StringLength(8)]
        public string Dni { get; set; }
        [Required]
        public int? CodVerificacion { get; set; }
        public string Direccion { get; set; }
        public string Referencia { get; set; }

        public Usuario Usuario { get; set; }
        //fk
        public int IdDistrito { get; set; }
        public Distrito Distrito { get; set; }  

       


    }
}
