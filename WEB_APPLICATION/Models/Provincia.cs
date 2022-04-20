using System.Collections.Generic;

namespace WEB_APPLICATION.Models
{
    public class Provincia
    {
        public int IdProvincia { get; set; }
        public string Nombre { get; set; }

        //FK
        public int IdDepartamento { get; set; } 
        public virtual Departamento Departamento { get; set; }    

        public virtual ICollection<Distrito> Distritos { get; set; }


    }
}
