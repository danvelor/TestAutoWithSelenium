using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlTrafico.Core.Interface;
using ControlTrafico.Core.Dominio;


namespace ControlTrafico.Infrastructure
{
    public class Class1 : IRegistrosEventos
    {
        //public PruebasEntities contextBD; 


        public void GuardarRegistroEventos( List<Eventlog> listEventlog)
        {
            //contextBD = new PruebasEntities();

            DtoEventlog(listEventlog);

            var contextBD = new PruebasEntities();



            var persona = new personas()
            {
                cedula = 712932577,
                nombre = "Juan Pruebas",
                clave = "123",
                usuario = "juan.pruebas"


            };

            contextBD.personas.Add(persona);
            contextBD.SaveChanges();

        }

        private void DtoEventlog(List<Eventlog> listEventlog)
        {
            throw new NotImplementedException();
        }
    }
}
