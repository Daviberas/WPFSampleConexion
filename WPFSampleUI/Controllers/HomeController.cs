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
        // GET: Home
        public ActionResult Index()
        {
            clsListadosBL lista = new clsListadosBL();

            return View(lista.getListadoPersonasBL());
        }

        public ActionResult Create()
        {
            return View();
        }

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
            clsPersona persona;

            try
            {
                persona = new clsManejadoraPersonaBL().obtenerPersonaBL(id);

                i = new clsManejadoraPersonaBL().borrarPersonaBL(persona);
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