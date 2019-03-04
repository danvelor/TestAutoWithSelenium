using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTrafico.infrastructure.DTO
{
    public class RegistrosEventos
    {
        public int id { get; set; }
        public string proceso { get; set; }
        public DateTime Tiempo_Control { get; set; }
    }
}
