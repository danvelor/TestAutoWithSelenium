using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlTrafico.Console.Interface;

namespace ControlTrafico.Dominio
{
    public class RegistrosEventos
    {
       
        public List<Eventlog> ListRegistrosEventos { get; set; }
        public IRegistrosEventos iRegistrosEventos { get; set; }

        public RegistrosEventos( IRegistrosEventos iRegistrosEventos)
        {
            this.iRegistrosEventos = iRegistrosEventos;
            ListRegistrosEventos = new List<Eventlog>();
        }

        public void addRegistrosEventos(Eventlog eventlogobj) {

            ListRegistrosEventos.Add(eventlogobj);

        }

        public void saveRegistrosEventos(List<Eventlog> listEventlog) {
            iRegistrosEventos.GuardarRegistroEventos(listEventlog);
        }
        
    }
}
