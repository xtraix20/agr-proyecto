using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System;


namespace ProyectoAgro.Dominio
{
    [Table("Trazabilidad")]
    public class Trazabilidad: Finca
    {
        
        //public int Id {get;set;}
        public Etapa EtapaCultivo {get;set;}
        public DateTime FechaProduccion {get;set;}
        

    }
}