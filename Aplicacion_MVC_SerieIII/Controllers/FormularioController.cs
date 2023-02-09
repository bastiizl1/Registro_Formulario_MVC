using Aplicacion_MVC_SerieIII.Dto;
using Aplicacion_MVC_SerieIII.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Aplicacion_MVC_SerieIII.Controllers
{
    public class FormularioController : Controller
    {
        // GET: Formulario
        public ActionResult Index()
        {
            return View();
        }

        //Para insertar un nuevo formulario
        [HttpPost]
        public ActionResult NuevoFormulario(FormularioDto objFormulario)
        {
            using (Entities_BD_Formulario ctx = new Entities_BD_Formulario())
            {
                DATOS_FORMULARIO formularioNuevo = new DATOS_FORMULARIO();

                formularioNuevo.NOMBRE_FORMULARIO = objFormulario.nombre;
                formularioNuevo.KEY_FORMULARIO = objFormulario.key;
                formularioNuevo.LABEL_FORMULARIO = objFormulario.label;
                formularioNuevo.REQURIDO_FORMULARIO = objFormulario.requerido;
                formularioNuevo.ORDEN_FORMULARIO = objFormulario.orden;
                formularioNuevo.CONTROL_TYPE = objFormulario.control_type;
                formularioNuevo.TYPE_FORMULARIO = objFormulario.type;

                ctx.DATOS_FORMULARIO.Add(formularioNuevo);
                ctx.SaveChanges();
            }
            return Json(new { result = true }, JsonRequestBehavior.AllowGet);
        }

        //Para obtener datos del formulario
        public JsonResult ObtenerDatosFormulario()
        {
            List<FormularioDto> datosForm = new List<FormularioDto>();

            using (Entities_BD_Formulario ctx = new Entities_BD_Formulario())
            {
                datosForm = (from df in ctx.DATOS_FORMULARIO
                                select new FormularioDto
                                {
                                    id = df.ID_FORMUALRIO,
                                    nombre = df.NOMBRE_FORMULARIO,
                                    key = df.KEY_FORMULARIO,
                                    label = df.LABEL_FORMULARIO,
                                    requerido = df.REQURIDO_FORMULARIO,
                                    orden = df.ORDEN_FORMULARIO,
                                    control_type = df.CONTROL_TYPE,
                                    type = df.TYPE_FORMULARIO
                                }).ToList();
            }
            return Json(datosForm, JsonRequestBehavior.AllowGet);
        }
    }
}