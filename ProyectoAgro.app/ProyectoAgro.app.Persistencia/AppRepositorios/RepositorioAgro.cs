using System.Linq;
using System.Collections.Generic;
using ProyectoAgro.app.Dominio;


namespace ProyectoAgro.app.Persistencia
{
    public class RepositorioAgro: IRepositorioAgro
    {
        private AppContex _oContex;

        public RepositorioAgro (AppContex appContex)
        {
        _oContex=appContex;
        }

        Persona IRepositorioAgro.AddPersona(Persona persona)
        {
          var personaAdicionada=_oContex.Personas.Add(persona);
          _oContex.SaveChanges();
          return personaAdicionada.Entity;
        }
        void IRepositorioAgro.DeletePersona(int idPersona)
        {
            var personaEncontrada=_oContex.Personas.FirstOrDefault(p=> p.Id==idPersona);
            if(personaEncontrada==null)
                return;
            _oContex.Personas.Remove(personaEncontrada);
            _oContex.SaveChanges(); 
        }
        IEnumerable <Persona> IRepositorioAgro.GetAllPersona()
        {
             return _oContex.Personas;
        }
        Persona IRepositorioAgro.GetPersona(int idPersona)
        {
            return _oContex.Personas.FirstOrDefault(p=> p.Id==idPersona);
        }


        Persona IRepositorioAgro.UpDatePaciente(Persona persona)
        {
            var personaEncontrada=_oContex.Personas.FirstOrDefault(p=> p.Id==persona.Id);
            if(personaEncontrada!=null)
            {
               personaEncontrada.Nombre=persona.Nombre;

               _oContex.SaveChanges();

            }
            return personaEncontrada;

        }

        Finca IRepositorioAgro.AddFinca(Finca finca)
        {
          var fincaAdicionada=_oContex.Fincas.Add(finca);
          _oContex.SaveChanges();
          return fincaAdicionada.Entity;
        }

        void IRepositorioAgro.DeleteFinca(int idFinca)
        {
            var fincaEncontrada=_oContex.Fincas.FirstOrDefault(p=> p.Id==idFinca);
            if(fincaEncontrada==null)
                return;
            _oContex.Fincas.Remove(fincaEncontrada);
            _oContex.SaveChanges(); 
        }
        IEnumerable <Finca> IRepositorioAgro.GetAllFinca()
        {
             return _oContex.Fincas;
        }
        Finca IRepositorioAgro.GetFinca(int idFinca)
        {
            return _oContex.Fincas.FirstOrDefault(p=> p.Id==idFinca);
        }


        Finca IRepositorioAgro.UpDateFinca(Finca finca)
        {
            var fincaEncontrada=_oContex.Fincas.FirstOrDefault(p=> p.Id==finca.Id);
            if (fincaEncontrada!=null)
            {
               fincaEncontrada.NombFinca=finca.NombFinca;

               _oContex.SaveChanges();

            }
            return fincaEncontrada;
        
        }
    }

}

    
