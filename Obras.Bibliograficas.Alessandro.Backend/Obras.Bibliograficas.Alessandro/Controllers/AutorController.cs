using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Obras.Bibliograficas.Alessandro.Domain;
using Obras.Bibliograficas.Alessandro.Domain.Autores;

namespace Obras.Bibliograficas.Alessandro.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AutorController : ControllerBase
	{
		IAutorService _service;

		public AutorController(IAutorService service)
		{
			_service = service;
		}

		// GET api/autor
		[HttpGet]
		public ActionResult<IEnumerable<Autor>> Get()
		{
			return _service.Listar();
		}

		// GET api/autor/5
		[HttpGet("{id}")]
		public ActionResult<Autor> Get(int id)
		{
			return _service.Buscar(new Autor { Id = id });
		}

		// POST api/autor
		[HttpPost]
		public ActionResult Post([FromBody] Autor autor)
		{
			if (ModelState.IsValid)
			{
				_service.Cadastrar(autor);
				return Ok();
			}
			else
			{
				return BadRequest(ModelState);
			};
		}

		// PUT api/autor/5
		[HttpPut("{id}")]
		public ActionResult Put(int id, [FromBody] Autor autor)
		{
			if (ModelState.IsValid)
			{
				_service.Alterar(autor);
				return Ok(autor);
			}
			else
			{
				return BadRequest(ModelState);
			};
		}

		// DELETE api/autor/5
		[HttpDelete("{id}")]
		public ActionResult Delete(int id)
		{
			_service.Remover(new Autor { Id = id });
			return Ok();
		}
	}
}