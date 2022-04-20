
using System.Collections.Generic;

namespace WEB_APPLICATION.Models
{
  
    
    
    public class Continente
    {
        public int IdContinente { get; set; }   
        public string Nombre { get; set; }
        public string Codigo { get; set; }

        public virtual ICollection<Pais> Paises { get; set; }

    }
}
