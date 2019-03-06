using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTrafico.Dominio
{
    public class Eventlog
    {
        public Guid id { get; set; }
        public string proceso { get; set; }
        public DateTime Tiempo_Control { get; set; }

        public Eventlog()
        {
            this.id = new Guid();
        }

        public Eventlog(Guid id)
        {
            this.id = id;
        }
    }
}
