using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlTrafico.Core.Interface;
using ControlTrafico.Core.Dominio;

namespace ControlTrafico.Core.Servicio
{
    public class ServiceEvent
    {
        private IEventLogs iEventLogs;

        public ServiceEvent(IEventLogs iEventLogs)
        {
            this.iEventLogs = iEventLogs;

        }

        public void Save_Event()
        {

            EventLogs _eventLogs = new EventLogs(iEventLogs);
            Event eventobj;

            for (int z = 0; z < 3; z++)
            {

                eventobj = new Event();
                Guid idproceso = eventobj.idProcess;

                for (int i = 0; i < 5; i++)
                {

                    eventobj = new Event(idproceso)
                    {
                        process = "Prueba_" + i.ToString(),
                        Time_Control = DateTime.Now,

                    }; ;

                    _eventLogs.EventLogs_add(eventobj);

                }
                _eventLogs.EvenLogs_Save();

            }

        }
    }
}
