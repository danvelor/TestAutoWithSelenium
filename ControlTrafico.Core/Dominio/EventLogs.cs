using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlTrafico.Core.Interface;

namespace ControlTrafico.Core.Dominio
{
    public class EventLogs
    {
       
        public List<Event> ListEventLogs { get; set; }
        public Event EventObj { get; set; }

        public IEventLogs iEventLogs { get; set; }

        public EventLogs( IEventLogs iEventLogs)
        {
            this.iEventLogs = iEventLogs;
            ListEventLogs = new List<Event>();
        }

        public void EventLogs_add(Event eventlogobj) {

            ListEventLogs.Add(eventlogobj);

        }

        public void EvenLogs_Save(List<Event> listEventlog) {
            iEventLogs.SaveEventlog(listEventlog);
        }
        
    }
}
