using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WEB_APPLICATION.Models
{
    public class Nivel
    {
        public int IdNivel { get; set; }
        [Required(ErrorMessage = "El campo Detalle es obligatorio")]
        [StringLength(30, ErrorMessage = "El riesgo registrado no debe contener mas de 12 caracteres")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "No se permite el ingreso de numeros o simbolos")]
        public string Riesgo { get; set; }
        [Required(ErrorMessage = "El campo de limite superior de precipitacion es obligatorio")]
        [Range(0, float.MaxValue, ErrorMessage = "Por favor ingresar un numero valido")]
        [RegularExpression(@"^[0-9]*(?:\.[0-9]*)?$", ErrorMessage = "Por favor ingresar un numero")]
        public float? PrecipitacionLimSup { get; set; }
        [Required(ErrorMessage = "El campo de limite inferior de precipitacion es obligatorio")]
        [Range(0, float.MaxValue, ErrorMessage = "Por favor ingresar un numero valido")]
        [RegularExpression(@"^[0-9]*(?:\.[0-9]*)?$", ErrorMessage = "por favor ingresar un numero")]
        public float? PrecipitacionLimInf { get; set; }

        public virtual ICollection<Alerta> Alertas { get; set; }
        public virtual ICollection<Recomendacion> Recomendaciones { get; set; }
    }
}
