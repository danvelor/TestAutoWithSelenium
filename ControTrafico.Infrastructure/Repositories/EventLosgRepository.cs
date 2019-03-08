using System.Collections.Generic;
using System.Linq;
using ControlTrafico.Core.Interface;
using ControTrafico.Infrastructure.Entity;

namespace ControlTrafico.Infrastructure.Repositories
{
    public class EventLosgRepository : IEventLogs
    {
        public PruebasEntities1 contextBD1;


        public void SaveEventlog(List<Core.Dominio.Event> listEventlog)
        {
            List<ControTrafico.Infrastructure.Entity.Eventlog> lisEventlogDto = new List<ControTrafico.Infrastructure.Entity.Eventlog>();
            lisEventlogDto = DtoEventlog(listEventlog);
            contextBD1 = new PruebasEntities1();
            contextBD1.Eventlog.AddRange(lisEventlogDto);
            contextBD1.SaveChanges();
        }


        public List<Core.Dominio.Event> EventList() {

            List<Core.Dominio.Event> ListEvent = new List<Core.Dominio.Event>();
            ListEvent = contextBD1.Eventlog.Select(x => new Core.Dominio.Event { user = x.usuario}).ToList();
            return ListEvent;
        }

        private List<ControTrafico.Infrastructure.Entity.Eventlog> DtoEventlog(List<Core.Dominio.Event> listEventlog)
        {

            List<ControTrafico.Infrastructure.Entity.Eventlog> ListDtoEventlog = new List<ControTrafico.Infrastructure.Entity.Eventlog>();

            foreach (var item in listEventlog)
            {
                ControTrafico.Infrastructure.Entity.Eventlog eventlog = new ControTrafico.Infrastructure.Entity.Eventlog();

                eventlog.idProceso = item.idProcess;
                eventlog.proceso = item.process;
                eventlog.Tiempo_Control = item.Time_Control;
                eventlog.usuario = item.user;
                ListDtoEventlog.Add(eventlog);
            }

            return ListDtoEventlog;
        }
        
    }
}
