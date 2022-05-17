using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WEB_APPLICATION.Models
{
    public class Motivo
    {
        public int IdMotivo { get; set; }
        [Required(ErrorMessage = "El campo Detalle es obligatorio")]
        [StringLength(20, ErrorMessage = "El motivo registrado no debe contener mas de 20 caracteres")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "No se permite el ingreso de numeros o simbolos")]
        public string Detalle { get; set; } 

        //fk
        public int? IdCategoria { get; set; }
        public Categoria Categoria { get; set; }

        public virtual ICollection<Incidente> Incidentes { get; set; }

    }
}
