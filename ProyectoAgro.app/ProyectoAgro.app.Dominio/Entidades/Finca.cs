using System;
namespace ProyectoAgro.Dominio
{
    public class Finca
    {
        public int Id {get;set;}
        public string NombFinca  {get;set;}
        public string Ubicacion  {get;set;}
        public int CantLotesDesig  {get;set;}
        public  int CantPlantasSembradas  {get;set;}
    }
}