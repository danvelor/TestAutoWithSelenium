﻿using ControlTrafico.Core.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlTrafico.Core.Interface
{
    public interface IRegistrosEventos
    {

        void GuardarRegistroEventos(List<Eventlog> ListRegistrosEventos);

    }
}