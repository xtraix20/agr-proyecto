using System.Linq;
using System.Collections.Generic;
using ProyectoAgro.app.Dominio;

namespace ProyectoAgro.app.Persistencia
{
    public interface IRepositorioAgro
    {
        IEnumerable <Persona> GetAllPersona();
        Persona AddPersona(Persona persona);
        Persona UpDatePaciente(Persona persona);
        void DeletePersona(int idPersona);
        Persona GetPersona(int idPersona);

        IEnumerable <Finca> GetAllFinca();
        Finca AddFinca(Finca finca);
        Finca UpDateFinca(Finca finca);
        void DeleteFinca(int idFinca);
        Finca GetFinca(int idFinca);

    }

}