﻿
using System.Collections.Generic;

namespace WEB_APPLICATION.Models
{
    public class Distrito
    {
        public int IdDistrito { get; set; } 
        public string Nombre { get;set; }
        
        //FK
        public int IdProvincia { get; set; }   
        public virtual Provincia Provincia { get; set; }    

        public virtual ICollection<DNI> DNIs { get; set; }  


    }
}
