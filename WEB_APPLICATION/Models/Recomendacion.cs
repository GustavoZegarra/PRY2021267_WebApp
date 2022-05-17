using System.ComponentModel.DataAnnotations;

namespace WEB_APPLICATION.Models
{
    public class Recomendacion
    {
        public int IdRecomendacion { get; set; }
        [Required(ErrorMessage = "El campo Detalle es obligatorio")]
        [StringLength(250, ErrorMessage = "La recomendacion registrada no debe contener mas de 250 caracteres")]
        public string Detalle { get; set; }
        
        //fk
        public int? IdNivel { get; set; }
        public Nivel Nivel { get; set; }

    }
}
