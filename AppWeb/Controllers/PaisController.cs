using LogicaAccesoDatos.Excepciones;
using LogicaAccesoDatos.Listas;
using LogicaNegocio.Entidades;
using LogicaNegocio.Excepciones.Pais;
using Microsoft.AspNetCore.Mvc;
using AppWeb.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;
using LogicaNegocio.InterfazRepositorio;
using LogicaAplicacion.Paises;

namespace AppWeb.Controllers
{
    public class PaisController : Controller
    {
        AltaPais _altaPais = new AltaPais();
        EditarPais _editarPais = new EditarPais();
        EliminarPais _eliminarPais = new EliminarPais();
        ObtenerPais _obtenerPais = new ObtenerPais();
        ObtenerPaises _obtenerPaises = new ObtenerPaises();

        // GET: PaisController
        public IActionResult Index(string mensaje)
        {
            ViewBag.Mensaje = mensaje;
            return View(_obtenerPaises.Ejecutar());
        }

        // GET: PaisController/Details/5
        public IActionResult Details(int id)
        {
            try
            {
                Pais pais = _obtenerPais.Ejecutar(id);
                if (pais == null)
                {
                    throw new Exception("No se encontró el ID");
                }
                return View(pais);
            }
            catch (Exception)
            {
                return RedirectToAction("Index", new { mensaje = "No se encontró " + id });
            }

        }

        // GET: PaisController/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: PaisController/Create
        [HttpPost]
        public IActionResult Create(Pais pais)
        {
            try
            {
                _altaPais.Ejecutar(pais);
                return RedirectToAction("Index", new { mensaje = "Se dio de alta el pais en forma exitosa." });
            }
            catch (IdInvalidaException e)
            {
                ViewBag.Error = e.Message;
            }
            catch (NombreInvalidaException e)
            {
                ViewBag.Error = e.Message;
            }
            catch (CantHabitantesInvalidaException e)
            {
                ViewBag.Error = e.Message;
            }
            catch (ArgumentNullRepositorioException ex)
            {
                ViewBag.Error = ex.Message;
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Hubo un error al crear el pais.Intente nuevamente.";
            }

            return View(pais);
        }

        // GET: PaisController/Edit/5
        public IActionResult Edit(int id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Pais pais = _obtenerPais.Ejecutar(id);
            if (pais == null)
            {
                return RedirectToAction("Index", new { mensaje = "No se encontró " + id });
            }
            return View(pais);
        }

        // POST: PaisController/Edit/5
        [HttpPost]
        public IActionResult Edit(int id, Pais pais)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    ViewBag.Error = "La información ingresada no es válida.";
                    return View(pais);
                }
                _editarPais.Ejecutar(id, pais);
                return RedirectToAction("Index", new { mensaje = "Se editó el pais en forma exitosa." });
            }
            catch (NombreInvalidaException e)
            {
                ViewBag.Error = e.Message;
                return View(pais);
            }
            catch (CantHabitantesInvalidaException e)
            {
                ViewBag.Error = e.Message;
                return View(pais);
            }
            catch (ArgumentNullRepositorioException ex)
            {
                ViewBag.Error = ex.Message;
                return View(pais);
            }
            catch (Exception ex)
            {
                ViewBag.Error = "Hubo un error al editar el pais. Intente nuevamente.";
                return RedirectToAction("Index", new { mensaje = ex.Message });
            }
        }

        // GET: PaisController/Delete/5
        public IActionResult Delete(int id)
        {
            if (id == null)
            {
                return RedirectToAction("Index");
            }
            Pais pais = _obtenerPais.Ejecutar(id);
            if (pais == null)
            {
                return RedirectToAction("Index", new { mensaje = "No se encontró " + id });
            }
            return View(pais);
        }

        // POST: PaisController/Delete/5
        [HttpPost]
        public IActionResult Delete(Pais pais)
        {
            try
            {
                _eliminarPais.Ejecutar(pais.Id);
                return RedirectToAction("Index", new { mensaje = "Se dio de baja el pais en forma exitosa." });
            }
            catch (NotFoundException e)
            {
                return RedirectToAction("Index", new { mensaje = e.Message });
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return RedirectToAction("Index", new { mensaje = "No se pudo dar de baja. Intente nuevamente." });
            }
        }
    }
}
