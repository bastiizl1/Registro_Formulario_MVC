using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Aplicacion_MVC_SerieIII.Dto
{
    public class FormularioDto
    {
        public decimal id { get; set; }
        public string nombre { get; set; }
        public string key { get; set; }
        public string label { get; set; }
        public string requerido { get; set; }
        public string orden { get; set; }
        public string control_type { get; set; }
        public string type { get; set; }
    }
}