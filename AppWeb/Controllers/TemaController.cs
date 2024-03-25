using AppWeb.Models;
using LogicaAccesoDatos.Excepciones;
using LogicaAccesoDatos.Listas;
using LogicaAplicacion.Temas;
using LogicaNegocio.Entidades;
using LogicaNegocio.Excepciones.Tema;
using Microsoft.AspNetCore.Mvc;

namespace AppWeb.Controllers
{
    public class TemaController : Controller
    {

        AltaTema _altaTema = new AltaTema();
        EditarTema _editarTema = new EditarTema();
        EliminarTema _eliminarTema = new EliminarTema();
        ObtenerTema _obtenerTema = new ObtenerTema();
        ObtenerTemas _obtenerTemas = new ObtenerTemas();

        // GET: PaisController
        public IActionResult Index(string mensaje)
        {
            ViewBag.Mensaje = mensaje;
            return View(_obtenerTemas.Ejecutar());
        }

        // GET: PaisController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PaisController/Create
        [HttpPost]
        public IActionResult Create(Tema tema)
        {
            try
            {
                _altaTema.Ejecutar(tema);
                return RedirectToAction("Index", new { mensaje = "Se dio de alta el tema en forma exitosa." });
            }
            catch (IdInvalidaException e)
            {
                ViewBag.Error = e.Message;
            }
            catch (NombreInvalidaException e)
            {
                ViewBag.Error = e.Message;
            }
            catch (DescripcionInvalidaException e)
            {
                ViewBag.Error = e.Message;
            }
            catch (ArgumentNullRepositorioException ex)
            {
                ViewBag.Error = ex.Message;
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Hubo un error al crear el tema.Intente nuevamente.";
            }

            return View(tema);
        }

        // GET: PaisController/Edit/5
        public IActionResult Edit(int id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Tema tema = _obtenerTema.Ejecutar(id);
            if (tema == null)
            {
                return RedirectToAction("Index", new { mensaje = "No se encontró " + id });
            }
            return View(tema);

        }

        // POST: PaisController/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, Tema tema)
        {
            try
            {
                _editarTema.Ejecutar(id, tema);
                ViewBag.Mensaje = "Se editó el tema en forma exitosa.";
                return RedirectToAction("Index", new { mensaje = "Se editó el tema en forma exitosa." });
            }
            catch (NombreInvalidaException e)
            {
                ViewBag.Error = e.Message;
                return View(tema);
            }
            catch (DescripcionInvalidaException e)
            {
                ViewBag.Error = e.Message;
                return View(tema);
            }
            catch (ArgumentNullRepositorioException e)
            {
                ViewBag.Error = e.Message;
                return View(tema);
            }
            catch (NotFoundException e)
            {
                ViewBag.Error = e.Message;
                return View(tema);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Hubo un error al editar el tema. Intente nuevamente.";
                return RedirectToAction("Index", new { mensaje = ex.Message });
            }
        }

        // GET: PaisController/Details/5
        public IActionResult Details(int id)
        {
            try
            {
                Tema tema = _obtenerTema.Ejecutar(id);
                if (tema == null)
                {
                    throw new Exception("No se encontro el id");
                }
                return View(tema);
            }
            catch (Exception)
            {
                return RedirectToAction("Index", new { mensaje = "No se encontró " + id });
            }
        }

        // GET: PaisController/Delete/5
        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Tema tema = _obtenerTema.Ejecutar(id);
            if (tema == null)
            {
                return RedirectToAction("Index", new { mensaje = "No se encontró " + id });
            }
            return View(tema);

        }

        // POST: PaisController/Delete/5
        [HttpPost]
        public IActionResult Delete(Tema tema)
        {
            try
            {
                _eliminarTema.Ejecutar(tema.Id);
                return RedirectToAction("Index", new { mensaje = "Se dio de baja el tema en forma exitosa." });
            }
            catch (NotFoundException ex)
            {
                return RedirectToAction("Index", new { mensaje = ex.Message });
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", new { mensaje = "No se puedo dar de baja. Intente nuevamente." });
            }

        }
    }
}

