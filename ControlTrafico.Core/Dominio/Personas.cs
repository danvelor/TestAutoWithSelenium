using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTrafico.Core.Dominio
{
    public class personas
    {
        public int id { get; set; }
        public string usuario { get; set; }
        public string clave { get; set; }
        public Nullable<int> cedula { get; set; }
        public string nombre { get; set; }
    }
}
