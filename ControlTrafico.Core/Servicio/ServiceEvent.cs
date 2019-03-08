using System;
using ControlTrafico.Core.Interface;
using ControlTrafico.Core.Dominio;

namespace ControlTrafico.Core.Servicio
{
    public class ServiceEvent
    {
        private Guid idprocess { get; set; }
        private IEventLogs iEventLogs;

        private EventLogs eventLogs;
        private EventLogs _eventLogs { get { return this.eventLogs; } set { this.eventLogs = new EventLogs(iEventLogs); } }

        public ServiceEvent(IEventLogs iEventLogs)
        {
            this.iEventLogs = iEventLogs;
        }

        public void Save_Event()
        {
            idprocess = Guid.Empty;
            _eventLogs.EvenLogs_Save();
        }

        public void Insert_Event(string nameprocess, string user)
        {
            Event eventobj = new Event(idprocess)
            {
                process = nameprocess,
                Time_Control = DateTime.Now,
                user = user
            };
            idprocess = eventobj.idProcess;
            _eventLogs.EventLogs_add(eventobj);
        }




    }

}
