using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTrafico.Core.Dominio
{
    public class Event
    {
        public Guid idProcess { get; set; }
        public string process { get; set; }
        public string usuario { get; set; }
        public DateTime Time_Control { get; set; }
        
        public Event()
        {
            this.idProcess = Guid.NewGuid();
        }

        public Event(Guid id)
        {
            this.idProcess = id;
        }
    }
}
