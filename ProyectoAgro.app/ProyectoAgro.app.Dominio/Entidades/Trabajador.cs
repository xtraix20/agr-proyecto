using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;


namespace ProyectoAgro.Dominio
{  
     [Table("Trabajadores")]
    public class Trabajador:Persona
    {
        public int IdTrabajador {get;set;}
        public string Cargo {get;set;}
        

    }

}

    