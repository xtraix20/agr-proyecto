using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace ProyectoAgro.Dominio
{
    [Table("LiderObra")]
    public class LiderObra:Persona
    {
        public int IdLider {get;set;}
        public string Cargo{get;set;}
    }
}