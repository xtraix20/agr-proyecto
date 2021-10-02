using System;
namespace ProyectoAgro.Dominio
{
    public class Insumo
    {
        public int Id {get;set;}
        public string NombProducto {get;set;}
        public int CantEntrada{get;set;}
        public int CantSalida{get;set;}
        public int CantBodega{get;set;}
        public string PrecioCompra{get;set;}
        public DateTime FechaCompra{get;set;}
        public string Tipos{get;set;}
    }
}