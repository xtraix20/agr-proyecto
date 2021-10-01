using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace ProyectoAgro.Dominio
{
    [Table("DueñoFinca")]
    public class DueñoFinca:Persona
    {
        public int IdDueño {get;set;}
        public string NombFinca {get;set;}
    }
}