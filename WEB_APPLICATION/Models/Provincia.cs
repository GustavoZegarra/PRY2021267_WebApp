using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WEB_APPLICATION.Models
{
    public class Provincia
    {
        public int IdProvincia { get; set; }
        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        [StringLength(20, ErrorMessage = "La provincia registrada no debe contener mas de 20 caracteres")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "No se permite el ingreso de numeros o simbolos")]
        public string Nombre { get; set; }

        //FK
        public int IdDepartamento { get; set; } 
        public virtual Departamento Departamento { get; set; }    

        public virtual ICollection<Distrito> Distritos { get; set; }


    }
}
