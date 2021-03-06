﻿using System.Collections.Generic;
using ControlTrafico.Core.Interface;

namespace ControlTrafico.Core.Dominio
{
    public class EventLogs
    {

        public List<Event> ListEventLogs { get; set; }

        public IEventLogs iEventLogs { get; set; }

        public EventLogs(IEventLogs iEventLogs)
        {
            this.iEventLogs = iEventLogs;
            ListEventLogs = new List<Event>();
        }

        public void EventLogs_add(Event eventlogobj)
        {
            ListEventLogs.Add(eventlogobj);
        }

        public void EvenLogs_Save()
        {

            if (ListEventLogs.Count > 0)
            {
                iEventLogs.SaveEventlog(ListEventLogs);
            }

        }

    }
}
