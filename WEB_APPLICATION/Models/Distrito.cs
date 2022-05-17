
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WEB_APPLICATION.Models
{
    public class Distrito
    {
        public int IdDistrito { get; set; }

        [Required(ErrorMessage = "El campo Nombre es obligatorio")]
        [StringLength(15, ErrorMessage = "El distrito registrado no debe contener mas de 15 caracteres")]
        [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "No se permite el ingreso de numeros o simbolos")]
        public string Nombre { get;set; }
        
        //FK
        public int IdProvincia { get; set; }   
        public virtual Provincia Provincia { get; set; }    

        public virtual ICollection<DNI> DNIs { get; set; }  


    }
}
