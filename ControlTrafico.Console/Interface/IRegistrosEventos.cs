using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlTrafico.Dominio;

namespace ControlTrafico.Console.Interface
{
    public interface IRegistrosEventos
    {

        void GuardarRegistroEventos(List<Eventlog> ListRegistrosEventos);

    }
}
