using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WPFSampleBL;
using WPFSampleBL.Manejadora;
using WPFSampleEntities;

namespace WPFSampleUI.Controllers
{
    public class HomeController : Controller
    {
        /// <summary>
        /// Muestra la vista de la página principal, con un listado de personas.
        /// </summary>
        /// <returns>Una vista con un listado de personas.</returns>
        
        public ActionResult Index()
        {
            clsListadosBL lista = new clsListadosBL();

            return View(lista.getListadoPersonasBL());
        }

        /// <summary>
        /// Muestra la vista de la página de inserción de personas.
        /// </summary>
        /// <returns>Una vista con un formulario.</returns>

        public ActionResult Create()
        {
            return View();
        }

        /// <summary>
        /// Muestra la vista de la página principal, con un listado de personas con la nueva persona añadida.
        /// </summary>
        /// <param name="persona">Tipo persona, recibido de la propia vista Create.</param>
        /// <returns>La vista principal con el listado de personas, si se realiza la inserción correctamente, en caso de error, una vista de una pagina de error.</returns>

        [HttpPost]
        public ActionResult Create(clsPersona persona)
        {
            int i;
            clsListadosBL lista = new clsListadosBL();
            if (!ModelState.IsValid)
                return View(persona);
            else
            {
                try
                {
                    i = new clsManejadoraPersonaBL().insertarPersonaBL(persona);
                    return View("Index", lista.getListadoPersonasBL());
                }
                catch (Exception)
                {
                    return View("paginaError");
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>

        public ActionResult Edit(int id)
        {
            return View();
        }

        [HttpPost, ActionName("Edit")]
        public ActionResult EditConfirmed(clsPersona persona)
        {
            int i;
            clsListadosBL lista = new clsListadosBL();
            if (!ModelState.IsValid)
                return View(persona);
            else
            {
                try
                {
                    i = new clsManejadoraPersonaBL().actualizarPersonaBL(persona);
                    return View("Index", lista.getListadoPersonasBL());
                }
                catch (Exception)
                {
                    return View("paginaError");
                }
            }
        }

        public ActionResult Delete(int id)
        {
            clsPersona i;

            try
            {
                i = new clsManejadoraPersonaBL().obtenerPersonaBL(id);
                return View(i);
            }
            catch (Exception)
            {
                return View("paginaError");
            }
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            int i;
            clsListadosBL lista = new clsListadosBL();

            try
            {

                i = new clsManejadoraPersonaBL().borrarPersonaBL(id);
                return View("Index", lista.getListadoPersonasBL());
            }
            catch (Exception)
            {
                return View("paginaError");
            }

        }

        public ActionResult Details(int id)
        {
            clsPersona i;

            try
            {
                i = new clsManejadoraPersonaBL().obtenerPersonaBL(id);
                return View(i);
            }
            catch (Exception)
            {
                return View("paginaError");
            }
        }
    }
}