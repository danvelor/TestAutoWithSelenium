using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlTrafico.Core.Interface;
using ControlTrafico.Core.Dominio;
using ControTrafico.Infrastructure;
using ControTrafico.Infrastructure.PruebasDaniel;

namespace ControlTrafico.Infrastructure.Repositories
{
    public class EventLosgRepository : IEventLogs
    {
        public PruebaUEntitiesDaniel contextBD1;


        public void SaveEventlog(List<Core.Dominio.Event> listEventlog)
        {
            //contextBD = new PruebasEntities();

            List<ControTrafico.Infrastructure.PruebasDaniel.Eventlog> lisEventlogDto = new List<ControTrafico.Infrastructure.PruebasDaniel.Eventlog>();

            lisEventlogDto = DtoEventlog(listEventlog);

            //var contextBD = new PruebasEntities();
            contextBD1 = new PruebaUEntitiesDaniel();
            contextBD1.Eventlog.AddRange(lisEventlogDto);
            contextBD1.SaveChanges();


            //var persona = new personas()
            //{
            //    cedula = 712932577,
            //    nombre = "Juan Pruebas",
            //    clave = "123",
            //    usuario = "juan.pruebas"


            //};

            //contextBD.personas.Add(persona);
            

        }

        private List<ControTrafico.Infrastructure.PruebasDaniel.Eventlog> DtoEventlog(List<Core.Dominio.Event> listEventlog)
        {

            List<ControTrafico.Infrastructure.PruebasDaniel.Eventlog> ListDtoEventlog = new List<ControTrafico.Infrastructure.PruebasDaniel.Eventlog>();

            foreach (var item in listEventlog)
            {
                ControTrafico.Infrastructure.PruebasDaniel.Eventlog eventlog = new ControTrafico.Infrastructure.PruebasDaniel.Eventlog();

                eventlog.idProceso = item.idProcess;
                eventlog.proceso = item.process;
                eventlog.Tiempo_Control = item.Time_Control;


                ListDtoEventlog.Add(eventlog);
            }


            return ListDtoEventlog;
        }
    }
}
