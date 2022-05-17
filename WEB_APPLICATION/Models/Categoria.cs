using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WEB_APPLICATION.Models
{
    public class Categoria
    {
        public int IdCategoria { get; set; }

        [Required(ErrorMessage = "El campo Detalle es obligatorio")]
        [StringLength(20, ErrorMessage = "La categoria registrada no debe contener mas de 20 caracteres")]
        [RegularExpression(@"^[a-zA-Z\s]+$*", ErrorMessage = "No se permite el ingreso de numeros o simbolos")]
        public string Detalle { get; set; }

        public virtual ICollection<Motivo> Motivos { get; set; }

    }
}
