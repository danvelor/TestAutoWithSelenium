using ControlTrafico.Core.Dominio;
using System.Collections.Generic;

namespace ControlTrafico.Core.Interface
{
    public interface IEventLogs
    {
        void SaveEventlog(List<Event> ListRegistrosEventos);
        
        List<Event> EventList();
        
    }
}
