using System.Collections.Generic;

namespace WEB_APPLICATION.Models
{
    public class Motivo
    {
        public int IdMotivo { get; set; }
        public string Detalle { get; set; } 

        //fk
        public int? IdCategoria { get; set; }
        public Categoria Categoria { get; set; }

        public virtual ICollection<Incidente> Incidentes { get; set; }

    }
}
