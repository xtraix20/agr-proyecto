using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System;


using System.Collections.Generic;
namespace ProyectoAgro.Dominio
{
    [Table("Lote")]
    public class Lote: Finca
    {
        public int IdLote {get;set;}
        public int NumeroLote {get;set;}
        
        public string TipoCultivo {get;set;}
        public string EstadoCultivo {get;set;}
    }
}
