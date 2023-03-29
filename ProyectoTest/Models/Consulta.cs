using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoTest.Models.ViewModels
{
    public class Consulta
    {
        public int Id { get; set; }

        public string Nombre { get; set; }
        public string mascota { get; set; }
        public DateTime Fecha_consulta { get; set; }

    }
}