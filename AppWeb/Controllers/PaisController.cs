using Dominio.Entidades;
using Dominio.Excepciones.Pais;
using Microsoft.AspNetCore.Mvc;

namespace AppWeb.Controllers
{
	public class PaisController : Controller
	{
		private static List<Pais> _pais = new List<Pais>();

		// GET: PaisController
		public IActionResult Index(string mensaje)
		{
			ViewBag.Mensaje = mensaje;
			ViewBag.ExitoMessage = TempData["ExitoMessage"];
			ViewBag.ListaPaises = _pais;
			return View(_pais);
		}

		// GET: PaisController/Details/5
		public IActionResult Details(int id)
		{
			var pais = _pais.FirstOrDefault(p => p.Id == id);
			if (pais == null)
			{
				return NotFound();
			}
			return View(pais);
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
			if (pais == null)
			{
				return NotFound();
			}

			try
			{
				pais.Validar();
				_pais.Add(pais);
				TempData["ExitoMessage"] = "Se dio de alta un país";
				return RedirectToAction("Index");
			}
			catch (IdInvalidaException ex)
			{
				ViewBag.Error = ex.Message;
			}
			catch (NombreInvalidaException ex)
			{
				ViewBag.Error = ex.Message;
			}
			catch (CantHabitantesInvalidaException ex)
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
			ViewBag.ListaPaises = _pais;
			return View(pais);
		}

		// GET: PaisController/Edit/5
		public IActionResult Edit(Pais unPais)
		{
			var pais = _pais.FirstOrDefault(p => p.Id == unPais.Id);
			ViewBag.ListaPaises = _pais;
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

				var existingPais = _pais.FirstOrDefault(p => p.Id == id);
				if (existingPais == null)
				{
					return NotFound();
				}

				existingPais.Nombre = pais.Nombre;
				existingPais.CantHabitantes = pais.CantHabitantes;

				TempData["ExitoMessage"] = "Se actualizó el país";
				return RedirectToAction("Index");
			}
			catch (Exception ex)
			{
				ViewBag.Error = "Hubo un problema. Intenta nuevamente o llama a soporte: " + ex.Message;
			}

			ViewBag.ListaPaises = _pais;
			return View(pais);
		}

		// GET: PaisController/Delete/5
		[HttpGet]
		public IActionResult Delete(int id)
		{
			var paisToDelete = _pais.FirstOrDefault(p => p.Id == id);
			if (paisToDelete == null)
			{
				return NotFound();
			}

			return View(paisToDelete);
		}

		// POST: PaisController/Delete/5
		[HttpPost]
		public IActionResult Delete(Pais pais)
		{
			try
			{
				// Find the pais to delete
				var paisToDelete = _pais.FirstOrDefault(p => p.Id == pais.Id);
				if (paisToDelete == null)
				{
					throw new Exception("No se encontró el país a eliminar");
				}

				// Delete the data and redirect to the index page
				_pais.RemoveAll(p => p.Id == pais.Id);
				TempData["ExitoMessage"] = "Se eliminó el país";
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
