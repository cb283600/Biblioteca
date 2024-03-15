using Dominio.Entidades;
using Dominio.Excepciones.Tema;
using Microsoft.AspNetCore.Mvc;

namespace AppWeb.Controllers
{
	public class TemaController : Controller
	{
		private static List<Tema> _tema = new List<Tema>();

		// GET: TemaController
		public IActionResult Index(string mensaje)
		{
			ViewBag.Mensaje = mensaje;
			ViewBag.ExitoMessage = TempData["ExitoMessage"];
			ViewBag.ListaPaises = _tema;
			return View(_tema);
		}

		// GET: TemaController/Details/5
		public IActionResult Details(int id)
		{
			var tema = _tema.FirstOrDefault(t => t.Id == id);
			if (tema == null)
			{
				return NotFound();
			}
			return View(tema);
		}

		// GET: TemaController/Create
		public IActionResult Create()
		{
			return View();
		}

		// POST: TemaController/Create
		[HttpPost]
		public IActionResult Create(Tema tema)
		{
			if (tema == null)
			{
				return NotFound();
			}

			try
			{
				tema.Validar();
				_tema.Add(tema);
				TempData["ExitoMessage"] = "Se dio de alta un tema";
				return RedirectToAction("Index");
			}
			catch (IdInvalidaException ex)
			{
				ViewBag.Error = ex.Message;
			}
			catch (DescriptionInvalidaException ex)
			{
				ViewBag.Error = ex.Message;
			}
			catch (ArgumentException ex)
			{
				ViewBag.Error = ex.Message;
			}
			catch (Exception ex)
			{
				ViewBag.Error = "Hubo un problema. Intenta nuevamente o llame a soporte";
			}
			ViewBag.ListaTemas = _tema;
			return View(tema);
		}

		// GET: TemaController/Edit/5
		public IActionResult Edit(Tema unTema)
		{
			var tema = _tema.FirstOrDefault(p => p.Id == unTema.Id);
			ViewBag.ListaTemas = _tema;
			return View(tema);
		}

		// POST: TemController/Edit/5
		[HttpPost]
		public IActionResult Edit(int id, Tema tema)
		{
			try
			{
				if (!ModelState.IsValid)
				{
					ViewBag.Error = "La información ingresada no es válida.";
					return View(tema);
				}

				var existingTema = _tema.FirstOrDefault(t => t.Id == id);
				if (existingTema == null)
				{
					return NotFound();
				}

				existingTema.Nombre = tema.Nombre;
				existingTema.Description = tema.Description;

				TempData["ExitoMessage"] = "Se actualizó el tema";
				return RedirectToAction("Index");
			}
			catch (Exception ex)
			{
				ViewBag.Error = "Hubo un problema. Intenta nuevamente o llama a soporte: " + ex.Message;
			}

			ViewBag.ListaTemas = _tema;
			return View(tema);
		}

		// GET: TemaController/Delete/5
		[HttpGet]
		public IActionResult Delete(int id)
		{
			var temaToDelete = _tema.FirstOrDefault(p => p.Id == id);
			if (temaToDelete == null)
			{
				return NotFound();
			}

			return View(temaToDelete);
		}

		// POST: TemaController/Delete/5
		[HttpPost]
		public IActionResult Delete(Tema tema)
		{
			try
			{
				// Find the pais to delete
				var temaToDelete = _tema.FirstOrDefault(p => p.Id == tema.Id);
				if (temaToDelete == null)
				{
					throw new Exception("No se encontró el tema a eliminar");
				}

				// Delete the data and redirect to the index page
				_tema.RemoveAll(p => p.Id == tema.Id);
				TempData["ExitoMessage"] = "Se eliminó el tema";
				return RedirectToAction("Index");
			}
			catch (Exception ex)
			{
				ViewBag.Error = ex.Message;
				return RedirectToAction("Index");
			}
		}
	}
}
