using System;
namespace ProyectoAgro.Dominio
{
    public class Persona
    {
        public int Id {get;set;}
        public string Nombre{get;set;}
        public string Apeliidos{get;set;}
        public string NumeroTelenofo{get;set;}
        public string direccion {get;set;}
        public Genero Genero { set; get; }
        
    }
}